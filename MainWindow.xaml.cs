using System.Windows;
using System.Windows.Controls;
using GestionnaireDeLogement.Vues;

namespace GestionnaireDeLogement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Charger la page d'accueil au démarrage
            FramePrincipal.Navigate(new AccueilVue());
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DES CLICS SUR LES BOUTONS DE NAVIGATION
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
            // TODO : Créer la page AchatsVue
            TitrePage.Text = "Achats";
            ResetBoutonsNavigation();
        }

        private void BtnStatistiques_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Créer la page StatistiquesVue
            TitrePage.Text = "Statistiques";
            ResetBoutonsNavigation();
        }

        private void BtnParametres_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Créer la page ParametresVue
            TitrePage.Text = "Paramètres";
            ResetBoutonsNavigation();
        }

        // ═══════════════════════════════════════════════════════════
        // MÉTHODES UTILITAIRES
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Change la page affichée et met à jour le titre et le bouton actif
        /// </summary>
        private void ChangerPage(Page nouvellePage, string titre, Button boutonActif)
        {
            FramePrincipal.Navigate(nouvellePage);
            TitrePage.Text = titre;
            ResetBoutonsNavigation();
            boutonActif.Style = (Style)FindResource("BoutonNavigationActif");
        }

        /// <summary>
        /// Réinitialise tous les boutons de navigation au style par défaut
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
