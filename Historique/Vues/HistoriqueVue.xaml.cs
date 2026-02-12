using System.Linq;
using System.Windows;
using System.Windows.Controls;
using GestionnaireDeLogement.Donnees;
using GestionnaireDeLogement.Modeles;

namespace GestionnaireDeLogement.Vues
{
 /// <summary>
 /// 
 /// PAGE HISTORIQUE DES MODIFICATIONS
 /// 
 /// Affiche toutes les modifications apportées aux relevés et factures
 /// 
 /// </summary>
 public partial class HistoriqueVue : Page
 {
 private string _filtreCourant = null;

 public HistoriqueVue()
 {
 InitializeComponent();
 ChargerHistorique();
 }

 /// <summary>
 /// Charge et affiche l'historique complet
 /// </summary>
 private void ChargerHistorique(string filtre = null)
 {
 _filtreCourant = filtre;

 var historique = string.IsNullOrEmpty(filtre)
 ? GestionnaireHistorique.ObtenirHistorique()
 : GestionnaireHistorique.ObtenirHistorique(filtre);

 ListeHistorique.ItemsSource = historique;
 MessageVide.Visibility = historique.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
 }

 /// <summary>
 /// Gère le changement de filtre
 /// </summary>
 private void RbFiltre_Checked(object sender, RoutedEventArgs e)
 {
 if (ListeHistorique == null) return;

 if (RbTout?.IsChecked == true)
 ChargerHistorique();
 else if (RbEau?.IsChecked == true)
 ChargerHistorique("ReleveEau");
 else if (RbElectricite?.IsChecked == true)
 ChargerHistorique("ReleveElectricite");
 else if (RbChauffage?.IsChecked == true)
 ChargerHistorique("ReleveChauffage");
 else if (RbFactures?.IsChecked == true)
 ChargerHistorique("Facture");
 }

 /// <summary>
 /// Supprime une seule ligne d'historique
 /// </summary>
 private void BtnSupprimerLigne_Click(object sender, RoutedEventArgs e)
 {
 if (sender is Button btn && btn.Tag is HistoriqueModification entree)
 {
 // 1ère confirmation simple
 var resultat1 = MessageBox.Show(
 $"Voulez-vous supprimer cette entrée ?\n\n{entree.Description}",
 "Confirmation",
 MessageBoxButton.YesNo,
 MessageBoxImage.Question
 );

 if (resultat1 == MessageBoxResult.Yes)
 {
 // 2ème confirmation VOYANTE
 var dialogue = new ConfirmationSuppressionDialogue(
 $"Vous allez supprimer définitivement cette entrée :\n\n{entree.Description}"
 );

 if (dialogue.ShowDialog() == true)
 {
 GestionnaireHistorique.SupprimerEntree(entree.Id);
 ChargerHistorique(_filtreCourant);

 MessageBox.Show(
 " Entrée supprimée avec succès !",
 "Succès",
 MessageBoxButton.OK,
 MessageBoxImage.Information
 );
 }
 }
 }
 }

 /// <summary>
 /// Supprime toutes les entrées de la catégorie sélectionnée
 /// </summary>
 private void BtnSupprimerCategorie_Click(object sender, RoutedEventArgs e)
 {
 // Déterminer la catégorie sélectionnée
 string categorie = null;
 string nomCategorie = "Tout";

 if (RbEau?.IsChecked == true)
 {
 categorie = "ReleveEau";
 nomCategorie = "Eau ";
 }
 else if (RbElectricite?.IsChecked == true)
 {
 categorie = "ReleveElectricite";
 nomCategorie = "Électricité ";
 }
 else if (RbChauffage?.IsChecked == true)
 {
 categorie = "ReleveChauffage";
 nomCategorie = "Chauffage ";
 }
 else if (RbFactures?.IsChecked == true)
 {
 categorie = "Facture";
 nomCategorie = "Factures ";
 }
 else
 {
 MessageBox.Show(
 " Veuillez d'abord sélectionner une catégorie spécifique (pas 'Tout').",
 "Sélection requise",
 MessageBoxButton.OK,
 MessageBoxImage.Warning
 );
 return;
 }

 // Compter les entrées
 int nombre = GestionnaireHistorique.CompterParCategorie(categorie);

 if (nombre == 0)
 {
 MessageBox.Show(
 $"Aucune entrée de type {nomCategorie} à supprimer.",
 "Information",
 MessageBoxButton.OK,
 MessageBoxImage.Information
 );
 return;
 }

 // 1ère confirmation simple
 var resultat1 = MessageBox.Show(
 $"Voulez-vous supprimer TOUTES les {nombre} entrées de la catégorie {nomCategorie} ?",
 "Confirmation",
 MessageBoxButton.YesNo,
 MessageBoxImage.Question
 );

 if (resultat1 == MessageBoxResult.Yes)
 {
 // 2ème confirmation VOYANTE
 var dialogue = new ConfirmationSuppressionDialogue(
 $"Vous allez supprimer {nombre} entrée(s) de la catégorie {nomCategorie} !\n\nCette action est DÉFINITIVE !"
 );

 if (dialogue.ShowDialog() == true)
 {
 GestionnaireHistorique.SupprimerParCategorie(categorie);
 ChargerHistorique(_filtreCourant);

 MessageBox.Show(
 $" {nombre} entrée(s) supprimée(s) avec succès !",
 "Succès",
 MessageBoxButton.OK,
 MessageBoxImage.Information
 );
 }
 }
 }

 /// <summary>
 /// Supprime TOUT l'historique
 /// </summary>
 private void BtnSupprimerTout_Click(object sender, RoutedEventArgs e)
 {
 var historique = GestionnaireHistorique.ObtenirHistorique();
 int nombre = historique.Count;

 if (nombre == 0)
 {
 MessageBox.Show(
 "L'historique est déjà vide.",
 "Information",
 MessageBoxButton.OK,
 MessageBoxImage.Information
 );
 return;
 }

 // 1ère confirmation simple
 var resultat1 = MessageBox.Show(
 $" ATTENTION \n\nVous allez supprimer TOUT l'historique ({nombre} entrées) !\n\nÊtes-vous sûr ?",
 " CONFIRMATION IMPORTANTE",
 MessageBoxButton.YesNo,
 MessageBoxImage.Warning
 );

 if (resultat1 == MessageBoxResult.Yes)
 {
 // 2ème confirmation VOYANTE
 var dialogue = new ConfirmationSuppressionDialogue(
 $"Vous allez supprimer TOUTES les {nombre} entrées de l'historique !\n\nTOUTES les modifications enregistrées seront PERDUES À JAMAIS !"
 );

 if (dialogue.ShowDialog() == true)
 {
 GestionnaireHistorique.SupprimerTout();
 ChargerHistorique(_filtreCourant);

 MessageBox.Show(
 $" Historique complètement effacé ({nombre} entrées supprimées).",
 "Succès",
 MessageBoxButton.OK,
 MessageBoxImage.Information
 );
 }
 }
 }
 }
}





