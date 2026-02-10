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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using GestionnaireDeLogement.Services;

namespace GestionnaireDeLogement.Chauffage.VueModeles
{
    /*
     ╔══════════════════════════════════════════════════════════════╗
     ║  VIEWMODEL CHAUFFAGE                                         ║
     ╠══════════════════════════════════════════════════════════════╣
     ║   Source unique des données                                  ║
     ║   Filtrage par type                                          ║
     ║   Calcul des statistiques                                    ║
     ║   AUCUN code graphique                                       ║
     ╚══════════════════════════════════════════════════════════════╝
    */
    public class ChauffageVueModele : INotifyPropertyChanged
    {
        // ===============================
        // 📋 LISTE SOURCE (COMPLÈTE)
        // ===============================
        public ObservableCollection<ReleveChauffage> Releves { get; }

        // ===============================
        // 📋 LISTE AFFICHÉE (FILTRÉE)
        // ===============================
        private ObservableCollection<ReleveChauffage> _relevesFiltres;
        public ObservableCollection<ReleveChauffage> RelevesFiltres
        {
            get => _relevesFiltres;
            private set
            {
                _relevesFiltres = value;
                OnPropertyChanged(nameof(RelevesFiltres));
                CalculerStatistiques();
            }
        }

        // ===============================
        // 🔎 FILTRE
        // ===============================
        private string _typeFiltre = "Tous";
        public string TypeFiltre
        {
            get => _typeFiltre;
            set
            {
                _typeFiltre = value;
                OnPropertyChanged(nameof(TypeFiltre));
                AppliquerFiltre();
            }
        }

        // ===============================
        // 📌 SÉLECTION
        // ===============================
        private ReleveChauffage _releveSelectionne;
        public ReleveChauffage ReleveSelectionne
        {
            get => _releveSelectionne;
            set
            {
                _releveSelectionne = value;
                OnPropertyChanged(nameof(ReleveSelectionne));
                OnPropertyChanged(nameof(UnReleveEstSelectionne));
            }
        }

        public bool UnReleveEstSelectionne => ReleveSelectionne != null;

        // ===============================
        // 📊 STATISTIQUES
        // ===============================
        public string DernierReleve { get; private set; } = "-";
        public double ConsommationDernierMois { get; private set; }
        public double MoyenneMensuelle { get; private set; }
        public double CoutDernierMois { get; private set; }

        // ===============================
        // 🏗️ CONSTRUCTEUR
        // ===============================
        public ChauffageVueModele()
        {
            Releves = new ObservableCollection<ReleveChauffage>(
                GestionnaireJsonChauffage.Charger()
            );

            Releves.CollectionChanged += (_, __) =>
            {
                AppliquerFiltre();
                GestionnaireJsonChauffage.Sauvegarder(Releves);
            };

            AppliquerFiltre();
        }

        // ===============================
        // 🔎 FILTRAGE
        // ===============================
        private void AppliquerFiltre()
        {
            RelevesFiltres = TypeFiltre == "Tous"
                ? new ObservableCollection<ReleveChauffage>(Releves)
                : new ObservableCollection<ReleveChauffage>(
                    Releves.Where(r => r.TypeChauffage == TypeFiltre)
                  );
        }

        // ===============================
        // 📊 STATISTIQUES
        // ===============================
        private void CalculerStatistiques()
        {
            if (RelevesFiltres.Count == 0)
            {
                DernierReleve = "-";
                ConsommationDernierMois = 0;
                MoyenneMensuelle = 0;
                CoutDernierMois = 0;
            }
            else
            {
                var dernier = RelevesFiltres.OrderByDescending(r => r.DateReleve).First();
                DernierReleve = dernier.DateReleve.ToString("dd/MM/yyyy");
                ConsommationDernierMois = dernier.Consommation;
                MoyenneMensuelle = Math.Round(RelevesFiltres.Average(r => r.Consommation), 2);
                CoutDernierMois = Math.Round(dernier.MontantEstime, 2);
            }

            OnPropertyChanged(nameof(DernierReleve));
            OnPropertyChanged(nameof(ConsommationDernierMois));
            OnPropertyChanged(nameof(MoyenneMensuelle));
            OnPropertyChanged(nameof(CoutDernierMois));
        }

        // ===============================
        // 🔔 NOTIFICATION
        // ===============================
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nom)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nom));
    }
}
