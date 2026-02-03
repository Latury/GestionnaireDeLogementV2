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
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GestionnaireDeLogement.Donnees
{
    /*
     * ╔═══════════════════════════════════════════════════════════════════
     * ║  📦 GESTIONNAIRE DE DONNÉES - SAUVEGARDE JSON                     
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  📌 Fonction principale : Sauvegarder et charger des données      
     * ║  📌 Format : JSON (JavaScript Object Notation)                    
     * ║  📌 Emplacement : Dossier "Configurations/" à la racine           
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  ✅ Fonctions disponibles :                                       
     * ║     1️⃣ Sauvegarder<T>(List<T> donnees, string nomFichier)         
     * ║     2️⃣ Charger<T>(string nomFichier)                              
     * ║     3️⃣ FichierExiste(string nomFichier)                           
     * ║     4️⃣ SupprimerFichier(string nomFichier)                        
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  🔒 Sécurité :                                                    
     * ║     • Création automatique du dossier Configurations/             
     * ║     • Gestion d'erreurs complète (try/catch)                      
     * ║     • Retour de liste vide si fichier inexistant                  
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  👤 Développeur : Latury (latury57@gmail.com)                     
     * ║  📅 Dernière mise à jour : 21/01/2026                            
     * ╚═══════════════════════════════════════════════════════════════════
     */

    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════
    /// 🗂️ CLASSE GESTIONNAIRE DE DONNÉES
    /// ═══════════════════════════════════════════════════════════════════
    /// Cette classe gère la sauvegarde et le chargement des données
    /// dans des fichiers JSON.
    /// 
    /// 📌 Pourquoi JSON ?
    ///    - Format texte lisible par l'humain
    ///    - Facile à débugger
    ///    - Compatible avec tous les langages
    /// 
    /// 📌 Où sont stockées les données ?
    ///    Dans le dossier "Configurations/" à côté de l'exe
    /// 
    /// 📌 Pourquoi utiliser une classe statique ?
    ///    - Pas besoin de créer une instance
    ///    - Accessible partout : GestionnaireDonnees.Sauvegarder(...)
    /// ═══════════════════════════════════════════════════════════════════
    /// </summary>
    public static class GestionnaireDonnees
    {
        // ═══════════════════════════════════════════════════════════════
        // 📂 CONSTANTE : DOSSIER DE CONFIGURATION
        // ═══════════════════════════════════════════════════════════════
        // Ce dossier contiendra tous les fichiers JSON de l'application
        // Exemple : "C:\MonApp\Configurations"
        // ═══════════════════════════════════════════════════════════════
        private const string DOSSIER_CONFIG = "Configurations";

        // ═══════════════════════════════════════════════════════════════
        // ⚙️ OPTIONS JSON (CONFIGURATION)
        // ═══════════════════════════════════════════════════════════════
        // Options pour la sérialisation/désérialisation JSON
        // - WriteIndented = true : Rend le JSON lisible (avec indentation)
        // - Encoder : Gère les accents français correctement
        // ═══════════════════════════════════════════════════════════════
        private static readonly JsonSerializerOptions OptionsJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        // ═══════════════════════════════════════════════════════════════
        // 🏗️ CONSTRUCTEUR STATIQUE
        // ═══════════════════════════════════════════════════════════════
        // Appelé automatiquement au premier accès à la classe
        // Crée le dossier Configurations s'il n'existe pas
        // ═══════════════════════════════════════════════════════════════
        static GestionnaireDonnees()
        {
            if (!Directory.Exists(DOSSIER_CONFIG))
            {
                Directory.CreateDirectory(DOSSIER_CONFIG);
                Console.WriteLine($"📁 Dossier créé : {DOSSIER_CONFIG}");
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 💾 FONCTION 1 : SAUVEGARDER
        // ═══════════════════════════════════════════════════════════════
        /// <summary>
        /// Sauvegarde une liste d'objets dans un fichier JSON.
        /// 
        /// 📝 PARAMÈTRES :
        ///    - donnees : Liste d'objets à sauvegarder
        ///    - nomFichier : Nom du fichier (exemple: "factures.json")
        /// 
        /// 🔄 PROCESSUS :
        ///    1️⃣ Construit le chemin complet du fichier
        ///    2️⃣ Convertit la liste en JSON (format texte)
        ///    3️⃣ Écrit le JSON dans le fichier
        /// 
        /// ⚠️ GESTION D'ERREURS :
        ///    Si une erreur survient (fichier verrouillé, disque plein...),
        ///    elle est capturée et affichée dans la console.
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    List<Facture> factures = new List<Facture>();
        ///    GestionnaireDonnees.Sauvegarder(factures, "factures.json");
        /// </summary>
        public static void Sauvegarder<T>(List<T> donnees, string nomFichier)
        {
            try
            {
                // ─────────────────────────────────────────────────────────
                // ÉTAPE 1 : Construire le chemin complet du fichier
                // ─────────────────────────────────────────────────────────
                string cheminComplet = Path.Combine(DOSSIER_CONFIG, nomFichier);

                // ─────────────────────────────────────────────────────────
                // ÉTAPE 2 : Convertir la liste en JSON
                // ─────────────────────────────────────────────────────────
                string json = JsonSerializer.Serialize(donnees, OptionsJson);

                // ─────────────────────────────────────────────────────────
                // ÉTAPE 3 : Écrire le JSON dans le fichier
                // ─────────────────────────────────────────────────────────
                File.WriteAllText(cheminComplet, json);

                Console.WriteLine($"✅ Sauvegarde réussie : {nomFichier} ({donnees.Count} éléments)");
            }
            catch (Exception ex)
            {
                // ─────────────────────────────────────────────────────────
                // GESTION D'ERREUR
                // ─────────────────────────────────────────────────────────
                Console.WriteLine($"❌ ERREUR lors de la sauvegarde de {nomFichier}: {ex.Message}");
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 📂 FONCTION 2 : CHARGER
        // ═══════════════════════════════════════════════════════════════
        /// <summary>
        /// Charge une liste d'objets depuis un fichier JSON.
        /// 
        /// 📝 PARAMÈTRES :
        ///    - nomFichier : Nom du fichier (exemple: "factures.json")
        /// 
        /// 🔄 PROCESSUS :
        ///    1️⃣ Vérifie si le fichier existe
        ///    2️⃣ Si oui, lit le contenu JSON
        ///    3️⃣ Convertit le JSON en liste d'objets
        ///    4️⃣ Retourne la liste
        /// 
        /// 🔙 RETOUR :
        ///    - Si fichier existe : Liste des objets
        ///    - Si fichier n'existe pas : Liste vide
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    List<Facture> factures = GestionnaireDonnees.Charger<Facture>("factures.json");
        /// </summary>
        public static List<T> Charger<T>(string nomFichier)
        {
            try
            {
                // ─────────────────────────────────────────────────────────
                // ÉTAPE 1 : Construire le chemin complet
                // ─────────────────────────────────────────────────────────
                string cheminComplet = Path.Combine(DOSSIER_CONFIG, nomFichier);

                // ─────────────────────────────────────────────────────────
                // ÉTAPE 2 : Vérifier si le fichier existe
                // ─────────────────────────────────────────────────────────
                if (!File.Exists(cheminComplet))
                {
                    // Fichier inexistant = première utilisation
                    Console.WriteLine($"ℹ️ Fichier {nomFichier} introuvable. Création d'une liste vide.");
                    return new List<T>();
                }

                // ─────────────────────────────────────────────────────────
                // ÉTAPE 3 : Lire le contenu du fichier
                // ─────────────────────────────────────────────────────────
                string json = File.ReadAllText(cheminComplet);

                // ─────────────────────────────────────────────────────────
                // ÉTAPE 4 : Convertir le JSON en liste d'objets
                // ─────────────────────────────────────────────────────────
                List<T> donnees = JsonSerializer.Deserialize<List<T>>(json, OptionsJson);

                Console.WriteLine($"✅ Chargement réussi : {nomFichier} ({donnees?.Count ?? 0} éléments)");
                return donnees ?? new List<T>();
            }
            catch (Exception ex)
            {
                // ─────────────────────────────────────────────────────────
                // GESTION D'ERREUR
                // ─────────────────────────────────────────────────────────
                Console.WriteLine($"❌ ERREUR lors du chargement de {nomFichier}: {ex.Message}");
                return new List<T>();
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 🔍 FONCTION 3 : VÉRIFIER EXISTENCE
        // ═══════════════════════════════════════════════════════════════
        /// <summary>
        /// Vérifie si un fichier de données existe.
        /// 
        /// 📝 PARAMÈTRES :
        ///    - nomFichier : Nom du fichier (exemple: "factures.json")
        /// 
        /// 🔙 RETOUR :
        ///    - true : Le fichier existe
        ///    - false : Le fichier n'existe pas
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    if (GestionnaireDonnees.FichierExiste("factures.json"))
        ///    {
        ///        // Fichier existe, on peut le charger
        ///    }
        /// </summary>
        public static bool FichierExiste(string nomFichier)
        {
            string cheminComplet = Path.Combine(DOSSIER_CONFIG, nomFichier);
            return File.Exists(cheminComplet);
        }

        // ═══════════════════════════════════════════════════════════════
        // 🗑️ FONCTION 4 : SUPPRIMER UN FICHIER
        // ═══════════════════════════════════════════════════════════════
        /// <summary>
        /// Supprime un fichier de données.
        /// 
        /// 📝 PARAMÈTRES :
        ///    - nomFichier : Nom du fichier (exemple: "factures.json")
        /// 
        /// ⚠️ ATTENTION :
        ///    Cette action est irréversible ! Le fichier sera supprimé
        ///    définitivement.
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    GestionnaireDonnees.SupprimerFichier("factures.json");
        /// </summary>
        public static void SupprimerFichier(string nomFichier)
        {
            try
            {
                string cheminComplet = Path.Combine(DOSSIER_CONFIG, nomFichier);

                if (File.Exists(cheminComplet))
                {
                    File.Delete(cheminComplet);
                    Console.WriteLine($"✅ Fichier supprimé : {nomFichier}");
                }
                else
                {
                    Console.WriteLine($"ℹ️ Fichier {nomFichier} introuvable. Rien à supprimer.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERREUR lors de la suppression de {nomFichier}: {ex.Message}");
            }
        }
    }
}
