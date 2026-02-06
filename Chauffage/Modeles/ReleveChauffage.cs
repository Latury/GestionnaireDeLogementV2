/*
 * =============================================================
 *  Gestionnaire de Logement
 *  Module Chauffage
 *
 *  Copyright © 2026 Flo Latury
 *  Licence : CC BY-NC 4.0
 *  Usage commercial interdit
 * =============================================================
 */

using System;

namespace GestionnaireDeLogement.Modeles
{
    /*
     * ╔═══════════════════════════════════════════════════════════════════
     * ║  🔥 MODÈLE RELEVÉ DE CHAUFFAGE                                    
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  📌 Fonction principale : Gérer les relevés de chauffage          
     * ║  📌 Types supportés : Gaz, Bois, Électrique, Fioul               
     * ║  📌 Utilisé dans : ChauffageVue.xaml                              
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  ✅ Propriétés :                                                  
     * ║     • Id : Identifiant unique                                     
     * ║     • DateReleve : Date du relevé                                 
     * ║     • TypeChauffage : Gaz / Bois / Électrique / Fioul            
     * ║     • IndexCompteur : Index du compteur (Gaz, Électrique)         
     * ║     • Quantite : Quantité livrée (Bois, Fioul)                   
     * ║     • Unite : m³, kWh, Stère, L                                   
     * ║     • Consommation : Consommation calculée                        
     * ║     • MontantEstime : Coût estimé en €                            
     * ║     • Notes : Observations                                        
     * ╠═══════════════════════════════════════════════════════════════════
     * ║  👤 Développeur : Latury (latury57@gmail.com)                     
     * ║  📅 Date de création : 24/01/2026                                 
     * ╚═══════════════════════════════════════════════════════════════════
     */

    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════
    /// 🔥 CLASSE RELEVÉ DE CHAUFFAGE
    /// ═══════════════════════════════════════════════════════════════════
    /// Représente un relevé de consommation de chauffage.
    /// 
    /// 📌 Types de chauffage supportés :
    ///    • 🔥 Gaz : Compteur en m³
    ///    • 🪵 Bois : Quantité en stères ou kg
    ///    • ⚡ Électrique : Compteur en kWh
    ///    • 🛢️ Fioul : Quantité livrée en litres
    /// 
    /// 📌 Calcul de consommation :
    ///    - Gaz/Électrique : Différence entre deux index
    ///    - Bois/Fioul : Quantité livrée = consommation
    /// 
    /// 📌 Utilisé dans :
    ///    - ChauffageVue.xaml : Affichage et gestion des relevés
    ///    - GestionnaireDonnees.cs : Sauvegarde JSON
    /// ═══════════════════════════════════════════════════════════════════
    /// </summary>
    public class ReleveChauffage
    {
        // ═══════════════════════════════════════════════════════════════
        // 📊 PROPRIÉTÉS DU RELEVÉ
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Identifiant unique du relevé
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date du relevé de chauffage
        /// </summary>
        public DateTime DateReleve { get; set; }

        /// <summary>
        /// Type de chauffage : "Gaz", "Bois", "Électrique", "Fioul"
        /// 
        /// 📌 Valeurs possibles :
        ///    • "Gaz" : Chauffage au gaz naturel
        ///    • "Bois" : Chauffage au bois (bûches, pellets)
        ///    • "Électrique" : Chauffage électrique
        ///    • "Fioul" : Chauffage au fioul domestique
        /// </summary>
        public string TypeChauffage { get; set; }

        /// <summary>
        /// Index du compteur (pour Gaz et Électrique)
        /// 
        /// 📌 Utilisé pour :
        ///    • Gaz : Index du compteur en m³
        ///    • Électrique : Index du compteur en kWh
        ///    • Bois/Fioul : Non utilisé (= 0)
        /// </summary>
        public double IndexCompteur { get; set; }

        /// <summary>
        /// Quantité livrée ou consommée (pour Bois et Fioul)
        /// 
        /// 📌 Utilisé pour :
        ///    • Bois : Quantité en stères ou kg
        ///    • Fioul : Quantité livrée en litres
        ///    • Gaz/Électrique : Calculé automatiquement
        /// </summary>
        public double Quantite { get; set; }

        /// <summary>
        /// Unité de mesure : "m³", "kWh", "Stère", "kg", "L"
        /// 
        /// 📌 Par type de chauffage :
        ///    • Gaz : "m³" (mètre cube)
        ///    • Électrique : "kWh" (kilowatt-heure)
        ///    • Bois : "Stère" ou "kg" (kilogramme)
        ///    • Fioul : "L" (litre)
        /// </summary>
        public string Unite { get; set; }

        /// <summary>
        /// Consommation totale calculée
        /// 
        /// 📌 Calcul :
        ///    • Gaz/Électrique : Différence entre index actuel et précédent
        ///    • Bois/Fioul : Égal à la quantité livrée
        /// </summary>
        public double Consommation { get; set; }

        /// <summary>
        /// Montant estimé en euros (basé sur le prix unitaire)
        /// 
        /// 📌 Calcul :
        ///    MontantEstime = Consommation × PrixUnitaire
        /// </summary>
        public double MontantEstime { get; set; }

        /// <summary>
        /// Notes ou observations sur le relevé (optionnel)
        /// 
        /// 📌 Exemples :
        ///    • "Livraison de 500L de fioul"
        ///    • "Hiver rigoureux, consommation élevée"
        ///    • "Réglage chaudière effectué"
        /// </summary>
        public string Notes { get; set; }

        // ═══════════════════════════════════════════════════════════════
        // 🏗️ CONSTRUCTEUR PAR DÉFAUT
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Constructeur par défaut
        /// Initialise les valeurs par défaut du relevé
        /// </summary>
        public ReleveChauffage()
        {
            // Valeurs par défaut
            DateReleve = DateTime.Now;
            TypeChauffage = "Gaz";  // Type par défaut
            IndexCompteur = 0;
            Quantite = 0;
            Unite = "m³";  // Unité par défaut (correspond au Gaz)
            Consommation = 0;
            MontantEstime = 0;
            Notes = string.Empty;
        }

        // ═══════════════════════════════════════════════════════════════
        // 🔢 MÉTHODE : CALCULER CONSOMMATION (GAZ / ÉLECTRIQUE)
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Calcule la consommation par rapport au relevé précédent
        /// (Pour chauffage Gaz ou Électrique avec compteur)
        /// 
        /// 📝 PARAMÈTRES :
        ///    - relevePrecedent : Le relevé précédent du même type
        ///    - prixUnitaire : Prix par unité (€/m³ ou €/kWh)
        /// 
        /// 🔄 PROCESSUS :
        ///    1️⃣ Vérifie qu'un relevé précédent existe
        ///    2️⃣ Calcule : Consommation = IndexActuel - IndexPrécédent
        ///    3️⃣ Calcule : MontantEstime = Consommation × PrixUnitaire
        /// 
        /// ⚠️ IMPORTANT :
        ///    Cette méthode est utilisée uniquement pour Gaz et Électrique.
        ///    Pour Bois et Fioul, utiliser CalculerConsommationLivraison().
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    ReleveChauffage releve = new ReleveChauffage();
        ///    releve.TypeChauffage = "Gaz";
        ///    releve.IndexCompteur = 15234.5;
        ///    releve.CalculerConsommation(relevePrecedent, 0.85);
        ///    // Résultat : Consommation = 15234.5 - 15100.0 = 134.5 m³
        ///    //            MontantEstime = 134.5 × 0.85 = 114.33 €
        /// </summary>
        public void CalculerConsommation(ReleveChauffage relevePrecedent, double prixUnitaire)
        {
            if (relevePrecedent != null &&
                relevePrecedent.TypeChauffage == this.TypeChauffage)
            {
                // ─────────────────────────────────────────────────────────
                // Calcul de la consommation : Différence d'index
                // ─────────────────────────────────────────────────────────
                Consommation = IndexCompteur - relevePrecedent.IndexCompteur;

                // Sécurité : La consommation ne peut pas être négative
                if (Consommation < 0)
                {
                    Consommation = 0;
                }

                // ─────────────────────────────────────────────────────────
                // Calcul du montant estimé
                // ─────────────────────────────────────────────────────────
                MontantEstime = Consommation * prixUnitaire;

                // Pour l'affichage, on copie la consommation dans Quantite
                Quantite = Consommation;
            }
            else
            {
                // ─────────────────────────────────────────────────────────
                // Premier relevé : pas de consommation à calculer
                // ─────────────────────────────────────────────────────────
                Consommation = 0;
                MontantEstime = 0;
                Quantite = 0;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 📦 MÉTHODE : CALCULER CONSOMMATION (BOIS / FIOUL - LIVRAISON)
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Calcule le coût d'une livraison de chauffage
        /// (Pour Bois ou Fioul livrés par quantité)
        /// 
        /// 📝 PARAMÈTRES :
        ///    - quantiteLivree : Quantité livrée (stères, kg, litres)
        ///    - prixUnitaire : Prix par unité (€/stère, €/kg, €/L)
        /// 
        /// 🔄 PROCESSUS :
        ///    1️⃣ Enregistre la quantité livrée
        ///    2️⃣ Consommation = Quantité livrée
        ///    3️⃣ Calcule : MontantEstime = Quantité × PrixUnitaire
        /// 
        /// ⚠️ IMPORTANT :
        ///    Cette méthode est utilisée uniquement pour Bois et Fioul.
        ///    Pour Gaz et Électrique, utiliser CalculerConsommation().
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    ReleveChauffage releve = new ReleveChauffage();
        ///    releve.TypeChauffage = "Fioul";
        ///    releve.Unite = "L";
        ///    releve.CalculerConsommationLivraison(500, 1.20);
        ///    // Résultat : Quantite = 500 L
        ///    //            Consommation = 500 L
        ///    //            MontantEstime = 500 × 1.20 = 600.00 €
        /// </summary>
        public void CalculerConsommationLivraison(double quantiteLivree, double prixUnitaire)
        {
            // ─────────────────────────────────────────────────────────
            // Enregistrement de la quantité livrée
            // ─────────────────────────────────────────────────────────
            Quantite = quantiteLivree;

            // ─────────────────────────────────────────────────────────
            // Pour une livraison, la consommation = quantité livrée
            // ─────────────────────────────────────────────────────────
            Consommation = quantiteLivree;

            // ─────────────────────────────────────────────────────────
            // Calcul du montant total de la livraison
            // ─────────────────────────────────────────────────────────
            MontantEstime = quantiteLivree * prixUnitaire;

            // Pour une livraison, l'index n'est pas utilisé
            IndexCompteur = 0;
        }

        // ═══════════════════════════════════════════════════════════════
        // 🔧 MÉTHODE HELPER : DÉFINIR LE TYPE DE CHAUFFAGE
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Définit le type de chauffage et configure l'unité correspondante
        /// 
        /// 📝 PARAMÈTRES :
        ///    - typeChauffage : "Gaz", "Bois", "Électrique", "Fioul"
        /// 
        /// 🔄 PROCESSUS :
        ///    Configure automatiquement l'unité selon le type :
        ///    • Gaz → "m³"
        ///    • Électrique → "kWh"
        ///    • Bois → "Stère"
        ///    • Fioul → "L"
        /// 
        /// 📌 EXEMPLE D'UTILISATION :
        ///    ReleveChauffage releve = new ReleveChauffage();
        ///    releve.DefinirTypeChauffage("Fioul");
        ///    // Résultat : TypeChauffage = "Fioul", Unite = "L"
        /// </summary>
        public void DefinirTypeChauffage(string typeChauffage)
        {
            TypeChauffage = typeChauffage;

            // Configuration automatique de l'unité selon le type
            switch (typeChauffage)
            {
                case "Gaz":
                    Unite = "m³";
                    break;

                case "Électrique":
                    Unite = "kWh";
                    break;

                case "Bois":
                    Unite = "Stère";  // Peut être changé en "kg" si besoin
                    break;

                case "Fioul":
                    Unite = "L";
                    break;

                default:
                    Unite = "Unité";  // Fallback
                    break;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // 📊 MÉTHODE HELPER : OBTENIR UN RÉSUMÉ DU RELEVÉ
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Retourne un résumé textuel du relevé
        /// 
        /// 🔙 RETOUR :
        ///    Chaîne formatée avec les informations principales
        /// 
        /// 📌 EXEMPLE DE RETOUR :
        ///    "Gaz - 24/01/2026 : 134.5 m³ (114.33 €)"
        ///    "Fioul - 15/12/2025 : 500.0 L (600.00 €)"
        /// </summary>
        public override string ToString()
        {
            return $"{TypeChauffage} - {DateReleve:dd/MM/yyyy} : " +
                   $"{Consommation:F1} {Unite} ({MontantEstime:F2} €)";
        }
    }
}
