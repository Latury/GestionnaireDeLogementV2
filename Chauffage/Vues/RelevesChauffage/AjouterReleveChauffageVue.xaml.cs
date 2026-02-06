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
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GestionnaireDeLogement.Chauffage.Vues.RelevesChauffage
{
    /*
     * ╔══════════════════════════════════════════════════════════════╗
     * ║  FENÊTRE : AJOUTER UN RELEVÉ DE CHAUFFAGE                    ║
     * ╠══════════════════════════════════════════════════════════════╣
     * ║ Rôle :                                                      ║
     * ║ - Saisie d’un relevé                                        ║
     * ║ - Validation visuelle immédiate (UX)                        ║
     * ║ - Adaptation des champs selon le type                       ║
     * ║ - Retourne un ReleveChauffage valide                        ║
     * ╚══════════════════════════════════════════════════════════════╝
     */

    public partial class AjouterReleveChauffageVue : Window
    {
        // =============================================================
        // 🔹 RELEVÉ CRÉÉ
        // =============================================================
        public ReleveChauffage NouveauReleve { get; private set; }

        // =============================================================
        // 🔹 COULEURS DE VALIDATION
        // =============================================================
        private readonly Brush _bordureErreur = Brushes.Red;

        // =============================================================
        // 🔹 CONSTRUCTEUR
        // =============================================================
        public AjouterReleveChauffageVue()
        {
            InitializeComponent();

            // Valeurs par défaut
            DpDate.SelectedDate = DateTime.Today;
            CmbType.SelectedIndex = 0;

            // Événements pour validation temps réel
            TxtQuantite.TextChanged += MettreAJourResume;
            TxtMontant.TextChanged += MettreAJourResume;
            TxtUnite.TextChanged += MettreAJourResume;
            CmbType.SelectionChanged += MettreAJourResume;
            DpDate.SelectedDateChanged += MettreAJourResume;

            MettreAJourChampsSelonType();
        }

        // =============================================================
        // 🧾 TEXTE DU RÉSUMÉ (binding simple)
        // =============================================================
        private string _resumeTexte;
        public string ResumeTexte
        {
            get => _resumeTexte;
            set
            {
                _resumeTexte = value;
                TxtResume.Text = value;
            }
        }

        // =============================================================
        // 🧾 RÉSUMÉ TEMPS RÉEL (DISCRET)
        // =============================================================
        private void MettreAJourResume(object sender, EventArgs e)
        {
            // Sécurité : si les contrôles ne sont pas encore prêts
            if (TxtQuantite == null || TxtMontant == null || CmbType == null)
                return;

            // Type de chauffage
            string type = "—";
            ComboBoxItem item = CmbType.SelectedItem as ComboBoxItem;
            if (item != null && item.IsEnabled)
                type = item.Content.ToString();

            // Quantité
            string quantite = string.IsNullOrWhiteSpace(TxtQuantite.Text)
                ? "?"
                : TxtQuantite.Text;

            // Unité
            string unite = string.IsNullOrWhiteSpace(TxtUnite.Text)
                ? ""
                : TxtUnite.Text;

            // Montant
            string montant = string.IsNullOrWhiteSpace(TxtMontant.Text)
                ? "?"
                : TxtMontant.Text + " €";

            // Date
            string date = DpDate.SelectedDate.HasValue
                ? DpDate.SelectedDate.Value.ToString("dd/MM/yyyy")
                : "—";

            // 👉 ICI on prépare juste le texte
            ResumeTexte = $"📅 {date}  |  🔥 {type}  |  📦 {quantite} {unite}  |  💰 {montant}";
        }

        // =============================================================
        // ❌ ANNULER
        // =============================================================
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        // =============================================================
        // ✔ VALIDER
        // =============================================================
        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            bool formulaireValide = true;

            // 🔹 Initialisation OBLIGATOIRE (corrige CS0165)
            double quantite = 0;
            double montant = 0;

            ResetValidation();

            // =====================================================
            // 🔍 VALIDATION QUANTITÉ
            // =====================================================
            if (string.IsNullOrWhiteSpace(TxtQuantite.Text) ||
                !double.TryParse(TxtQuantite.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out quantite))
            {
                MarquerErreur(TxtQuantite);
                formulaireValide = false;
            }

            // =====================================================
            // 🔍 VALIDATION MONTANT
            // =====================================================
            if (string.IsNullOrWhiteSpace(TxtMontant.Text) ||
                !double.TryParse(TxtMontant.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out montant))
            {
                MarquerErreur(TxtMontant);
                formulaireValide = false;
            }

            // =====================================================
            // 🔍 VALIDATION TYPE
            // =====================================================
            ComboBoxItem typeItem = CmbType.SelectedItem as ComboBoxItem;
            if (typeItem == null || typeItem.IsEnabled == false)
            {
                MarquerErreur(CmbType);
                formulaireValide = false;
            }

            if (!formulaireValide)
            {
                MessageBox.Show(
                    "Veuillez corriger les champs en rouge.",
                    "Erreur de validation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            // =====================================================
            // ✅ CRÉATION DU RELEVÉ
            // =====================================================
            NouveauReleve = new ReleveChauffage
            {
                DateReleve = DpDate.SelectedDate ?? DateTime.Today,
                TypeChauffage = typeItem.Content.ToString(),
                Quantite = quantite,
                Unite = TxtUnite.Text,
                MontantEstime = montant,
                Notes = TxtNotes.Text
            };

            DialogResult = true;
            Close();
        }


        // =============================================================
        // 🔁 VALIDATION TEMPS RÉEL (MODIFICATION B)
        // =============================================================
        private void ChampTexte_Modifie(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox champ)
            {
                if (string.IsNullOrWhiteSpace(champ.Text))
                {
                    MarquerErreur(champ);
                }
                else
                {
                    EffacerErreur(champ);
                }
            }
        }

        // =============================================================
        // 🔁 CHANGEMENT DU TYPE
        // =============================================================
        private void CmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MettreAJourChampsSelonType();
            EffacerErreur(CmbType);
        }

        // =============================================================
        // 🔧 ADAPTATION SELON TYPE
        // =============================================================
        private void MettreAJourChampsSelonType()
        {
            ComboBoxItem item = CmbType.SelectedItem as ComboBoxItem;
            if (item == null)
                return;

            string type = item.Content.ToString();

            if (type.Contains("Gaz"))
                TxtUnite.Text = "m³";
            else if (type.Contains("Fioul"))
                TxtUnite.Text = "litres";
            else if (type.Contains("Électrique"))
                TxtUnite.Text = "kWh";
            else if (type.Contains("Bois"))
                TxtUnite.Text = "stères";
        }

        // =============================================================
        // 🎨 GESTION DES BORDURES
        // =============================================================
        private void MarquerErreur(Control control)
        {
            Border cadre = control.Parent as Border;
            if (cadre != null)
                cadre.BorderBrush = _bordureErreur;
        }

        private void EffacerErreur(Control control)
        {
            Border cadre = control.Parent as Border;
            if (cadre != null)
                cadre.BorderBrush = (Brush)FindResource("BordureClaire");
        }

        // =============================================================
        // 🔄 RÉINITIALISATION VISUELLE DES ERREURS
        // =============================================================
        private void ResetValidation()
        {
            EffacerErreur(TxtQuantite);
            EffacerErreur(TxtMontant);
            EffacerErreur(TxtUnite);
            EffacerErreur(CmbType);
        }

    }
}
