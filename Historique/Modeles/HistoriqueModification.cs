using System;

namespace GestionnaireDeLogement.Modeles
{
    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════
    ///  HISTORIQUE DES MODIFICATIONS
    /// ═══════════════════════════════════════════════════════════════════
    /// Enregistre toutes les modifications apportées aux relevés
    /// ═══════════════════════════════════════════════════════════════════
    /// </summary>
    public class HistoriqueModification
    {
        /// <summary>
        /// ID unique de l'entrée d'historique
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date et heure de la modification
        /// </summary>
        public DateTime DateModification { get; set; }

        /// <summary>
        /// Type d'entité modifiée : "ReleveEau", "ReleveElectricite", "Facture", etc.
        /// </summary>
        public string TypeEntite { get; set; }

        /// <summary>
        /// ID de l'élément modifié
        /// </summary>
        public int IdEntite { get; set; }

        /// <summary>
        /// Type d'action : "Ajout", "Modification", "Suppression"
        /// </summary>
        public string TypeAction { get; set; }

        /// <summary>
        /// Nom du champ modifié (ex: "IndexEauFroide", "Montant", etc.)
        /// </summary>
        public string ChampModifie { get; set; }

        /// <summary>
        /// Ancienne valeur (format texte)
        /// </summary>
        public string AncienneValeur { get; set; }

        /// <summary>
        /// Nouvelle valeur (format texte)
        /// </summary>
        public string NouvelleValeur { get; set; }

        /// <summary>
        /// Description lisible de la modification
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HistoriqueModification()
        {
            DateModification = DateTime.Now;
            TypeEntite = string.Empty;
            TypeAction = string.Empty;
            ChampModifie = string.Empty;
            AncienneValeur = string.Empty;
            NouvelleValeur = string.Empty;
            Description = string.Empty;
        }
    }
}
