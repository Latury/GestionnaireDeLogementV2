/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Eau
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using System;

namespace GestionnaireDeLogement.Modeles
{
    /// <summary>
    /// Représente un relevé de compteur d'eau (froide + chaude)
    /// </summary>
    public class ReleveEau
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
        /// Index du compteur d'eau froide en m³
        /// </summary>
        public double IndexEauFroide { get; set; }

        /// <summary>
        /// Index du compteur d'eau chaude en m³
        /// </summary>
        public double IndexEauChaude { get; set; }

        /// <summary>
        /// Consommation totale calculée en m³ (par rapport au relevé précédent)
        /// </summary>
        public double Consommation { get; set; }

        /// <summary>
        /// Montant estimé en euros (basé sur le prix au m³)
        /// </summary>
        public double MontantEstime { get; set; }

        /// <summary>
        /// Notes ou observations sur le relevé (optionnel)
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ReleveEau()
        {
            // Valeurs par défaut
            DateReleve = DateTime.Now;
            IndexEauFroide = 0;
            IndexEauChaude = 0;
            Consommation = 0;
            MontantEstime = 0;
            Notes = string.Empty;
        }

        /// <summary>
        /// Calcule la consommation par rapport au relevé précédent
        /// </summary>
        /// <param name="relevePrecedent">Le relevé précédent</param>
        /// <param name prixM3">Prix du m³ d'eau en euros</param>
        public void CalculerConsommation(ReleveEau relevePrecedent, double prixM3)
        {
            if (relevePrecedent != null)
            {
                // Consommation = (Index actuel eau froide + eau chaude) - (Index précédent eau froide + eau chaude)
                double indexTotal = IndexEauFroide + IndexEauChaude;
                double indexPrecedentTotal = relevePrecedent.IndexEauFroide + relevePrecedent.IndexEauChaude;

                Consommation = indexTotal - indexPrecedentTotal;

                // Calcul du montant estimé
                MontantEstime = Consommation * prixM3;
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
