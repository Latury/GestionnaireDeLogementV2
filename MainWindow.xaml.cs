using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AfficherMessageTemporaire();
        }

        private void BtnAccueil_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Tableau de bord";
            AfficherMessageTemporaire();
        }

        private void BtnFactures_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Gestion des factures";
            AfficherMessageTemporaire();
        }

        private void BtnEau_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Consommation d'eau";
            AfficherMessageTemporaire();
        }

        private void BtnElectricite_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Consommation d'électricité";
            AfficherMessageTemporaire();
        }

        private void BtnChauffage_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Consommation de chauffage";
            AfficherMessageTemporaire();
        }

        private void BtnAchats_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Achats échelonnés";
            AfficherMessageTemporaire();
        }

        private void BtnStatistiques_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Statistiques et graphiques";
            AfficherMessageTemporaire();
        }

        private void BtnParametres_Click(object sender, RoutedEventArgs e)
        {
            TitrePage.Text = "Paramètres";
            AfficherMessageTemporaire();
        }

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
                    Foreground = System.Windows.Media.Brushes.Gray
                }
            };

            FramePrincipal.Navigate(pageTemp);
        }
    }
}
