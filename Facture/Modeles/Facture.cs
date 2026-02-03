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

using System;

namespace GestionnaireDeLogement.Modeles
{
    /// <summary>
    /// Représente une facture (eau, électricité, chauffage, autre)
    /// </summary>
    public class Facture
    {
        /// <summary>
        /// Identifiant unique de la facture
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Type de facture : "Eau", "Électricité", "Chauffage", "Autre"
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Montant de la facture en euros
        /// </summary>
        public double Montant { get; set; }

        /// <summary>
        /// Date d'émission de la facture
        /// </summary>
        public DateTime DateFacture { get; set; }

        /// <summary>
        /// Date limite de paiement (optionnelle)
        /// </summary>
        public DateTime? DateEcheance { get; set; }

        /// <summary>
        /// Indique si la facture est payée
        /// </summary>
        public bool EstPayee { get; set; }

        /// <summary>
        /// Date à laquelle la facture a été payée (optionnelle)
        /// </summary>
        public DateTime? DatePaiement { get; set; }

        /// <summary>
        /// Notes ou commentaires sur la facture (optionnel)
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Facture()
        {
            // Valeurs par défaut
            Type = "Autre";
            DateFacture = DateTime.Now;
            EstPayee = false;
            Notes = string.Empty;
        }
    }
}
