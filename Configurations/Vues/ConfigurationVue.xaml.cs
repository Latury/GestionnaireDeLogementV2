/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Configurations
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GestionnaireDeLogement.Utilitaires;

namespace GestionnaireDeLogement.Configurations.Vues
{
    public partial class ConfigurationVue : Window
    {
        public ConfigurationVue()
        {
            InitializeComponent();

            // Catégorie par défaut
            ActiverCategorie(
                "Général",
                Couleurs.Gris500,
                BtnGeneral
            );
        }

        // ═════════════════════════════════════
        // GESTION DES CLICS
        // ═════════════════════════════════════

        private void BtnGeneral_Click(object sender, RoutedEventArgs e)
        {
            ActiverCategorie(
                "Général",
                Couleurs.Gris500,
                BtnGeneral
            );
        }

        private void BtnEau_Click(object sender, RoutedEventArgs e)
        {
            ActiverCategorie(
                "Eau",
                Couleurs.CouleurEau,
                BtnEau
            );
        }

        private void BtnElectricite_Click(object sender, RoutedEventArgs e)
        {
            ActiverCategorie(
                "Électricité",
                Couleurs.CouleurElectricite,
                BtnElectricite
            );
        }

        private void BtnChauffage_Click(object sender, RoutedEventArgs e)
        {
            ActiverCategorie(
                "Chauffage",
                Couleurs.CouleurChauffage,
                BtnChauffage
            );
        }

        private void BtnAide_Click(object sender, RoutedEventArgs e)
        {
            TitreCategorie.Text = "À propos / Aide";
            TitreCategorie.Foreground = (Brush)FindResource("CouleurParametreAide");

            // Plus tard :
            // Charger le contenu Aide / À propos ici
        }

        // ═════════════════════════════════════
        // MÉTHODE CENTRALE
        // ═════════════════════════════════════

        private void ActiverCategorie(string titre, string couleurHex, Button boutonActif)
        {
            // 1. Titre à droite
            TitreCategorie.Text = titre;
            TitreCategorie.Foreground = Couleurs.VersBrush(couleurHex);

            // 2. Reset de tous les boutons
            ResetBoutons();

            // 3. Activation du bouton sélectionné
            boutonActif.Style = (Style)FindResource("BoutonNavigationParametreActif");
        }

        private void ResetBoutons()
        {
            var styleNormal = (Style)FindResource("BoutonNavigationParametre");

            BtnGeneral.Style = styleNormal;
            BtnEau.Style = styleNormal;
            BtnElectricite.Style = styleNormal;
            BtnChauffage.Style = styleNormal;
        }
    }
}
