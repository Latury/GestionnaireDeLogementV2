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

using GestionnaireDeLogement.Donnees;
using GestionnaireDeLogement.Modeles;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GestionnaireDeLogement.Vues
{
    /// <summary>
    /// Logique d'interaction pour AjouterFactureVue.xaml
    /// </summary>
    public partial class AjouterFactureVue : Page
    {
        public AjouterFactureVue()
        {
            InitializeComponent();

            // Définir la date du jour par défaut
            DateFacture.SelectedDate = DateTime.Now;
        }

        // ═══════════════════════════════════════════════════════════
        // GESTION DES CLICS SUR LES BOUTONS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Enregistrer la facture
        /// </summary>
        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            // Validation des champs obligatoires
            if (!ValiderFormulaire())
            {
                return;
            }

            try
            {
                // Charger les factures existantes pour générer un nouvel ID
                var factures = GestionnaireDonnees.Charger<Facture>("factures.json");
                int nouvelId = factures.Count > 0 ? factures.Max(f => f.Id) + 1 : 1;

                // Créer un nouvel objet Facture
                var nouvelleFacture = new Facture
                {
                    Id = nouvelId,
                    Type = ExtraireType(),  // ← MODIFIÉ : Sans paramètre
                    Montant = double.Parse(TxtMontant.Text),
                    DateFacture = DateFacture.SelectedDate ?? DateTime.Now,
                    DateEcheance = DateEcheance.SelectedDate,
                    EstPayee = ChkPayee.IsChecked ?? false,
                    Notes = TxtNotes.Text.Trim()
                };

                // Ajouter la nouvelle facture à la liste
                factures.Add(nouvelleFacture);

                // Sauvegarder la liste complète
                GestionnaireDonnees.Sauvegarder(factures, "factures.json");

                // Message de confirmation
                MessageBox.Show(
                    $"Facture de {nouvelleFacture.Montant:F2} € ajoutée avec succès !",
                    "Succès",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );

                // Retourner à la page des factures
                NavigationService?.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'enregistrement : {ex.Message}",
                    "Erreur",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }

        /// <summary>
        /// Annuler et retourner à la page précédente
        /// </summary>
        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            // Demander confirmation si des données ont été saisies
            if (!string.IsNullOrWhiteSpace(TxtMontant.Text) ||
                !string.IsNullOrWhiteSpace(TxtNotes.Text))
            {
                var resultat = MessageBox.Show(
                    "Voulez-vous vraiment annuler ?\nLes données saisies seront perdues.",
                    "Confirmation",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                );

                if (resultat == MessageBoxResult.No)
                {
                    return;
                }
            }

            // Retourner à la page précédente
            NavigationService?.GoBack();
        }

        // ═══════════════════════════════════════════════════════════
        // MÉTHODES UTILITAIRES
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Valider les champs du formulaire
        /// </summary>
        private bool ValiderFormulaire()
        {
            // Vérifier que le type est sélectionné
            if (CmbType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un type de facture.",
                    "Validation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                CmbType.Focus();
                return false;
            }

            // Vérifier que le montant est saisi
            if (string.IsNullOrWhiteSpace(TxtMontant.Text))
            {
                MessageBox.Show(
                    "Veuillez saisir un montant.",
                    "Validation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                TxtMontant.Focus();
                return false;
            }

            // Vérifier que le montant est un nombre valide
            if (!double.TryParse(TxtMontant.Text, out double montant) || montant <= 0)
            {
                MessageBox.Show(
                    "Le montant doit être un nombre positif valide.",
                    "Validation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                TxtMontant.Focus();
                TxtMontant.SelectAll();
                return false;
            }

            // Vérifier que la date de facture est sélectionnée
            if (DateFacture.SelectedDate == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner une date de facture.",
                    "Validation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                DateFacture.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Extraire le type de facture depuis la ComboBox
        /// </summary>
        private string ExtraireType()
        {
            if (CmbType.SelectedItem is ComboBoxItem selectedItem)
            {
                // Récupérer le StackPanel contenant l'icone et le texte
                if (selectedItem.Content is StackPanel stackPanel)
                {
                    // Le deuxième TextBlock contient le texte (le premier contient l'icone)
                    if (stackPanel.Children.Count >= 2 && stackPanel.Children[1] is TextBlock textBlock)
                    {
                        return textBlock.Text;
                    }
                }
            }

            return "Autre";
        }
    }
}
