using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement.Vues
{
    /// <summary>
    /// Logique d'interaction pour FacturesVue.xaml
    /// </summary>
    public partial class FacturesVue : Page
    {
        public FacturesVue()
        {
            InitializeComponent();
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DES CLICS SUR LES BOUTONS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Ajouter une nouvelle facture
        /// </summary>
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Ouvrir une fenêtre pour ajouter une facture
            MessageBox.Show(
                "Fonctionnalité à venir : Ajouter une facture",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// Modifier la facture sélectionnée
        /// </summary>
        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'une facture est sélectionnée
            // TODO : Ouvrir une fenêtre pour modifier la facture
            MessageBox.Show(
                "Fonctionnalité à venir : Modifier une facture",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// Supprimer la facture sélectionnée
        /// </summary>
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'une facture est sélectionnée
            // TODO : Demander confirmation
            // TODO : Supprimer la facture
            MessageBox.Show(
                "Fonctionnalité à venir : Supprimer une facture",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}
