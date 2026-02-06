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

using GestionnaireDeLogement.Configurations.Modeles;

namespace GestionnaireDeLogement.Configurations.Services
{
    /// <summary>
    /// Service central de gestion des configurations.
    /// Fournit l'accès à la configuration globale du logiciel.
    /// </summary>
    public class ConfigurationService
    {
        // ═══════════════════════════════════════════════════════════
        // PROPRIÉTÉS
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Configuration globale actuellement utilisée par l'application
        /// </summary>
        public ConfigurationGlobale Configuration { get; private set; }

        // ═══════════════════════════════════════════════════════════
        // CONSTRUCTEUR
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Initialise le service avec une configuration par défaut
        /// </summary>
        public ConfigurationService()
        {
            Configuration = new ConfigurationGlobale();
        }

        // ═══════════════════════════════════════════════════════════
        // MÉTHODES PUBLIQUES
        // ═══════════════════════════════════════════════════════════

        /// <summary>
        /// Réinitialise la configuration avec les valeurs par défaut
        /// </summary>
        public void ReinitialiserConfiguration()
        {
            Configuration = new ConfigurationGlobale();
        }

        /// <summary>
        /// Remplace la configuration actuelle par une nouvelle instance
        /// </summary>
        /// <param name="nouvelleConfiguration">Nouvelle configuration globale</param>
        public void ChargerConfiguration(ConfigurationGlobale nouvelleConfiguration)
        {
            if (nouvelleConfiguration != null)
            {
                Configuration = nouvelleConfiguration;
            }
        }
    }
}
