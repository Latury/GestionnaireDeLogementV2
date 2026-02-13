/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Factures - Modification
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using GestionnaireDeLogement.Donnees;
using GestionnaireDeLogement.Modeles;
using GestionnaireDeLogement.Utilitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GestionnaireDeLogement.Vues
{
    public partial class ModifierFactureVue : Page
    {
        // ═══════════════════════════════════════════════════════════
        // Module [1] VARIABLES PRIVÉES
        // ═══════════════════════════════════════════════════════════

        private Facture factureAModifier;
        private List<Facture> toutesLesFactures;

        // ═══════════════════════════════════════════════════════════
        // Module [2] CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════

        public ModifierFactureVue(Facture facture)
        {
            InitializeComponent();

            factureAModifier = facture;
            toutesLesFactures = GestionnaireDonnees.Charger<Facture>("factures.json");

            InitialiserVue();
        }

        // ═══════════════════════════════════════════════════════════
        // Module [3] INITIALISATION GÉNÉRALE
        // ═══════════════════════════════════════════════════════════

        private void InitialiserVue()
        {
            ChargerDonneesFacture();
            VerifierEcheanceRetard();
            MettreAJourStatistiques();
            AfficherAutresFactures();
        }

        // ═══════════════════════════════════════════════════════════
        // Module [4] CHARGEMENT DONNÉES FORMULAIRE
        // ═══════════════════════════════════════════════════════════

        private void ChargerDonneesFacture()
        {
            switch (factureAModifier.Type)
            {
                case "Eau": CmbType.SelectedIndex = 0; break;
                case "Électricité": CmbType.SelectedIndex = 1; break;
                case "Chauffage": CmbType.SelectedIndex = 2; break;
                default: CmbType.SelectedIndex = 3; break;
            }

            TxtMontant.Text = factureAModifier.Montant.ToString("F2");
            DateFacture.SelectedDate = factureAModifier.DateFacture;
            DateEcheance.SelectedDate = factureAModifier.DateEcheance;
            ChkPayee.IsChecked = factureAModifier.EstPayee;
            TxtNotes.Text = factureAModifier.Notes;
        }

        // ═══════════════════════════════════════════════════════════
        // Module [5] VÉRIFICATION RETARD
        // ═══════════════════════════════════════════════════════════

        private void VerifierEcheanceRetard()
        {
            if (!factureAModifier.EstPayee &&
                factureAModifier.DateEcheance.HasValue &&
                factureAModifier.DateEcheance.Value.Date < DateTime.Now.Date)
            {
                TxtAlerteEcheance.Visibility = Visibility.Visible;
                BorderEcheance.BorderBrush = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString(Couleurs.RougeUrgent)
                );
            }
        }

        // ═══════════════════════════════════════════════════════════
        // Module [6] STATISTIQUES
        // ═══════════════════════════════════════════════════════════

        private void MettreAJourStatistiques()
        {
            var nonPayees = toutesLesFactures.Where(f => !f.EstPayee).ToList();

            var relances = nonPayees.Where(f =>
                f.DateEcheance.HasValue &&
                f.DateEcheance.Value.Date < DateTime.Now.Date
            ).ToList();

            TxtNbNonPayees.Text = nonPayees.Count.ToString();
            TxtNbRelances.Text = relances.Count.ToString();
            TxtTotalMontant.Text = nonPayees.Sum(f => f.Montant).ToString("F2");
        }

        // ═══════════════════════════════════════════════════════════
        // Module [7] AFFICHAGE AUTRES FACTURES
        // ═══════════════════════════════════════════════════════════

        private void AfficherAutresFactures()
        {
            if (ListeAutresFactures == null) return;

            List<Facture> facturesFiltrees;

            if (RbRelance.IsChecked == true)
            {
                facturesFiltrees = toutesLesFactures
                    .Where(f => f.Id != factureAModifier.Id &&
                                !f.EstPayee &&
                                f.DateEcheance.HasValue &&
                                f.DateEcheance.Value.Date < DateTime.Now.Date)
                    .OrderBy(f => f.DateEcheance)
                    .ToList();
            }
            else
            {
                facturesFiltrees = toutesLesFactures
                    .Where(f => f.Id != factureAModifier.Id && !f.EstPayee)
                    .OrderBy(f => ObtenirNiveauUrgence(f))
                    .ThenBy(f => f.DateEcheance)
                    .ToList();
            }

            ListeAutresFactures.ItemsSource = facturesFiltrees;
            ListeAutresFactures.Visibility = facturesFiltrees.Any()
                ? Visibility.Visible
                : Visibility.Collapsed;

            MessageVide.Visibility = facturesFiltrees.Any()
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        // ═══════════════════════════════════════════════════════════
        // Module [8] NIVEAU D'URGENCE
        // ═══════════════════════════════════════════════════════════

        private int ObtenirNiveauUrgence(Facture facture)
        {
            if (!facture.DateEcheance.HasValue)
                return 4;

            int jours = (facture.DateEcheance.Value.Date - DateTime.Now.Date).Days;

            if (jours < 0) return 0;
            if (jours <= 7) return 1;
            if (jours <= 15) return 2;

            return 3;
        }

        // ═══════════════════════════════════════════════════════════
        // Module [9] BOUTONS PRINCIPAUX
        // ═══════════════════════════════════════════════════════════

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Annuler les modifications ?",
                "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                NavigationService?.GoBack();
            }
        }

        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TxtMontant.Text, out double montant))
            {
                MessageBox.Show("Montant invalide.",
                                "Erreur",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

            factureAModifier.Type = ((ComboBoxItem)CmbType.SelectedItem)?.Content.ToString();
            factureAModifier.Montant = montant;
            factureAModifier.DateFacture = DateFacture.SelectedDate ?? DateTime.Now;
            factureAModifier.DateEcheance = DateEcheance.SelectedDate;
            factureAModifier.EstPayee = ChkPayee.IsChecked == true;
            factureAModifier.Notes = TxtNotes.Text;

            GestionnaireDonnees.Sauvegarder(toutesLesFactures, "factures.json");

            MessageBox.Show("Facture modifiée avec succès.",
                            "Succès",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

            NavigationService?.GoBack();
        }

        private void RbFiltreFactures_Checked(object sender, RoutedEventArgs e)
        {
            AfficherAutresFactures();
        }

        private void ChkPayee_Checked(object sender, RoutedEventArgs e)
        {
            // Réagir si besoin
        }

        // ═══════════════════════════════════════════════════════════
        // Module [10] GESTION VISUELLE DES CARTES
        // ═══════════════════════════════════════════════════════════

        private void CarteFacture_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Border border && border.Tag is Facture facture)
            {
                string couleur = ObtenirNiveauUrgence(facture) switch
                {
                    0 => Couleurs.RougeUrgent,
                    1 => Couleurs.OrangeMoyen,
                    2 => Couleurs.Jaune,
                    3 => Couleurs.VertMoyen,
                    _ => Couleurs.Gris250
                };

                border.BorderBrush = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString(couleur)
                );
            }
        }

        private void TxtBadgeUrgence_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is TextBlock txt && txt.Tag is Facture facture)
            {
                int urgence = ObtenirNiveauUrgence(facture);

                if (urgence == 4) return;

                var data = urgence switch
                {
                    0 => ("URGENT", Couleurs.FondRougeClair, Couleurs.RougeUrgent),
                    1 => ("7 jours", Couleurs.FondOrangeClair, Couleurs.OrangeSombre),
                    2 => ("15 jours", Couleurs.FondJauneClair, Couleurs.JauneSombre),
                    3 => ("OK", Couleurs.FondVertClair, Couleurs.VertSombre),
                    _ => ("", "", "")
                };

                txt.Text = data.Item1;
                txt.Background = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString(data.Item2)
                );
                txt.Foreground = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString(data.Item3)
                );
            }
        }
    }
}
