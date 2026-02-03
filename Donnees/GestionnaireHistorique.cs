using GestionnaireDeLogement.Modeles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GestionnaireDeLogement.Donnees
{
    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════
    /// 📜 GESTIONNAIRE D'HISTORIQUE
    /// ═══════════════════════════════════════════════════════════════════
    /// Permet d'enregistrer et de consulter l'historique des modifications
    /// ═══════════════════════════════════════════════════════════════════
    /// </summary>
    public static class GestionnaireHistorique
    {
        private const string FICHIER_HISTORIQUE = "historique.json";
        private static List<HistoriqueModification> _historique;
        private static int _prochainId = 1;

        /// <summary>
        /// 📥 Charge l'historique depuis le fichier
        /// </summary>
        private static void ChargerHistorique()
        {
            if (_historique == null)
            {
                _historique = GestionnaireDonnees.Charger<HistoriqueModification>(FICHIER_HISTORIQUE);
                if (_historique.Count > 0)
                {
                    _prochainId = _historique.Max(h => h.Id) + 1;
                }
            }
        }

        /// <summary>
        /// 💾 Sauvegarde l'historique dans le fichier
        /// </summary>
        private static void SauvegarderHistorique()
        {
            GestionnaireDonnees.Sauvegarder(_historique, FICHIER_HISTORIQUE);
        }

        /// <summary>
        /// ➕ Enregistre l'ajout d'un relevé d'eau
        /// </summary>
        public static void EnregistrerAjoutReleveEau(ReleveEau releve)
        {
            ChargerHistorique();

            var entree = new HistoriqueModification
            {
                Id = _prochainId++,
                DateModification = DateTime.Now,
                TypeEntite = "ReleveEau",
                IdEntite = releve.Id,
                TypeAction = "Ajout",
                Description = $"💧 Nouveau relevé d'eau - Date: {releve.DateReleve:dd/MM/yyyy}, Eau froide: {releve.IndexEauFroide:F2} m³, Eau chaude: {releve.IndexEauChaude:F2} m³"
            };

            _historique.Add(entree);
            SauvegarderHistorique();
        }

        /// <summary>
        /// ✏️ Enregistre la modification d'un relevé d'eau
        /// </summary>
        public static void EnregistrerModificationReleveEau(ReleveEau ancien, ReleveEau nouveau)
        {
            ChargerHistorique();

            // Comparer les champs et créer une entrée pour chaque changement
            if (ancien.DateReleve != nouveau.DateReleve)
            {
                _historique.Add(new HistoriqueModification
                {
                    Id = _prochainId++,
                    DateModification = DateTime.Now,
                    TypeEntite = "ReleveEau",
                    IdEntite = nouveau.Id,
                    TypeAction = "Modification",
                    ChampModifie = "DateReleve",
                    AncienneValeur = ancien.DateReleve.ToString("dd/MM/yyyy"),
                    NouvelleValeur = nouveau.DateReleve.ToString("dd/MM/yyyy"),
                    Description = $"📅 Date modifiée : {ancien.DateReleve:dd/MM/yyyy} → {nouveau.DateReleve:dd/MM/yyyy}"
                });
            }

            if (ancien.IndexEauFroide != nouveau.IndexEauFroide)
            {
                _historique.Add(new HistoriqueModification
                {
                    Id = _prochainId++,
                    DateModification = DateTime.Now,
                    TypeEntite = "ReleveEau",
                    IdEntite = nouveau.Id,
                    TypeAction = "Modification",
                    ChampModifie = "IndexEauFroide",
                    AncienneValeur = ancien.IndexEauFroide.ToString("F2", CultureInfo.InvariantCulture),
                    NouvelleValeur = nouveau.IndexEauFroide.ToString("F2", CultureInfo.InvariantCulture),
                    Description = $"💧 Index eau froide modifié : {ancien.IndexEauFroide:F2} m³ → {nouveau.IndexEauFroide:F2} m³"
                });
            }

            if (ancien.IndexEauChaude != nouveau.IndexEauChaude)
            {
                _historique.Add(new HistoriqueModification
                {
                    Id = _prochainId++,
                    DateModification = DateTime.Now,
                    TypeEntite = "ReleveEau",
                    IdEntite = nouveau.Id,
                    TypeAction = "Modification",
                    ChampModifie = "IndexEauChaude",
                    AncienneValeur = ancien.IndexEauChaude.ToString("F2", CultureInfo.InvariantCulture),
                    NouvelleValeur = nouveau.IndexEauChaude.ToString("F2", CultureInfo.InvariantCulture),
                    Description = $"🔥 Index eau chaude modifié : {ancien.IndexEauChaude:F2} m³ → {nouveau.IndexEauChaude:F2} m³"
                });
            }

            if (ancien.Notes != nouveau.Notes)
            {
                _historique.Add(new HistoriqueModification
                {
                    Id = _prochainId++,
                    DateModification = DateTime.Now,
                    TypeEntite = "ReleveEau",
                    IdEntite = nouveau.Id,
                    TypeAction = "Modification",
                    ChampModifie = "Notes",
                    AncienneValeur = ancien.Notes ?? "(vide)",
                    NouvelleValeur = nouveau.Notes ?? "(vide)",
                    Description = $"📝 Notes modifiées"
                });
            }

            SauvegarderHistorique();
        }

        /// <summary>
        /// 🗑️ Enregistre la suppression d'un relevé d'eau
        /// </summary>
        public static void EnregistrerSuppressionReleveEau(ReleveEau releve)
        {
            ChargerHistorique();

            var entree = new HistoriqueModification
            {
                Id = _prochainId++,
                DateModification = DateTime.Now,
                TypeEntite = "ReleveEau",
                IdEntite = releve.Id,
                TypeAction = "Suppression",
                Description = $"🗑️ Relevé supprimé - Date: {releve.DateReleve:dd/MM/yyyy}, Eau froide: {releve.IndexEauFroide:F2} m³, Eau chaude: {releve.IndexEauChaude:F2} m³"
            };

            _historique.Add(entree);
            SauvegarderHistorique();
        }

        /// <summary>
        /// 📋 Récupère tout l'historique
        /// </summary>
        public static List<HistoriqueModification> ObtenirHistorique()
        {
            ChargerHistorique();
            return _historique.OrderByDescending(h => h.DateModification).ToList();
        }

        /// <summary>
        /// 📋 Récupère l'historique filtré par type d'entité
        /// </summary>
        public static List<HistoriqueModification> ObtenirHistorique(string typeEntite)
        {
            ChargerHistorique();
            return _historique
                .Where(h => h.TypeEntite == typeEntite)
                .OrderByDescending(h => h.DateModification)
                .ToList();
        }

        /// <summary>
        /// 🗑️ Supprime une entrée spécifique de l'historique
        /// </summary>
        public static void SupprimerEntree(int id)
        {
            ChargerHistorique();
            var entree = _historique.FirstOrDefault(h => h.Id == id);
            if (entree != null)
            {
                _historique.Remove(entree);
                SauvegarderHistorique();
            }
        }

        /// <summary>
        /// 🗑️ Supprime toutes les entrées d'un type spécifique
        /// </summary>
        public static void SupprimerParCategorie(string typeEntite)
        {
            ChargerHistorique();
            _historique.RemoveAll(h => h.TypeEntite == typeEntite);
            SauvegarderHistorique();
        }

        /// <summary>
        /// 🗑️ Supprime TOUT l'historique
        /// </summary>
        public static void SupprimerTout()
        {
            ChargerHistorique();
            _historique.Clear();
            SauvegarderHistorique();
        }

        /// <summary>
        /// 📊 Compte le nombre d'entrées par catégorie
        /// </summary>
        public static int CompterParCategorie(string typeEntite)
        {
            ChargerHistorique();
            return _historique.Count(h => h.TypeEntite == typeEntite);
        }
    }
}
