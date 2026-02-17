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
    /// Page d'accueil avec statistiques et dernières factures
    /// </summary>
    public partial class TableauDeBordVue : Page
    {
        public TableauDeBordVue()
        {
            InitializeComponent();
            Loaded += TableauDeBordVue_Loaded;
        }

        /// <summary>
        /// Chargement des données de la page
        /// </summary>
        private void TableauDeBordVue_Loaded(object sender, RoutedEventArgs e)
        {
            ChargerStatistiques();
            ChargerDernieresFactures();
        }

        /// <summary>
        /// Charger les statistiques du mois en cours
        /// </summary>
        private void ChargerStatistiques()
        {
            try
            {
                // Charger toutes les factures
                var factures = GestionnaireDonnees.Charger<Facture>("factures.json");

                // Filtrer les factures du mois en cours
                var dateDebut = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var dateFin = dateDebut.AddMonths(1).AddDays(-1);

                var facturesMois = factures.Where(f =>
                    f.DateFacture >= dateDebut &&
                    f.DateFacture <= dateFin
                ).ToList();

                // ═══════════════════════════════════════════════════════
                // CARTE 1 : TOTAL DES FACTURES
                // ═══════════════════════════════════════════════════════
                double totalFactures = facturesMois.Sum(f => f.Montant);
                TxtTotalFactures.Text = $"{totalFactures:F2} €";

                // ═══════════════════════════════════════════════════════
                // CARTE 2 : CONSOMMATION D'EAU
                // ═══════════════════════════════════════════════════════
                var facturesEau = facturesMois.Where(f => f.Type == "Eau").ToList();
                double totalEau = facturesEau.Sum(f => f.Montant);

                // Estimation : 1 m³ ≈ 4€ (ajuster selon votre tarif réel)
                double consommationEau = totalEau > 0 ? totalEau / 4.0 : 0;
                TxtConsommationEau.Text = $"{consommationEau:F1} m³";

                // ═══════════════════════════════════════════════════════
                // CARTE 3 : CONSOMMATION D'ÉLECTRICITÉ
                // ═══════════════════════════════════════════════════════
                var facturesElec = facturesMois.Where(f => f.Type == "Électricité").ToList();
                double totalElec = facturesElec.Sum(f => f.Montant);

                // Estimation : 1 kWh ≈ 0,20€ (ajuster selon votre tarif réel)
                double consommationElec = totalElec > 0 ? totalElec / 0.20 : 0;
                TxtConsommationElec.Text = $"{consommationElec:F0} kWh";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors du chargement des statistiques :\n{ex.Message}",
                    "Erreur",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }

        /// <summary>
        /// Charger les 5 dernières factures
        /// </summary>
        private void ChargerDernieresFactures()
        {
            try
            {
                // Charger toutes les factures
                var factures = GestionnaireDonnees.Charger<Facture>("factures.json");

                // Prendre les 5 dernières factures (triées par date décroissante)
                var dernieresFactures = factures
                    .OrderByDescending(f => f.DateFacture)
                    .Take(5)
                    .ToList();

                // Si aucune facture, afficher le message par défaut
                if (dernieresFactures.Count == 0)
                {
                    ScrollFactures.Visibility = Visibility.Collapsed;
                    return;
                }

                // Afficher la liste
                ScrollFactures.Visibility = Visibility.Visible;


                // Masquer le message vide et afficher la liste
                ScrollFactures.Visibility = Visibility.Visible;

                // Remplir la liste avec les factures
                ListeFactures.ItemsSource = dernieresFactures;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors du chargement des factures :\n{ex.Message}",
                    "Erreur",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }
    }
}
