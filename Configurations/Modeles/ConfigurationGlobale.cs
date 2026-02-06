/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Configurations
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

namespace GestionnaireDeLogement.Configurations.Modeles
{
    /// <summary>
    /// Représente l'ensemble des paramètres globaux du logiciel.
    /// Ces valeurs seront utilisées plus tard par les modules :
    /// - Chauffage
    /// - Eau
    /// - Électricité
    /// </summary>
    public class ConfigurationGlobale
    {
        // ═══════════════════════════════════════════════════════════
        // PARAMÈTRES GÉNÉRAUX
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Indique si les calculs automatiques sont activés
        /// (désactivé par défaut pour la phase actuelle)
        /// </summary>
        public bool CalculsAutomatiquesActifs { get; set; }

        // ═══════════════════════════════════════════════════════════
        // PARAMÈTRES EAU
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Prix du m³ d'eau (en euros)
        /// </summary>
        public decimal PrixM3Eau { get; set; }

        // ═══════════════════════════════════════════════════════════
        // PARAMÈTRES ÉLECTRICITÉ
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Prix du kWh d'électricité (en euros)
        /// </summary>
        public decimal PrixKWhElectricite { get; set; }

        /// <summary>
        /// Indique si le tarif Heures Pleines / Heures Creuses est utilisé
        /// </summary>
        public bool TarifHeuresPleinesCreusesActif { get; set; }

        /// <summary>
        /// Prix du kWh en Heures Pleines
        /// </summary>
        public decimal PrixKWhHeuresPleines { get; set; }

        /// <summary>
        /// Prix du kWh en Heures Creuses
        /// </summary>
        public decimal PrixKWhHeuresCreuses { get; set; }

        // ═══════════════════════════════════════════════════════════
        // CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Initialise la configuration avec des valeurs par défaut
        /// (valeurs fictives pour le développement)
        /// </summary>
        public ConfigurationGlobale()
        {
            // Calculs désactivés par défaut
            CalculsAutomatiquesActifs = false;

            // Eau
            PrixM3Eau = 0.00m;

            // Électricité
            PrixKWhElectricite = 0.00m;
            TarifHeuresPleinesCreusesActif = false;
            PrixKWhHeuresPleines = 0.00m;
            PrixKWhHeuresCreuses = 0.00m;
        }
    }
}
