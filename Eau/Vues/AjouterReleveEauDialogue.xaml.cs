using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using GestionnaireDeLogement.Donnees;
using GestionnaireDeLogement.Modeles;

namespace GestionnaireDeLogement.Vues
{
    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════
    ///  DIALOGUE D'AJOUT D'UN RELEVÉ D'EAU
    /// ═══════════════════════════════════════════════════════════════════
    /// Permet à l'utilisateur de saisir un nouveau relevé de compteur d'eau
    /// ═══════════════════════════════════════════════════════════════════
    /// </summary>
    public partial class AjouterReleveEauDialogue : Window
    {
        // ═══════════════════════════════════════════════════════════════
        //  CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════════
        public AjouterReleveEauDialogue()
        {
            InitializeComponent();
            DatePicker.SelectedDate = DateTime.Now;
            TxtEauFroide.Focus();
            TxtEauFroide.SelectAll();
        }

        // ═══════════════════════════════════════════════════════════════
        //  BOUTON VALIDER
        // ═══════════════════════════════════════════════════════════════
        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            // ─────────────────────────────────────────────────────────
            // VALIDATION DES CHAMPS (IDENTIQUE)
            // ─────────────────────────────────────────────────────────
            if (!DatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une date de relevé.", "Champ manquant", MessageBoxButton.OK, MessageBoxImage.Warning);
                DatePicker.Focus(); return;
            }

            if (!double.TryParse(TxtEauFroide.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double eauFroide) || eauFroide < 0)
            {
                MessageBox.Show("L'index d'eau froide doit être un nombre valide ≥ 0.", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauFroide.Focus(); TxtEauFroide.SelectAll(); return;
            }

            if (!double.TryParse(TxtEauChaude.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double eauChaude) || eauChaude < 0)
            {
                MessageBox.Show("L'index d'eau chaude doit être un nombre valide ≥ 0.", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauChaude.Focus(); TxtEauChaude.SelectAll(); return;
            }

            // ─────────────────────────────────────────────────────────
            //  CRÉATION + SAUVEGARDE AUTOMATIQUE
            // ─────────────────────────────────────────────────────────
            var nouveauReleve = new ReleveEau
            {
                Id = ObtenirProchainId(),
                DateReleve = DatePicker.SelectedDate.Value,
                IndexEauFroide = eauFroide,
                IndexEauChaude = eauChaude,
                Consommation = 0,  // À calculer plus tard
                MontantEstime = 0, // À calculer plus tard
                Notes = TxtNotes.Text.Trim()
            };

            //  SAUVEGARDER dans releves-eau.json
            var relevesExistants = GestionnaireDonnees.Charger<ReleveEau>("releves-eau.json");
            relevesExistants.Add(nouveauReleve);
            GestionnaireDonnees.Sauvegarder(relevesExistants, "releves-eau.json");

            MessageBox.Show($"Relevé ajouté !\n\n{nouveauReleve}", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

            // Fermer avec succès
            DialogResult = true;
            Close();
        }

        // ═══════════════════════════════════════════════════════════════
        //  UTILITAIRE : PROCHAIN ID
        // ═══════════════════════════════════════════════════════════════
        private int ObtenirProchainId()
        {
            var releves = GestionnaireDonnees.Charger<ReleveEau>("releves-eau.json");
            return releves.Any() ? releves.Max(r => r.Id) + 1 : 1;
        }

        // ═══════════════════════════════════════════════════════════════
        //  BOUTON ANNULER (IDENTIQUE)
        // ═══════════════════════════════════════════════════════════════
        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
