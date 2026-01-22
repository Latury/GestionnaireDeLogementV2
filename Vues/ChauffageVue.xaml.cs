using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement.Vues
{
    /// <summary>
    /// Logique d'interaction pour ChauffageVue.xaml
    /// </summary>
    public partial class ChauffageVue : Page
    {
        public ChauffageVue()
        {
            InitializeComponent();
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DES CLICS SUR LES BOUTONS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Ajouter un nouveau relevé de chauffage
        /// </summary>
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Ouvrir une fenêtre pour ajouter un relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Ajouter un relevé de chauffage",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// Modifier le relevé sélectionné
        /// </summary>
        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'un relevé est sélectionné
            // TODO : Ouvrir une fenêtre pour modifier le relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Modifier un relevé de chauffage",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// Supprimer le relevé sélectionné
        /// </summary>
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'un relevé est sélectionné
            // TODO : Demander confirmation
            // TODO : Supprimer le relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Supprimer un relevé de chauffage",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}
