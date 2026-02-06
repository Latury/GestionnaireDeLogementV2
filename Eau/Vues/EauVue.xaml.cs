/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Eau
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement.Vues
{
    /// <summary>
    /// Logique d'interaction pour EauVue.xaml
    /// </summary>
    public partial class EauVue : Page
    {
        // ═══════════════════════════════════════════════════════════
        // CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════

        public EauVue()
        {
            InitializeComponent();
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DES CLICS SUR LES BOUTONS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// ➕ Ajouter un nouveau relevé d'eau
        /// </summary>
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Ouvrir une fenêtre pour ajouter un relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Ajouter un relevé d'eau",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// ✏️ Modifier le relevé sélectionné
        /// </summary>
        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'un relevé est sélectionné
            // TODO : Ouvrir une fenêtre pour modifier le relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Modifier un relevé d'eau",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        /// <summary>
        /// 🗑️ Supprimer le relevé sélectionné
        /// </summary>
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // TODO : Vérifier qu'un relevé est sélectionné
            // TODO : Demander confirmation
            // TODO : Supprimer le relevé
            MessageBox.Show(
                "Fonctionnalité à venir : Supprimer un relevé d'eau",
                "Information",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DE LA SÉLECTION
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// 🔄 Gère le changement de sélection dans la liste
        /// Active/Désactive les boutons Modifier et Supprimer
        /// </summary>
        private void ListViewReleves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool itemSelectionne = ListViewReleves.SelectedItem != null;
            BtnModifier.IsEnabled = itemSelectionne;
            BtnSupprimer.IsEnabled = itemSelectionne;
        }
    }
}
