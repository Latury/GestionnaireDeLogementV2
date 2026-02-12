/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Chauffage
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using GestionnaireDeLogement.Chauffage.VueModeles;
using GestionnaireDeLogement.Chauffage.Vues.RelevesChauffage;
using GestionnaireDeLogement.Modeles;
using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement.Chauffage.Vues
{
    /*
     * ╔═══════════════════════════════════════════════════════════════╗
     * ║  VUE : CHAUFFAGE                                              ║
     * ╠═══════════════════════════════════════════════════════════════╣
     * ║ Rôle :                                                        ║
     * ║ - Gérer les interactions utilisateur                          ║
     * ║ - Déléguer toute la logique au ViewModel                      ║
     * ║ - AUCUN calcul métier ici                                     ║
     * ╚═══════════════════════════════════════════════════════════════╝
     */

    public partial class ChauffageVue : Page
    {
        // =============================================================
        //  ACCÈS PROPRE AU VIEWMODEL
        // =============================================================
        private ChauffageVueModele VueModele
            => DataContext as ChauffageVueModele;

        // =============================================================
        //  CONSTRUCTEUR
        // =============================================================
        public ChauffageVue()
        {
            InitializeComponent();

            VueModele.PropertyChanged += (_, __) =>
            {
                MessageVide.Visibility =
                    VueModele.RelevesFiltres.Count == 0
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            };

            // Liaison explicite et sûre
            DataContext = new ChauffageVueModele();
        }


        // =============================================================
        //  AJOUTER UN RELEVÉ
        // =============================================================
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            var fenetre = new AjouterReleveChauffageVue
            {
                Owner = Window.GetWindow(this)
            };

            if (fenetre.ShowDialog() == true)
            {
                VueModele.Releves.Add(fenetre.NouveauReleve);
            }
        }

        // =============================================================
        //  MODIFIER UN RELEVÉ
        // =============================================================
        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            if (VueModele.ReleveSelectionne == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un relevé.",
                    "Information",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }

            var fenetre = new ModifierReleveChauffageVue(
                VueModele.ReleveSelectionne)
            {
                Owner = Window.GetWindow(this)
            };

            fenetre.ShowDialog();
        }

        // =============================================================
        //  SUPPRIMER UN RELEVÉ
        // =============================================================
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (VueModele.ReleveSelectionne == null)
                return;

            var confirmation = MessageBox.Show(
                "Supprimer ce relevé ?",
                "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (confirmation == MessageBoxResult.Yes)
            {
                VueModele.Releves.Remove(VueModele.ReleveSelectionne);
                VueModele.ReleveSelectionne = null;
            }
        }
    }
}
