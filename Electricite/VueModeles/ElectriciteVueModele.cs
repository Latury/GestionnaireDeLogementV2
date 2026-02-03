/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Chauffage
 *
 *  Copyright © 2026 Flo
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using GestionnaireDeLogement.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GestionnaireDeLogement.Releves.Chauffage
{
    public class ElectriciteVueModele : INotifyPropertyChanged
    {
        // ═══════════════════════════════════════════════════════════════
        // 🔔 NOTIFICATION WPF
        // ═══════════════════════════════════════════════════════════════

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifierChangement(string nomPropriete)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomPropriete));
        }

        // ═══════════════════════════════════════════════════════════════
        // 📋 LISTE DES RELEVÉS
        // ═══════════════════════════════════════════════════════════════

        public List<ReleveChauffage> Releves { get; private set; }

        // ═══════════════════════════════════════════════════════════════
        // 📊 STATISTIQUES
        // ═══════════════════════════════════════════════════════════════

        private string _dernierReleve;
        public string DernierReleve
        {
            get => _dernierReleve;
            private set
            {
                _dernierReleve = value;
                NotifierChangement(nameof(DernierReleve));
            }
        }

        private string _consommationDernierMois;
        public string ConsommationDernierMois
        {
            get => _consommationDernierMois;
            private set
            {
                _consommationDernierMois = value;
                NotifierChangement(nameof(ConsommationDernierMois));
            }
        }

        private string _moyenneMensuelle;
        public string MoyenneMensuelle
        {
            get => _moyenneMensuelle;
            private set
            {
                _moyenneMensuelle = value;
                NotifierChangement(nameof(MoyenneMensuelle));
            }
        }

        private string _coutDernierMois;
        public string CoutDernierMois
        {
            get => _coutDernierMois;
            private set
            {
                _coutDernierMois = value;
                NotifierChangement(nameof(CoutDernierMois));
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 📌 RELEVÉ SÉLECTIONNÉ
        // ═══════════════════════════════════════════════════════════════

        private ReleveChauffage _releveSelectionne;
        public ReleveChauffage ReleveSelectionne
        {
            get => _releveSelectionne;
            set
            {
                _releveSelectionne = value;
                NotifierChangement(nameof(ReleveSelectionne));
                NotifierChangement(nameof(UnReleveEstSelectionne));
            }
        }

        public bool UnReleveEstSelectionne => ReleveSelectionne != null;

        // ═══════════════════════════════════════════════════════════════
        // 🏗️ CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════════

        public ElectriciteVueModele()
        {
            InitialiserFauxReleves();
            CalculerStatistiques();
        }

        // ═══════════════════════════════════════════════════════════════
        // 🧪 DONNÉES DE TEST
        // ═══════════════════════════════════════════════════════════════

        private void InitialiserFauxReleves()
        {
            Releves = new List<ReleveChauffage>();

            var r1 = new ReleveChauffage
            {
                DateReleve = new DateTime(2025, 1, 10),
                Notes = "Hiver froid"
            };
            r1.DefinirTypeChauffage("Gaz");
            r1.IndexCompteur = 15200;
            r1.CalculerConsommation(null, 1.40);

            var r2 = new ReleveChauffage
            {
                DateReleve = new DateTime(2025, 2, 10),
                Notes = "Température stable"
            };
            r2.DefinirTypeChauffage("Gaz");
            r2.IndexCompteur = 15320;
            r2.CalculerConsommation(r1, 1.40);

            var r3 = new ReleveChauffage
            {
                DateReleve = new DateTime(2025, 3, 10),
                Notes = "Début du printemps"
            };
            r3.DefinirTypeChauffage("Gaz");
            r3.IndexCompteur = 15400;
            r3.CalculerConsommation(r2, 1.40);

            Releves.Add(r1);
            Releves.Add(r2);
            Releves.Add(r3);
        }

        // ═══════════════════════════════════════════════════════════════
        // 📈 CALCULS
        // ═══════════════════════════════════════════════════════════════

        private void CalculerStatistiques()
        {
            if (Releves == null || Releves.Count == 0)
                return;

            var dernier = Releves.OrderByDescending(r => r.DateReleve).First();

            DernierReleve = dernier.DateReleve.ToString("dd/MM/yyyy");
            ConsommationDernierMois = dernier.Consommation.ToString("N0");
            MoyenneMensuelle = Math.Round(Releves.Average(r => r.Consommation)).ToString("N0");
            CoutDernierMois = dernier.MontantEstime.ToString("F2");
        }

        public void RafraichirStatistiques()
        {
            CalculerStatistiques();
        }
    }
}
