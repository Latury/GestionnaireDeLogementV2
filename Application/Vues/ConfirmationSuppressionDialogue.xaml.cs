using System.Windows;

namespace GestionnaireDeLogement.Vues
{
    public partial class ConfirmationSuppressionDialogue : Window
    {
        public ConfirmationSuppressionDialogue(string message)
        {
            InitializeComponent();
            TxtMessage.Text = message;
        }

        private void BtnConfirmer_Click(object sender, RoutedEventArgs e)
        {
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
