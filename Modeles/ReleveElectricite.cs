using System;

namespace GestionnaireDeLogement.Modeles
{
    /// <summary>
    /// Représente un relevé de compteur d'électricité (heures creuses + heures pleines)
    /// </summary>
    public class ReleveElectricite
    {
        /// <summary>
        /// Identifiant unique du relevé
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date du relevé de compteur
        /// </summary>
        public DateTime DateReleve { get; set; }

        /// <summary>
        /// Index du compteur en heures creuses (kWh)
        /// </summary>
        public double IndexHeuresCreuses { get; set; }

        /// <summary>
        /// Index du compteur en heures pleines (kWh)
        /// </summary>
        public double IndexHeuresPleines { get; set; }

        /// <summary>
        /// Consommation totale calculée en kWh (par rapport au relevé précédent)
        /// </summary>
        public double Consommation { get; set; }

        /// <summary>
        /// Montant estimé en euros (basé sur les tarifs HC/HP)
        /// </summary>
        public double MontantEstime { get; set; }

        /// <summary>
        /// Notes ou observations sur le relevé (optionnel)
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ReleveElectricite()
        {
            // Valeurs par défaut
            DateReleve = DateTime.Now;
            IndexHeuresCreuses = 0;
            IndexHeuresPleines = 0;
            Consommation = 0;
            MontantEstime = 0;
            Notes = string.Empty;
        }

        /// <summary>
        /// Calcule la consommation par rapport au relevé précédent
        /// </summary>
        /// <param name="relevePrecedent">Le relevé précédent</param>
        /// <param name="prixHC">Prix du kWh en heures creuses (€)</param>
        /// <param name="prixHP">Prix du kWh en heures pleines (€)</param>
        public void CalculerConsommation(ReleveElectricite relevePrecedent, double prixHC, double prixHP)
        {
            if (relevePrecedent != null)
            {
                // Consommation HC
                double consommationHC = IndexHeuresCreuses - relevePrecedent.IndexHeuresCreuses;

                // Consommation HP
                double consommationHP = IndexHeuresPleines - relevePrecedent.IndexHeuresPleines;

                // Consommation totale
                Consommation = consommationHC + consommationHP;

                // Calcul du montant estimé
                MontantEstime = (consommationHC * prixHC) + (consommationHP * prixHP);
            }
            else
            {
                // Premier relevé : pas de consommation à calculer
                Consommation = 0;
                MontantEstime = 0;
            }
        }
    }
}
