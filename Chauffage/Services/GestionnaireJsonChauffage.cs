/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Service JSON – Chauffage
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 * =============================================================
 */

using GestionnaireDeLogement.Modeles;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GestionnaireDeLogement.Services
{
    public static class GestionnaireJsonChauffage
    {
        private static readonly string CheminFichier =
            Path.Combine("Donnees", "chauffage.json");

        private static readonly JsonSerializerOptions Options =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

        // ===============================
        //  CHARGER
        // ===============================
        public static List<ReleveChauffage> Charger()
        {
            if (!File.Exists(CheminFichier))
                return new List<ReleveChauffage>();

            string json = File.ReadAllText(CheminFichier);

            return JsonSerializer.Deserialize<List<ReleveChauffage>>(json)
                   ?? new List<ReleveChauffage>();
        }

        // ===============================
        //  SAUVEGARDER
        // ===============================
        public static void Sauvegarder(IEnumerable<ReleveChauffage> releves)
        {
            Directory.CreateDirectory("Donnees");

            string json = JsonSerializer.Serialize(releves, Options);
            File.WriteAllText(CheminFichier, json);
        }
    }
}
