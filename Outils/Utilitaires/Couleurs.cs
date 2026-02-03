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

using System.Windows.Media;

namespace GestionnaireDeLogement.Utilitaires
{
    /*
     * ╔═══════════════════════════════════════════════════════════════════════════════════════
     * ║  🎨 GESTIONNAIRE DE LOGEMENT - PALETTE DE COULEURS COMPLÈTE V2.0 (C#)                
     * ╠═══════════════════════════════════════════════════════════════════════════════════════
     * ║  📌 Ce fichier contient TOUTES les couleurs en format HEX pour usage dans le C#      
     * ║  📌 Synchronisé avec : Styles/Couleurs.xaml                                           
     * ║  📌 Documentation intégrée : Chaque couleur indique où elle est utilisée             
     * ║  📌 Pour changer une couleur : modifier ici + dans Couleurs.xaml                     
     * ╠═══════════════════════════════════════════════════════════════════════════════════════
     * ║  🔧 UTILISATION :                                                                     
     * ║     using GestionnaireDeLogement.Utilitaires;                                         
     * ║                                                                                       
     * ║     // Méthode 1 : Helper intégré (RECOMMANDÉ)                                       
     * ║     var brush = Couleurs.VersBrush(Couleurs.CouleurPrincipale);                      
     * ║     monBouton.Background = brush;                                                     
     * ║                                                                                       
     * ║     // Méthode 2 : Conversion manuelle                                               
     * ║     var couleur = (Color)ColorConverter.ConvertFromString(Couleurs.CouleurPrincipale);
     * ║     var brush = new SolidColorBrush(couleur);                                         
     * ╠═══════════════════════════════════════════════════════════════════════════════════════
     * ║  👤 Développeur : Latury (latury57@gmail.com)                                         
     * ║  📅 Dernière mise à jour : 24/01/2026 01:20 AM                                       
     * ║  🔢 Version : 2.0                                                                     
     * ║  📊 Total couleurs : 120+                                                             
     * ╚═══════════════════════════════════════════════════════════════════════════════════════
     */

    /// <summary>
    /// ═══════════════════════════════════════════════════════════════════════════════════════
    /// 🎨 CLASSE COULEURS - CODES HEX POUR USAGE C#
    /// ═══════════════════════════════════════════════════════════════════════════════════════
    /// Cette classe contient toutes les couleurs de l'application en format hexadécimal.
    /// 
    /// 📌 Pourquoi une classe statique ?
    ///    - Accessible partout sans instanciation : Couleurs.CouleurPrincipale
    ///    - Centralisation : changer une couleur = changer 1 seule ligne
    ///    - IntelliSense : autocomplétion de toutes les couleurs
    /// 
    /// 📌 Synchronisation avec Couleurs.xaml :
    ///    Chaque couleur ici a son équivalent dans Styles/Couleurs.xaml
    ///    Exemple : CouleurPrincipale = "#3B82F6" ↔ &lt;SolidColorBrush x:Key="CouleurPrincipale" Color="#3B82F6" /&gt;
    /// 
    /// 📌 Utilisation recommandée :
    ///    var brush = Couleurs.VersBrush(Couleurs.CouleurPrincipale);
    ///    monBouton.Background = brush;
    /// ═══════════════════════════════════════════════════════════════════════════════════════
    /// </summary>
    public static class Couleurs
    {
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🔵 COULEURS PRINCIPALES (BLEU)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé dans :
        //    • MainWindow.xaml : Bouton de menu actif
        //    • AccueilVue.xaml : Boutons d'action
        //    • FacturesVue.xaml : Bouton "Ajouter facture"
        //    • StatistiquesVue.xaml : Graphiques série 1
        //    • ParametresVue.xaml : Bouton "Enregistrer"
        //    • Tous les boutons principaux de l'application
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 🔵 Bleu principal de l'application (#3B82F6)
        /// <para>📄 Utilisé dans : MainWindow (bouton actif), AccueilVue, FacturesVue (bouton ajouter)</para>
        /// <para>📄 Aussi : StatistiquesVue (série 1), ParametresVue (bouton enregistrer)</para>
        /// </summary>
        public const string CouleurPrincipale = "#3B82F6";

        /// <summary>
        /// 🔵 Bleu principal foncé (#2563EB)
        /// <para>📄 Utilisé pour : Survol des boutons principaux</para>
        /// </summary>
        public const string CouleurPrincipaleFoncee = "#2563EB";

        /// <summary>
        /// 🔵 Bleu principal clair (#60A5FA)
        /// <para>📄 Utilisé pour : Variante claire pour graphiques</para>
        /// </summary>
        public const string CouleurPrincipaleClaire = "#60A5FA";

        /// <summary>
        /// 🔵 Bleu principal très clair (#DBEAFE)
        /// <para>📄 Utilisé pour : Fonds colorés légers</para>
        /// </summary>
        public const string CouleurPrincipaleTresClaire = "#DBEAFE";

        /// <summary>
        /// 🔵 Bleu information (#1976D2)
        /// <para>📄 Utilisé pour : Messages d'information</para>
        /// </summary>
        public const string CouleurPrincipaleInfo = "#1976D2";

        /// <summary>
        /// 🔵 Fond bleu information clair (#E3F2FD)
        /// <para>📄 Utilisé pour : Arrière-plan des zones d'information</para>
        /// </summary>
        public const string FondInfoClaire = "#E3F2FD";

        // Alias pour compatibilité avec ancien code
        public const string BleuPrincipal = "#3B82F6";
        public const string BleuFonce = "#2563EB";
        public const string BleuClair = "#60A5FA";
        public const string BleuTresClair = "#DBEAFE";
        public const string BleuInfo = "#1976D2";
        public const string FondBleuClair = "#E3F2FD";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ✅ COULEURS DE SUCCÈS (VERT)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé dans :
        //    • FacturesVue.xaml : Badge "Payée", statut positif
        //    • AccueilVue.xaml : Économies, augmentations positives
        //    • ParametresVue.xaml : Toggle activé (ON)
        //    • StatistiquesVue.xaml : Graphiques série 2
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ✅ Vert succès principal (#10B981)
        /// <para>📄 FacturesVue : Badge "Payée" (ligne 250)</para>
        /// <para>📄 AccueilVue : Économies, statistiques positives</para>
        /// <para>📄 ParametresVue : Toggle activé</para>
        /// </summary>
        public const string CouleurSucces = "#10B981";

        /// <summary>
        /// ✅ Vert succès foncé (#059669)
        /// <para>📄 Utilisé pour : Survol des boutons de validation</para>
        /// </summary>
        public const string CouleurSuccesFoncee = "#059669";

        /// <summary>
        /// ✅ Vert succès clair (#34D399)
        /// <para>📄 Utilisé pour : Variante claire</para>
        /// </summary>
        public const string CouleurSuccesClaire = "#34D399";

        /// <summary>
        /// ✅ Vert succès moyen (#4CAF50)
        /// <para>📄 Utilisé pour : Alternative pour succès</para>
        /// </summary>
        public const string CouleurSuccesMoyenne = "#4CAF50";

        /// <summary>
        /// ✅ Vert succès sombre (#388E3C)
        /// <para>📄 Utilisé pour : Texte sur fond vert clair</para>
        /// </summary>
        public const string CouleurSuccesSombre = "#388E3C";

        /// <summary>
        /// ✅ Fond vert clair (#E8F5E9)
        /// <para>📄 Utilisé pour : Arrière-plan des messages de succès</para>
        /// </summary>
        public const string FondSuccesClaire = "#E8F5E9";

        // Alias pour compatibilité
        public const string Vert = "#10B981";
        public const string VertFonce = "#059669";
        public const string VertClair = "#34D399";
        public const string VertMoyen = "#4CAF50";
        public const string VertSombre = "#388E3C";
        public const string FondVertClair = "#E8F5E9";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ⚠️ COULEURS D'ALERTE (ORANGE/JAUNE)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé dans :
        //    • FacturesVue.xaml : Badge "Proche échéance"
        //    • Boutons de modification (✏️)
        //    • Messages d'avertissement
        //    • StatistiquesVue.xaml : Graphiques série 3
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ⚠️ Orange alerte principal (#F59E0B)
        /// <para>📄 FacturesVue : Badge "Proche échéance" (ligne 260)</para>
        /// <para>📄 Boutons : Modification (✏️)</para>
        /// </summary>
        public const string CouleurAlerte = "#F59E0B";

        /// <summary>
        /// ⚠️ Orange alerte foncé (#D97706)
        /// <para>📄 Utilisé pour : Survol des boutons d'alerte</para>
        /// </summary>
        public const string CouleurAlerteFoncee = "#D97706";

        /// <summary>
        /// ⚠️ Orange alerte clair (#FBBF24)
        /// <para>📄 Utilisé pour : Variante claire</para>
        /// </summary>
        public const string CouleurAlerteClaire = "#FBBF24";

        /// <summary>
        /// ⚠️ Orange alerte moyen (#FF9800)
        /// <para>📄 Utilisé pour : Alternative pour alertes</para>
        /// </summary>
        public const string CouleurAlerteMoyenne = "#FF9800";

        /// <summary>
        /// ⚠️ Orange alerte sombre (#F57C00)
        /// <para>📄 Utilisé pour : Texte sur fond orange clair</para>
        /// </summary>
        public const string CouleurAlerteSombre = "#F57C00";

        /// <summary>
        /// ⚠️ Fond orange clair (#FFF3E0)
        /// <para>📄 Utilisé pour : Arrière-plan des avertissements</para>
        /// </summary>
        public const string FondAlerteClaire = "#FFF3E0";

        // Alias pour compatibilité
        public const string Orange = "#F59E0B";
        public const string OrangeFonce = "#D97706";
        public const string OrangeClair = "#FBBF24";
        public const string OrangeMoyen = "#FF9800";
        public const string OrangeSombre = "#F57C00";
        public const string FondOrangeClair = "#FFF3E0";

        /// <summary>
        /// ⚠️ Jaune avertissement (#FFC107)
        /// <para>📄 Utilisé pour : Avertissements moins critiques</para>
        /// </summary>
        public const string CouleurAvertissement = "#FFC107";

        /// <summary>
        /// ⚠️ Jaune avertissement sombre (#F9A825)
        /// <para>📄 Utilisé pour : Texte sur fond jaune</para>
        /// </summary>
        public const string CouleurAvertissementSombre = "#F9A825";

        /// <summary>
        /// ⚠️ Fond jaune clair (#FFFDE7)
        /// <para>📄 Utilisé pour : Arrière-plan des avertissements légers</para>
        /// </summary>
        public const string FondAvertissementClaire = "#FFFDE7";

        // Alias pour compatibilité
        public const string Jaune = "#FFC107";
        public const string JauneSombre = "#F9A825";
        public const string FondJauneClair = "#FFFDE7";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ❌ COULEURS D'ERREUR / URGENCE (ROUGE)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé dans :
        //    • FacturesVue.xaml : Badge "Impayée", statut négatif
        //    • AccueilVue.xaml : Total dépenses (montant négatif)
        //    • Boutons de suppression (🗑️)
        //    • ParametresVue.xaml : Bouton "Réinitialiser"
        //    • Messages d'erreur critique
        //    • StatistiquesVue.xaml : Graphiques série 4
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ❌ Rouge erreur principal (#EF4444)
        /// <para>📄 FacturesVue : Badge "Impayée" (ligne 240)</para>
        /// <para>📄 AccueilVue : Total dépenses (rouge)</para>
        /// <para>📄 Boutons : Suppression (🗑️)</para>
        /// </summary>
        public const string CouleurErreur = "#EF4444";

        /// <summary>
        /// ❌ Rouge erreur foncé (#DC2626)
        /// <para>📄 Utilisé pour : Survol des boutons d'erreur</para>
        /// </summary>
        public const string CouleurErreurFoncee = "#DC2626";

        /// <summary>
        /// ❌ Rouge erreur clair (#F87171)
        /// <para>📄 Utilisé pour : Variante claire</para>
        /// </summary>
        public const string CouleurErreurClaire = "#F87171";

        /// <summary>
        /// ❌ Rouge urgence (#D32F2F)
        /// <para>📄 Utilisé pour : Situations critiques</para>
        /// </summary>
        public const string CouleurUrgence = "#D32F2F";

        /// <summary>
        /// ❌ Rouge urgence moyen (#C62828)
        /// <para>📄 Utilisé pour : Alternative urgence</para>
        /// </summary>
        public const string CouleurUrgenceMoyenne = "#C62828";

        /// <summary>
        /// ❌ Fond rouge clair (#FFEBEE)
        /// <para>📄 Utilisé pour : Arrière-plan des messages d'erreur</para>
        /// </summary>
        public const string FondUrgenceClaire = "#FFEBEE";

        // Alias pour compatibilité
        public const string Rouge = "#EF4444";
        public const string RougeFonce = "#DC2626";
        public const string RougeClair = "#F87171";
        public const string RougeUrgent = "#D32F2F";
        public const string RougeUrgentMoyen = "#C62828";
        public const string FondRougeClair = "#FFEBEE";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ⚫ COULEURS NEUTRES (GRIS) - UTILISÉES PARTOUT
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé dans : Tous les fichiers pour fonds, bordures, textes secondaires
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ⚫ Gris très clair 50 (#F9FAFB)
        /// <para>📄 MainWindow : Fond fenêtre</para>
        /// <para>📄 Toutes les pages : Fond secondaire</para>
        /// </summary>
        public const string Gris50 = "#F9FAFB";

        /// <summary>
        /// ⚫ Gris très clair 100 (#F3F4F6)
        /// <para>📄 FacturesVue : Ligne alternée du tableau</para>
        /// </summary>
        public const string Gris100 = "#F3F4F6";

        /// <summary>
        /// ⚫ Gris très clair 150 (#F5F7FA)
        /// <para>📄 StatistiquesVue : Fond de page</para>
        /// <para>📄 AccueilVue : Fond des zones de statistiques</para>
        /// </summary>
        public const string Gris150 = "#F5F7FA";

        /// <summary>
        /// ⚫ Gris clair 200 (#E5E7EB)
        /// <para>📄 Toutes les pages : Bordures de cartes, séparateurs</para>
        /// </summary>
        public const string Gris200 = "#E5E7EB";

        /// <summary>
        /// ⚫ Gris clair 250 (#E0E0E0)
        /// <para>📄 Alternative pour bordures moyennes</para>
        /// </summary>
        public const string Gris250 = "#E0E0E0";

        /// <summary>
        /// ⚫ Gris 300 (#D1D5DB)
        /// <para>📄 Bordures moyennes, états désactivés</para>
        /// <para>📄 ParametresVue : Toggle désactivé (OFF)</para>
        /// </summary>
        public const string Gris300 = "#D1D5DB";

        /// <summary>
        /// ⚫ Gris 400 (#9CA3AF)
        /// <para>📄 Bouton "Annuler", icônes secondaires</para>
        /// </summary>
        public const string Gris400 = "#9CA3AF";

        /// <summary>
        /// ⚫ Gris moyen 500 (#6B7280)
        /// <para>📄 Toutes les pages : Texte secondaire, descriptions</para>
        /// </summary>
        public const string Gris500 = "#6B7280";

        /// <summary>
        /// ⚫ Gris foncé 600 (#4B5563)
        /// <para>📄 ParametresVue : En-tête et titre</para>
        /// </summary>
        public const string Gris600 = "#4B5563";

        /// <summary>
        /// ⚫ Gris foncé 700 (#374151)
        /// <para>📄 Texte sur fond clair</para>
        /// </summary>
        public const string Gris700 = "#374151";

        /// <summary>
        /// ⚫ Gris très foncé 800 (#1F2937)
        /// <para>📄 Texte très foncé</para>
        /// </summary>
        public const string Gris800 = "#1F2937";

        /// <summary>
        /// ⚫ Gris très foncé 900 (#111827)
        /// <para>📄 Toutes les pages : Titres principaux (TextePrincipal)</para>
        /// </summary>
        public const string Gris900 = "#111827";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 💧 PAGE EAU (EauVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé pour : Relevés de consommation d'eau
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 💧 Cyan eau principal (#06B6D4)
        /// <para>📄 EauVue : En-tête (emoji 💧 + titre), graphique, boutons</para>
        /// <para>📄 FacturesVue : Badge type "Eau"</para>
        /// </summary>
        public const string CouleurEau = "#06B6D4";

        /// <summary>
        /// 💧 Cyan eau foncé (#0891B2)
        /// <para>📄 EauVue : Survol des boutons</para>
        /// </summary>
        public const string CouleurEauFoncee = "#0891B2";

        /// <summary>
        /// 💧 Cyan eau clair (#22D3EE)
        /// <para>📄 EauVue : Zone remplie du graphique</para>
        /// </summary>
        public const string CouleurEauClaire = "#22D3EE";

        /// <summary>
        /// 💧 Fond cyan clair (#CFFAFE)
        /// <para>📄 EauVue : Arrière-plan des icônes de statistiques</para>
        /// </summary>
        public const string FondEauClaire = "#CFFAFE";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ⚡ PAGE ÉLECTRICITÉ (ElectriciteVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé pour : Relevés de consommation électrique (HP/HC)
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ⚡ Jaune électricité principal (#FBBF24)
        /// <para>📄 ElectriciteVue : En-tête (emoji ⚡ + titre), graphique, boutons</para>
        /// <para>📄 FacturesVue : Badge type "Électricité"</para>
        /// <para>📄 ChauffageVue : Badge type "Électrique"</para>
        /// </summary>
        public const string CouleurElectricite = "#FBBF24";

        /// <summary>
        /// ⚡ Jaune électricité foncé (#F59E0B)
        /// <para>📄 ElectriciteVue : Heures Pleines (HP)</para>
        /// </summary>
        public const string CouleurElectriciteFoncee = "#F59E0B";

        /// <summary>
        /// ⚡ Jaune électricité clair (#FCD34D)
        /// <para>📄 ElectriciteVue : Heures Creuses (HC)</para>
        /// </summary>
        public const string CouleurElectriciteClaire = "#FCD34D";

        /// <summary>
        /// ⚡ Fond jaune clair (#FEF3C7)
        /// <para>📄 ElectriciteVue : Arrière-plan des icônes de statistiques</para>
        /// </summary>
        public const string FondElectriciteClaire = "#FEF3C7";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🔥 PAGE CHAUFFAGE (ChauffageVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé pour : Relevés de consommation chauffage (Gaz, Bois, Électrique, Fioul)
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 🔥 Orange chauffage principal (#F97316)
        /// <para>📄 ChauffageVue : En-tête (emoji 🔥 + titre), badge "Gaz"</para>
        /// <para>📄 FacturesVue : Badge type "Chauffage"</para>
        /// </summary>
        public const string CouleurChauffage = "#F97316";

        /// <summary>
        /// 🔥 Orange chauffage foncé (#EA580C)
        /// <para>📄 ChauffageVue : Survol des boutons</para>
        /// </summary>
        public const string CouleurChauffageFoncee = "#EA580C";

        /// <summary>
        /// 🔥 Orange chauffage clair (#FB923C)
        /// <para>📄 ChauffageVue : Zone remplie du graphique</para>
        /// </summary>
        public const string CouleurChauffageClaire = "#FB923C";

        /// <summary>
        /// 🔥 Orange vif chauffage (#FF6B35)
        /// <para>📄 ChauffageVue : Badge type "Fioul" (ligne 380)</para>
        /// </summary>
        public const string CouleurChauffageOrange = "#FF6B35";

        /// <summary>
        /// 🔥 Marron chauffage (#8B4513)
        /// <para>📄 ChauffageVue : Badge type "Bois" (ligne 370)</para>
        /// </summary>
        public const string CouleurChauffageMarron = "#8B4513";

        /// <summary>
        /// 🔥 Fond orange clair (#FFEDD5)
        /// <para>📄 ChauffageVue : Arrière-plan des icônes de statistiques</para>
        /// </summary>
        public const string FondChauffageClaire = "#FFEDD5";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🧾 PAGE FACTURES (FacturesVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé pour : Gestion des factures (Eau, Électricité, Chauffage, Autre)
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 🧾 Violet facture principal (#8B5CF6)
        /// <para>📄 FacturesVue : En-tête (emoji 🧾 + titre)</para>
        /// <para>📄 MainWindow : Bouton menu "Factures"</para>
        /// <para>📄 StatistiquesVue : Graphique série 5</para>
        /// </summary>
        public const string CouleurFacture = "#8B5CF6";

        /// <summary>
        /// 🧾 Violet facture foncé (#7C3AED)
        /// <para>📄 FacturesVue : Survol</para>
        /// </summary>
        public const string CouleurFactureFoncee = "#7C3AED";

        /// <summary>
        /// 🧾 Violet facture clair (#A78BFA)
        /// <para>📄 FacturesVue : Variante</para>
        /// </summary>
        public const string CouleurFactureClaire = "#A78BFA";

        /// <summary>
        /// 🧾 Fond violet clair (#EDE9FE)
        /// <para>📄 FacturesVue : Arrière-plan</para>
        /// </summary>
        public const string FondFactureClaire = "#EDE9FE";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 💳 PAGE ACHATS (AchatsVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Utilisé pour : Gestion des achats et dépenses
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 💳 Rose achat principal (#EC4899)
        /// <para>📄 AchatsVue : En-tête (emoji 💳 + titre), boutons</para>
        /// <para>📄 MainWindow : Bouton menu "Achats"</para>
        /// </summary>
        public const string CouleurAchat = "#EC4899";

        /// <summary>
        /// 💳 Rose achat foncé (#DB2777)
        /// <para>📄 AchatsVue : Survol</para>
        /// </summary>
        public const string CouleurAchatFoncee = "#DB2777";

        /// <summary>
        /// 💳 Rose achat clair (#F472B6)
        /// <para>📄 AchatsVue : Variante</para>
        /// </summary>
        public const string CouleurAchatClaire = "#F472B6";

        /// <summary>
        /// 💳 Fond rose clair (#FCE7F3)
        /// <para>📄 AchatsVue : Arrière-plan</para>
        /// </summary>
        public const string FondAchatClaire = "#FCE7F3";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📊 PAGE STATISTIQUES (StatistiquesVue.xaml)
        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📍 Palette de 5 couleurs pour graphiques et charts
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 📊 Graphique série 1 - Bleu (#3B82F6)
        /// <para>📄 StatistiquesVue : Première série de données (identique à CouleurPrincipale)</para>
        /// </summary>
        public const string CouleurStatistique1 = "#3B82F6";

        /// <summary>
        /// 📊 Graphique série 2 - Vert (#10B981)
        /// <para>📄 StatistiquesVue : Deuxième série de données (identique à CouleurSucces)</para>
        /// </summary>
        public const string CouleurStatistique2 = "#10B981";

        /// <summary>
        /// 📊 Graphique série 3 - Orange (#F59E0B)
        /// <para>📄 StatistiquesVue : Troisième série de données (identique à CouleurAlerte)</para>
        /// </summary>
        public const string CouleurStatistique3 = "#F59E0B";

        /// <summary>
        /// 📊 Graphique série 4 - Rouge (#EF4444)
        /// <para>📄 StatistiquesVue : Quatrième série de données (identique à CouleurErreur)</para>
        /// </summary>
        public const string CouleurStatistique4 = "#EF4444";

        /// <summary>
        /// 📊 Graphique série 5 - Violet (#8B5CF6)
        /// <para>📄 StatistiquesVue : Cinquième série de données (identique à CouleurFacture)</para>
        /// </summary>
        public const string CouleurStatistique5 = "#8B5CF6";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 📝 COULEURS DE FOND - UTILISÉES DANS TOUTES LES PAGES
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 📝 Fond principal blanc (#FFFFFF)
        /// <para>📄 MainWindow, AccueilVue, FacturesVue, etc. : Fond blanc pur</para>
        /// </summary>
        public const string FondPrincipal = "#FFFFFF";

        /// <summary>
        /// 📝 Fond secondaire gris très clair (#F9FAFB)
        /// <para>📄 Toutes les pages : Fond général de page (Gris50)</para>
        /// </summary>
        public const string FondSecondaire = "#F9FAFB";

        /// <summary>
        /// 📝 Fond carte blanc (#FFFFFF)
        /// <para>📄 AccueilVue, FacturesVue, EauVue, ElectriciteVue, ChauffageVue : Fond des cartes</para>
        /// </summary>
        public const string FondCarte = "#FFFFFF";

        /// <summary>
        /// 📝 Fond statistiques gris clair (#F5F7FA)
        /// <para>📄 AccueilVue, StatistiquesVue : Zones de statistiques (Gris150)</para>
        /// </summary>
        public const string FondStatistiques = "#F5F7FA";

        /// <summary>
        /// 📝 Fond fenêtre gris très clair (#F9FAFB)
        /// <para>📄 MainWindow : Fond de la fenêtre principale (Gris50)</para>
        /// </summary>
        public const string FondFenetre = "#F9FAFB";

        /// <summary>
        /// 📝 Fond menu blanc (#FFFFFF)
        /// <para>📄 MainWindow : Fond du menu de navigation latéral</para>
        /// </summary>
        public const string FondMenu = "#FFFFFF";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // ✍️ COULEURS DE TEXTE - UTILISÉES DANS TOUTES LES PAGES
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// ✍️ Texte principal noir (#111827)
        /// <para>📄 Toutes les pages : Titres principaux (Gris900)</para>
        /// </summary>
        public const string TextePrincipal = "#111827";

        /// <summary>
        /// ✍️ Texte secondaire gris (#6B7280)
        /// <para>📄 Toutes les pages : Sous-titres, descriptions (Gris500)</para>
        /// </summary>
        public const string TexteSecondaire = "#6B7280";

        /// <summary>
        /// ✍️ Texte clair gris (#9CA3AF)
        /// <para>📄 Toutes les pages : Placeholders, texte désactivé (Gris400)</para>
        /// </summary>
        public const string TexteClair = "#9CA3AF";

        /// <summary>
        /// ✍️ Texte blanc (#FFFFFF)
        /// <para>📄 Boutons colorés : Texte blanc sur fond coloré</para>
        /// </summary>
        public const string TexteBlanc = "#FFFFFF";

        /// <summary>
        /// ✍️ Texte noir pur (#000000)
        /// <para>📄 Rarement utilisé</para>
        /// </summary>
        public const string TexteNoir = "#000000";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🔲 COULEURS DE BORDURE - UTILISÉES PARTOUT
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 🔲 Bordure claire (#E5E7EB)
        /// <para>📄 AccueilVue, FacturesVue : Bordures de cartes (Gris200)</para>
        /// </summary>
        public const string BordureClaire = "#E5E7EB";

        /// <summary>
        /// 🔲 Bordure moyenne (#D1D5DB)
        /// <para>📄 Inputs, ComboBox : Bordures moyennes (Gris300)</para>
        /// </summary>
        public const string BordureMoyenne = "#D1D5DB";

        /// <summary>
        /// 🔲 Bordure foncée (#9CA3AF)
        /// <para>📄 Éléments actifs : Bordures foncées (Gris400)</para>
        /// </summary>
        public const string BordureFoncee = "#9CA3AF";

        /// <summary>
        /// 🔲 Bordure principale bleue (#3B82F6)
        /// <para>📄 Focus : Bordure bleue pour éléments en focus</para>
        /// </summary>
        public const string BordurePrincipale = "#3B82F6";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🎭 COULEURS SPÉCIALES & EFFETS
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// 🎭 Ombre noire (#000000)
        /// <para>📄 Ombre portée des cartes (DropShadow)</para>
        /// </summary>
        public const string OmbreNoire = "#000000";

        /// <summary>
        /// 🎭 Ombre grise (#666666)
        /// <para>📄 Ombre douce alternative</para>
        /// </summary>
        public const string OmbreGrise = "#666666";

        /// <summary>
        /// 🎭 Transparent (Transparent)
        /// <para>📄 Transparence totale</para>
        /// </summary>
        public const string Transparent = "Transparent";

        /// <summary>
        /// 🎭 Semi-transparent noir (#80000000)
        /// <para>📄 Overlay noir 50% d'opacité</para>
        /// </summary>
        public const string SemiTransparentNoir = "#80000000";

        /// <summary>
        /// 🎭 Semi-transparent blanc (#80FFFFFF)
        /// <para>📄 Highlight blanc 50% d'opacité</para>
        /// </summary>
        public const string SemiTransparentBlanc = "#80FFFFFF";

        // ═══════════════════════════════════════════════════════════════════════════════════
        // 🔧 MÉTHODES HELPER - Conversion rapide vers Color/Brush WPF
        // ═══════════════════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Convertit un code couleur hexadécimal en Color WPF
        /// </summary>
        /// <param name="hexColor">Code couleur hex (ex: "#3B82F6")</param>
        /// <returns>Couleur WPF</returns>
        /// <example>
        /// <code>
        /// var couleur = Couleurs.VersColor(Couleurs.CouleurPrincipale);
        /// </code>
        /// </example>
        public static Color VersColor(string hexColor)
        {
            try
            {
                return (Color)ColorConverter.ConvertFromString(hexColor);
            }
            catch
            {
                // En cas d'erreur, retourner blanc
                return Colors.White;
            }
        }

        /// <summary>
        /// Convertit un code couleur hexadécimal en SolidColorBrush WPF
        /// </summary>
        /// <param name="hexColor">Code couleur hex (ex: "#3B82F6")</param>
        /// <returns>SolidColorBrush WPF</returns>
        /// <example>
        /// <code>
        /// var brush = Couleurs.VersBrush(Couleurs.CouleurPrincipale);
        /// monBouton.Background = brush;
        /// </code>
        /// </example>
        public static SolidColorBrush VersBrush(string hexColor)
        {
            return new SolidColorBrush(VersColor(hexColor));
        }
    }
}
