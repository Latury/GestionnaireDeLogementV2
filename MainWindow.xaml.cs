using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement
{
    /*
     * ╔═══════════════════════════════════════════════════════════════════╗
     * ║  🪟 FENÊTRE PRINCIPALE - GESTIONNAIRE DE LOGEMENT                 ║
     * ╠═══════════════════════════════════════════════════════════════════╣
     * ║  📌 Fonction : Fenêtre principale avec menu de navigation         ║
     * ║  📌 Structure :                                                   ║
     * ║     • Menu latéral gauche (250px)                                 ║
     * ║     • Zone de contenu principal (Frame)                           ║
     * ║     • Gestion du bouton actif (style bleu)                        ║
     * ╠═══════════════════════════════════════════════════════════════════╣
     * ║  👤 Développeur : Latury (latury57@gmail.com)                    ║
     * ║  📅 Dernière mise à jour : 21/01/2026                             ║
     * ╚═══════════════════════════════════════════════════════════════════╝
     */

    public partial class MainWindow : Window
    {
        // ═══════════════════════════════════════════════════════════════
        // 🏗️ CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════════
        public MainWindow()
        {
            InitializeComponent();
            AfficherMessageTemporaire();
        }

        // ═══════════════════════════════════════════════════════════════
        // 🎨 GESTION DU STYLE DES BOUTONS
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Réinitialise le style de tous les boutons de navigation
        /// </summary>
        private void ResetStylesBoutons()
        {
            BtnAccueil.Style = (Style)FindResource("BoutonNavigation");
            BtnFactures.Style = (Style)FindResource("BoutonNavigation");
            BtnEau.Style = (Style)FindResource("BoutonNavigation");
            BtnElectricite.Style = (Style)FindResource("BoutonNavigation");
            BtnChauffage.Style = (Style)FindResource("BoutonNavigation");
            BtnAchats.Style = (Style)FindResource("BoutonNavigation");
            BtnStatistiques.Style = (Style)FindResource("BoutonNavigation");
            BtnParametres.Style = (Style)FindResource("BoutonNavigation");
        }

        /// <summary>
        /// Définit un bouton comme actif (style bleu)
        /// </summary>
        private void DefinirBoutonActif(Button bouton)
        {
            ResetStylesBoutons();
            bouton.Style = (Style)FindResource("BoutonNavigationActif");
        }

        // ═══════════════════════════════════════════════════════════════
        // 🖱️ ÉVÉNEMENTS DES BOUTONS
        // ═══════════════════════════════════════════════════════════════

        private void BtnAccueil_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnAccueil);
            TitrePage.Text = "Tableau de bord";
            AfficherMessageTemporaire();
        }

        private void BtnFactures_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnFactures);
            TitrePage.Text = "Gestion des factures";
            AfficherMessageTemporaire();
        }

        private void BtnEau_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnEau);
            TitrePage.Text = "Consommation d'eau";
            AfficherMessageTemporaire();
        }

        private void BtnElectricite_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnElectricite);
            TitrePage.Text = "Consommation d'électricité";
            AfficherMessageTemporaire();
        }

        private void BtnChauffage_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnChauffage);
            TitrePage.Text = "Consommation de chauffage";
            AfficherMessageTemporaire();
        }

        private void BtnAchats_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnAchats);
            TitrePage.Text = "Achats échelonnés";
            AfficherMessageTemporaire();
        }

        private void BtnStatistiques_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnStatistiques);
            TitrePage.Text = "Statistiques et graphiques";
            AfficherMessageTemporaire();
        }

        private void BtnParametres_Click(object sender, RoutedEventArgs e)
        {
            DefinirBoutonActif(BtnParametres);
            TitrePage.Text = "Paramètres";
            AfficherMessageTemporaire();
        }

        // ═══════════════════════════════════════════════════════════════
        // 📝 AFFICHAGE TEMPORAIRE
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Affiche un message temporaire dans le Frame
        /// À supprimer quand les vraies pages seront créées
        /// </summary>
        private void AfficherMessageTemporaire()
        {
            Page pageTemp = new Page
            {
                Background = System.Windows.Media.Brushes.White,
                Content = new TextBlock
                {
                    Text = "🚧 Page en construction\n\nCette page sera bientôt disponible !",
                    FontSize = 24,
                    FontWeight = FontWeights.Bold,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    TextAlignment = TextAlignment.Center,
                    Foreground = new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(107, 114, 128))
                }
            };

            FramePrincipal.Navigate(pageTemp);
        }

        private void FramePrincipal_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
