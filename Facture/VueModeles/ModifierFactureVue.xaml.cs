/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Chauffage
 *
 *  Copyright © 2026 Flo
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
    /// <summary>
    /// Logique d'interaction pour ModifierFactureVue.xaml
    /// </summary>
    public partial class ModifierFactureVue : Page
    {
        private Facture factureAModifier;
        private List<Facture> toutesLesFactures;

        public ModifierFactureVue(Facture facture)
        {
            InitializeComponent();

            factureAModifier = facture;
            toutesLesFactures = GestionnaireDonnees.Charger<Facture>("factures.json");

            ChargerDonneesFacture();
            VerifierEcheanceRetard();
            MettreAJourStatistiques();
            AfficherAutresFactures();
        }

        private void ChargerDonneesFacture()
        {
            switch (factureAModifier.Type)
            {
                case "Eau":
                    CmbType.SelectedIndex = 0;
                    break;
                case "Électricité":
                    CmbType.SelectedIndex = 1;
                    break;
                case "Chauffage":
                    CmbType.SelectedIndex = 2;
                    break;
                default:
                    CmbType.SelectedIndex = 3;
                    break;
            }

            TxtMontant.Text = factureAModifier.Montant.ToString("F2");
            DateFacture.SelectedDate = factureAModifier.DateFacture;
            DateEcheance.SelectedDate = factureAModifier.DateEcheance;
            ChkPayee.IsChecked = factureAModifier.EstPayee;
            TxtNotes.Text = factureAModifier.Notes;
        }

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
                BorderEcheance.BorderThickness = new Thickness(2);
            }
        }

        private void MettreAJourStatistiques()
        {
            var facturesNonPayees = toutesLesFactures.Where(f => !f.EstPayee).ToList();
            var facturesRelance = facturesNonPayees.Where(f =>
                f.DateEcheance.HasValue &&
                f.DateEcheance.Value.Date < DateTime.Now.Date
            ).ToList();

            TxtNbNonPayees.Text = facturesNonPayees.Count.ToString();
            TxtNbRelances.Text = facturesRelance.Count.ToString();
            TxtTotalMontant.Text = facturesNonPayees.Sum(f => f.Montant).ToString("F2");
        }

        private void AfficherAutresFactures()
        {
            if (ListeAutresFactures == null || MessageVide == null)
                return;

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

            if (facturesFiltrees.Count == 0)
            {
                ListeAutresFactures.Visibility = Visibility.Collapsed;
                MessageVide.Visibility = Visibility.Visible;
            }
            else
            {
                ListeAutresFactures.ItemsSource = facturesFiltrees;
                ListeAutresFactures.Visibility = Visibility.Visible;
                MessageVide.Visibility = Visibility.Collapsed;
            }
        }

        private int ObtenirNiveauUrgence(Facture facture)
        {
            if (!facture.DateEcheance.HasValue)
                return 4;

            var joursRestants = (facture.DateEcheance.Value.Date - DateTime.Now.Date).Days;

            if (joursRestants < 0)
                return 0;
            else if (joursRestants <= 7)
                return 1;
            else if (joursRestants <= 15)
                return 2;
            else
                return 3;
        }

        private string ObtenirCouleurUrgence(Facture facture)
        {
            int urgence = ObtenirNiveauUrgence(facture);

            return urgence switch
            {
                0 => Couleurs.RougeUrgent,
                1 => Couleurs.OrangeMoyen,
                2 => Couleurs.Jaune,
                3 => Couleurs.VertMoyen,
                _ => Couleurs.Gris250
            };
        }

        private (string texte, string couleurFond, string couleurTexte) ObtenirBadgeUrgence(Facture facture)
        {
            int urgence = ObtenirNiveauUrgence(facture);

            return urgence switch
            {
                0 => ("🔴 URGENT", Couleurs.FondRougeClair, Couleurs.RougeUrgent),
                1 => ("🟠 7 jours", Couleurs.FondOrangeClair, Couleurs.OrangeSombre),
                2 => ("🟡 15 jours", Couleurs.FondJauneClair, Couleurs.JauneSombre),
                3 => ("🟢 OK", Couleurs.FondVertClair, Couleurs.VertSombre),
                _ => ("", "", "")
            };
        }

        private void CarteFacture_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Border border && border.Tag is Facture facture)
            {
                string couleur = ObtenirCouleurUrgence(facture);
                border.BorderBrush = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString(couleur)
                );
            }
        }

        private void TxtBadgeUrgence_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is TextBlock txtBadge && txtBadge.Tag is Facture facture)
            {
                var (texte, couleurFond, couleurTexte) = ObtenirBadgeUrgence(facture);

                if (!string.IsNullOrEmpty(texte))
                {
                    var parent = txtBadge.Parent as Panel;
                    if (parent != null)
                    {
                        var border = new Border
                        {
                            Background = new SolidColorBrush(
                                (Color)ColorConverter.ConvertFromString(couleurFond)
                            ),
                            CornerRadius = new CornerRadius(10),
                            Padding = new Thickness(8, 3, 8, 3),
                            Margin = new Thickness(0, 0, 8, 0),
                            Child = new TextBlock
                            {
                                Text = texte,
                                FontSize = 11,
                                FontWeight = FontWeights.Bold,
                                Foreground = new SolidColorBrush(
                                    (Color)ColorConverter.ConvertFromString(couleurTexte)
                                )
                            }
                        };

                        int index = parent.Children.IndexOf(txtBadge);
                        parent.Children.RemoveAt(index);
                        parent.Children.Insert(index, border);
                    }
                }
            }
        }

        private void RbFiltreFactures_Checked(object sender, RoutedEventArgs e)
        {
            AfficherAutresFactures();
        }

        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (!ValiderFormulaire())
                return;

            try
            {
                var factureExistante = toutesLesFactures.FirstOrDefault(f => f.Id == factureAModifier.Id);

                if (factureExistante != null)
                {
                    factureExistante.Type = ExtraireType();
                    factureExistante.Montant = double.Parse(TxtMontant.Text);
                    factureExistante.DateFacture = DateFacture.SelectedDate ?? DateTime.Now;
                    factureExistante.DateEcheance = DateEcheance.SelectedDate;
                    factureExistante.EstPayee = ChkPayee.IsChecked ?? false;
                    factureExistante.Notes = TxtNotes.Text.Trim();

                    GestionnaireDonnees.Sauvegarder(toutesLesFactures, "factures.json");

                    MessageBox.Show(
                        $"✅ Facture modifiée !\n\nType : {factureExistante.Type}\nMontant : {factureExistante.Montant:F2} €",
                        "Succès",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );

                    NavigationService?.GoBack();
                }
                else
                {
                    MessageBox.Show("❌ Facture introuvable.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erreur : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            var resultat = MessageBox.Show(
                "⚠️ Annuler les modifications ?",
                "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (resultat == MessageBoxResult.Yes)
            {
                NavigationService?.GoBack();
            }
        }

        private bool ValiderFormulaire()
        {
            if (CmbType.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Sélectionnez un type.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                CmbType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtMontant.Text))
            {
                MessageBox.Show("⚠️ Saisissez un montant.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtMontant.Focus();
                return false;
            }

            if (!double.TryParse(TxtMontant.Text, out double montant) || montant <= 0)
            {
                MessageBox.Show("⚠️ Montant invalide.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtMontant.Focus();
                TxtMontant.SelectAll();
                return false;
            }

            if (DateFacture.SelectedDate == null)
            {
                MessageBox.Show("⚠️ Sélectionnez une date.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                DateFacture.Focus();
                return false;
            }

            return true;
        }

        private string ExtraireType()
        {
            if (CmbType.SelectedItem is ComboBoxItem selectedItem)
            {
                if (selectedItem.Content is StackPanel stackPanel)
                {
                    if (stackPanel.Children.Count >= 2 && stackPanel.Children[1] is TextBlock textBlock)
                    {
                        return textBlock.Text;
                    }
                }
            }
            return "Autre";
        }
    }
}
