using System;
using System.Globalization;
using System.Windows;
using GestionnaireDeLogement.Modeles;

namespace GestionnaireDeLogement.Vues
{
    public partial class ModifierReleveEauDialogue : Window
    {
        public ReleveEau ReleveModifie { get; private set; }
        private int _idOriginal;

        public ModifierReleveEauDialogue(ReleveEau releveAModifier)
        {
            InitializeComponent();
            _idOriginal = releveAModifier.Id;
            DatePicker.SelectedDate = releveAModifier.DateReleve;
            TxtEauFroide.Text = releveAModifier.IndexEauFroide.ToString("F2", CultureInfo.InvariantCulture);
            TxtEauChaude.Text = releveAModifier.IndexEauChaude.ToString("F2", CultureInfo.InvariantCulture);
            TxtNotes.Text = releveAModifier.Notes ?? string.Empty;
            TxtEauFroide.Focus();
            TxtEauFroide.SelectAll();
        }

        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (!DatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("⚠️ Veuillez sélectionner une date de relevé.", "Champ manquant", MessageBoxButton.OK, MessageBoxImage.Warning);
                DatePicker.Focus();
                return;
            }

            if (!double.TryParse(TxtEauFroide.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double eauFroide))
            {
                MessageBox.Show("⚠️ L'index d'eau froide doit être un nombre valide.\n\nExemple : 123.45", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauFroide.Focus();
                TxtEauFroide.SelectAll();
                return;
            }

            if (eauFroide < 0)
            {
                MessageBox.Show("⚠️ L'index d'eau froide ne peut pas être négatif.", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauFroide.Focus();
                TxtEauFroide.SelectAll();
                return;
            }

            if (!double.TryParse(TxtEauChaude.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double eauChaude))
            {
                MessageBox.Show("⚠️ L'index d'eau chaude doit être un nombre valide.\n\nExemple : 123.45", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauChaude.Focus();
                TxtEauChaude.SelectAll();
                return;
            }

            if (eauChaude < 0)
            {
                MessageBox.Show("⚠️ L'index d'eau chaude ne peut pas être négatif.", "Valeur invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtEauChaude.Focus();
                TxtEauChaude.SelectAll();
                return;
            }

            ReleveModifie = new ReleveEau
            {
                Id = _idOriginal,
                DateReleve = DatePicker.SelectedDate.Value,
                IndexEauFroide = eauFroide,
                IndexEauChaude = eauChaude,
                Notes = TxtNotes.Text.Trim()
            };

            DialogResult = true;
            Close();
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
