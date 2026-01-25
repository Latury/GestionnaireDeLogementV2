using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GestionnaireDeLogement.Modeles;
using GestionnaireDeLogement.Donnees;
using GestionnaireDeLogement.Utilitaires;

namespace GestionnaireDeLogement.Vues
{
    public partial class FacturesVue : Page
    {
        private List<Facture> toutesLesFactures;

        public FacturesVue()
        {
            InitializeComponent();
            ChargerFactures();
            this.Loaded += (s, e) => ChargerFactures();
            this.SizeChanged += FacturesVue_SizeChanged;  // ✅ AJOUTEZ CETTE LIGNE
        }

        // ✅ AJOUTEZ CETTE MÉTHODE
        private void FacturesVue_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ListViewFactures.View is GridView gridView && ListViewFactures.ActualWidth > 0)
            {
                double totalWidth = ListViewFactures.ActualWidth - 30;

                gridView.Columns[0].Width = totalWidth * 0.10;  // Type: 10%
                gridView.Columns[1].Width = totalWidth * 0.15;  // Date facture: 15%
                gridView.Columns[2].Width = totalWidth * 0.15;  // Montant: 15%
                gridView.Columns[3].Width = totalWidth * 0.15;  // Échéance: 15%
                gridView.Columns[4].Width = totalWidth * 0.15;  // Statut: 15%
                gridView.Columns[5].Width = totalWidth * 0.30;  // Notes: 30%
            }
        }

        private void ChargerFactures()
        {
            try
            {
                toutesLesFactures = GestionnaireDonnees.Charger<Facture>("factures.json");
                AfficherFactures(toutesLesFactures);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erreur : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AfficherFactures(List<Facture> factures)
        {
            if (factures.Count == 0)
            {
                ListViewFactures.Visibility = Visibility.Collapsed;
                MessageVide.Visibility = Visibility.Visible;
            }
            else
            {
                ListViewFactures.ItemsSource = factures;
                ListViewFactures.Visibility = Visibility.Visible;
                MessageVide.Visibility = Visibility.Collapsed;
            }
        }

        private void TxtStatut_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is TextBlock txtStatut && txtStatut.Tag is Facture facture)
            {
                var (texte, couleurFond, couleurTexte) = ObtenirStatut(facture);
                txtStatut.Text = texte;
                txtStatut.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(couleurTexte));

                if (txtStatut.Parent is Border border)
                {
                    border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(couleurFond));
                }
            }
        }

        private (string texte, string couleurFond, string couleurTexte) ObtenirStatut(Facture facture)
        {
            if (facture.EstPayee)
                return ("✅ Payée", Couleurs.FondSuccesClaire, Couleurs.VertSombre);
            else if (NecessiteRelance(facture))
                return ("📧 Relance", Couleurs.FondRougeClair, Couleurs.RougeUrgentMoyen);
            else
                return ("⏳ En attente", Couleurs.FondOrangeClair, Couleurs.OrangeSombre);
        }

        private bool NecessiteRelance(Facture facture)
        {
            return !facture.EstPayee && facture.DateEcheance.HasValue && facture.DateEcheance.Value.Date < DateTime.Now.Date;
        }

        private void CmbStatut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (toutesLesFactures == null) return;

            List<Facture> facturesFiltrees = CmbStatut.SelectedIndex switch
            {
                1 => toutesLesFactures.Where(f => f.EstPayee).ToList(),
                2 => toutesLesFactures.Where(f => !f.EstPayee).ToList(),
                3 => toutesLesFactures.Where(f => !f.EstPayee && !NecessiteRelance(f)).ToList(),
                4 => toutesLesFactures.Where(f => NecessiteRelance(f)).ToList(),
                _ => toutesLesFactures
            };

            AfficherFactures(facturesFiltrees);
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AjouterFactureVue());
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewFactures.SelectedItem is Facture factureSelectionnee)
            {
                NavigationService?.Navigate(new ModifierFactureVue(factureSelectionnee));
            }
            else
            {
                MessageBox.Show("⚠️ Veuillez sélectionner une facture.", "Aucune sélection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewFactures.SelectedItem is Facture factureSelectionnee)
            {
                var resultat = MessageBox.Show(
                    $"⚠️ Supprimer : {factureSelectionnee.Type} - {factureSelectionnee.Montant:F2} € ?",
                    "Confirmation",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                );

                if (resultat == MessageBoxResult.Yes)
                {
                    toutesLesFactures.Remove(factureSelectionnee);
                    GestionnaireDonnees.Sauvegarder(toutesLesFactures, "factures.json");
                    AfficherFactures(toutesLesFactures);
                    MessageBox.Show("✅ Supprimée !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("⚠️ Veuillez sélectionner une facture.", "Aucune sélection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ListViewFactures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
