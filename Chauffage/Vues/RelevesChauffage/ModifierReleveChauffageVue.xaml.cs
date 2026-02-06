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

using GestionnaireDeLogement.Modeles;
using System.Windows;

namespace GestionnaireDeLogement.Chauffage.Vues.RelevesChauffage
{
    /// ╔═══════════════════════════════════════════════════════════════╗
    /// ║  ✏️ FENÊTRE – MODIFICATION DE RELEVÉ DE CHAUFFAGE              ║
    /// ╚═══════════════════════════════════════════════════════════════╝
    public partial class ModifierReleveChauffageVue : Window
    {
        public ReleveChauffage ReleveModifie { get; }

        public ModifierReleveChauffageVue(ReleveChauffage releve)
        {
            InitializeComponent();
            ReleveModifie = releve;
            DataContext = ReleveModifie;
        }

        // ============================
        // ✅ VALIDER
        // ============================
        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        // ============================
        // ❌ ANNULER
        // ============================
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
