/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Fenêtre principale
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using System.Windows;
using System.Windows.Controls;

using GestionnaireDeLogement.Vues;
using GestionnaireDeLogement.Chauffage.Vues;
using GestionnaireDeLogement.Configurations.Vues;

namespace GestionnaireDeLogement
{
    /// <summary>
    /// Fenêtre principale de l'application
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Charger la page d'accueil au démarrage
            FramePrincipal.Navigate(new AccueilVue());
            BtnAccueil.Style = (Style)FindResource("BoutonNavigationActif");
        }

        // ═══════════════════════════════════════════════════════════
        // NAVIGATION PRINCIPALE
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Change la page affichée, met à jour le titre
        /// et applique le style actif au bouton correspondant
        /// </summary>
        private void ChangerPage(Page nouvellePage, string titre, Button boutonActif)
        {
            FramePrincipal.Navigate(nouvellePage);
            TexteTitre.Text = titre;

            ResetBoutonsNavigation();
            boutonActif.Style = (Style)FindResource("BoutonNavigationActif");
        }

        // ═══════════════════════════════════════════════════════════
        // HANDLERS DES BOUTONS DE NAVIGATION
        // ═══════════════════════════════════════════════════════════

        private void BtnAccueil_Click(object sender, RoutedEventArgs e)
        {
            ChangerPage(new AccueilVue(), "Tableau de bord", BtnAccueil);
        }

        private void BtnFactures_Click(object sender, RoutedEventArgs e)
        {
            ChangerPage(new FacturesVue(), "Factures", BtnFactures);
        }

        private void BtnEau_Click(object sender, RoutedEventArgs e)
        {
            ChangerPage(new EauVue(), "Consommation d'eau", BtnEau);
        }

        private void BtnElectricite_Click(object sender, RoutedEventArgs e)
        {
            ChangerPage(new ElectriciteVue(), "Consommation d'électricité", BtnElectricite);
        }

        private void BtnChauffage_Click(object sender, RoutedEventArgs e)
        {
            ChangerPage(new ChauffageVue(), "Chauffage", BtnChauffage);
        }

        private void BtnAchats_Click(object sender, RoutedEventArgs e)
        {
            // Page à venir
            TexteTitre.Text = "Achats";
            ResetBoutonsNavigation();
            BtnAchats.Style = (Style)FindResource("BoutonNavigationActif");
        }

        private void BtnStatistiques_Click(object sender, RoutedEventArgs e)
        {
            // Page à venir
            TexteTitre.Text = "Statistiques";
            ResetBoutonsNavigation();
            BtnStatistiques.Style = (Style)FindResource("BoutonNavigationActif");
        }

        private void BtnParametres_Click(object sender, RoutedEventArgs e)
        {
            var fenetreParametres = new ConfigurationVue
            {
                Owner = this
            };

            fenetreParametres.ShowDialog();
        }

        // ═══════════════════════════════════════════════════════════
        // OUTILS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Réinitialise tous les boutons de navigation
        /// avec le style par défaut
        /// </summary>
        private void ResetBoutonsNavigation()
        {
            var styleBouton = (Style)FindResource("BoutonNavigation");

            BtnAccueil.Style = styleBouton;
            BtnFactures.Style = styleBouton;
            BtnEau.Style = styleBouton;
            BtnElectricite.Style = styleBouton;
            BtnChauffage.Style = styleBouton;
            BtnAchats.Style = styleBouton;
            BtnStatistiques.Style = styleBouton;
            BtnParametres.Style = styleBouton;
        }
    }
}
