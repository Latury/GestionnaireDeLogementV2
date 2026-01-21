# 🗺️ Feuille de Route - Gestionnaire Logement

## 📌 Légende des statuts

- 🟢 **Terminé** : Fonctionnalité implémentée et testée
- 🟡 **En cours** : Développement actif
- 🔵 **Planifié** : Prochaine étape
- ⚪ **À faire** : Dans le backlog
- 🔴 **Bloqué** : Nécessite résolution de problème

---

## 🎯 Version 1.0.0 - MVP (Minimum Viable Product)

**Date cible** : Février 2026  
**Objectif** : Application fonctionnelle avec les bases

### 🏗️ Infrastructure de base
- 🟢 Structure du projet
- 🟢 Système de sauvegarde JSON (DataManager)
- 🟢 Architecture des dossiers
- 🟢 Dictionnaire de couleurs centralisé
- 🟢 Fichiers de documentation (README, LICENSE)
- 🟢 Configuration Git (.gitignore)

### 📄 Pages principales
- 🟡 Page Accueil (Tableau de bord)
- 🟡 Page Factures
- 🟡 Page Eau
- 🟡 Page Électricité
- ⚪ Page Chauffage
- ⚪ Page Achats Échelonnés
- ⚪ Page Paiements

### 💾 Modèles de données
- 🟢 Facture.cs
- 🟢 ReleveEau.cs
- 🟢 ReleveElectricite.cs
- ⚪ AchatEchelonne.cs
- ⚪ Logement.cs
- ⚪ Paiement.cs

### ⚙️ Fonctionnalités CRUD
- 🟡 Ajouter une facture
- 🟡 Modifier une facture
- 🟡 Supprimer une facture
- 🟡 Lister les factures
- ⚪ Ajouter un relevé d'eau
- ⚪ Modifier un relevé d'eau
- ⚪ Supprimer un relevé d'eau
- ⚪ Ajouter un relevé d'électricité
- ⚪ Modifier un relevé d'électricité
- ⚪ Supprimer un relevé d'électricité

---

## 🚀 Version 1.1.0 - Statistiques et Graphiques

**Date cible** : Mars 2026  
**Objectif** : Ajout de visualisations et analyses

### 📊 Graphiques
- ⚪ Graphique évolution consommation eau (ligne)
- ⚪ Graphique évolution consommation électricité (ligne)
- ⚪ Graphique évolution consommation chauffage (ligne)
- ⚪ Graphique répartition factures (camembert)
- ⚪ Graphique comparaison mensuelle (barres)

### 📈 Statistiques
- ⚪ Consommation moyenne mensuelle
- ⚪ Consommation totale annuelle
- ⚪ Coût moyen mensuel
- ⚪ Coût total annuel
- ⚪ Détection des pics de consommation
- ⚪ Calcul d'économies réalisées
- ⚪ Prévisions basées sur l'historique

### 🎨 Améliorations visuelles
- ⚪ Animations de transition entre pages
- ⚪ Indicateurs visuels (badges, barres de progression)
- ⚪ Icônes personnalisées pour chaque type de facture
- ⚪ Thème sombre (mode nuit)

---

## 💳 Version 1.2.0 - Achats Échelonnés Avancés

**Date cible** : Avril 2026  
**Objectif** : Gestion complète des crédits et achats en plusieurs fois

### 💰 Fonctionnalités achats
- ⚪ Ajouter un achat échelonné
- ⚪ Modifier un achat échelonné
- ⚪ Supprimer un achat échelonné
- ⚪ Marquer une mensualité comme payée
- ⚪ Calculer le montant restant
- ⚪ Calculer la prochaine échéance
- ⚪ Alertes d'échéances proches (7 jours)

### 📅 Calendrier de paiements
- ⚪ Vue calendrier avec toutes les échéances
- ⚪ Notifications de paiements à venir
- ⚪ Récapitulatif mensuel des paiements prévus

---

## 📱 Version 2.0.0 - Fonctionnalités Avancées

**Date cible** : Mai-Juin 2026  
**Objectif** : Application professionnelle complète

### 📤 Export et Import
- ⚪ Export PDF (factures, relevés, statistiques)
- ⚪ Export Excel (tableaux de données)
- ⚪ Export CSV (pour analyse externe)
- ⚪ Import CSV (données existantes)
- ⚪ Backup automatique quotidien
- ⚪ Restauration depuis backup

### 🔔 Notifications et Alertes
- ⚪ Alertes de paiements à venir
- ⚪ Alertes de consommation anormale
- ⚪ Rappels de relevés de compteur
- ⚪ Notifications Windows (toasts)

### 🔐 Sécurité
- ⚪ Mot de passe pour ouvrir l'application
- ⚪ Chiffrement des données sensibles
- ⚪ Sauvegarde cloud sécurisée (optionnelle)

### 🌐 Multi-logements
- ⚪ Gestion de plusieurs logements
- ⚪ Comparaison entre logements
- ⚪ Bascule rapide entre logements

---

## 🎨 Version 2.1.0 - Personnalisation

**Date cible** : Juillet 2026  
**Objectif** : Personnalisation complète de l'interface

### 🖌️ Thèmes
- ⚪ Thème clair (par défaut)
- ⚪ Thème sombre
- ⚪ Thème bleu
- ⚪ Thème vert
- ⚪ Thème personnalisé (choix des couleurs)

### ⚙️ Paramètres
- ⚪ Choix de la devise (€, $, £, CHF...)
- ⚪ Langue (FR, EN, DE, ES)
- ⚪ Format de date (JJ/MM/AAAA, MM/JJ/AAAA...)
- ⚪ Unités de mesure (m³, L, kWh...)

---

## 🌟 Version 3.0.0 - Synchronisation Cloud

**Date cible** : Septembre 2026  
**Objectif** : Accès multi-appareils

### ☁️ Cloud
- ⚪ Synchronisation avec OneDrive
- ⚪ Synchronisation avec Google Drive
- ⚪ Synchronisation avec Dropbox
- ⚪ Serveur personnel (auto-hébergement)

### 📱 Compagnon Mobile
- ⚪ Application Android
- ⚪ Application iOS
- ⚪ Synchronisation en temps réel

---

## 🐛 Bugs Connus

_Aucun bug connu pour le moment_

---

## 💡 Idées Futures (Backlog)

- ⚪ Intégration avec API de fournisseurs d'énergie
- ⚪ Détection automatique de relevés (OCR sur photos)
- ⚪ Suggestions d'économies basées sur IA
- ⚪ Communauté : comparaison avec autres utilisateurs
- ⚪ Gamification : badges, objectifs d'économies
- ⚪ Widget Windows pour affichage rapide
- ⚪ Commandes vocales (Cortana/Alexa)
- ⚪ Mode tablette tactile

---

## 📊 Priorités de développement

**P1 (Critique)** : Nécessaire pour MVP
**P2 (Important)** : Améliore significativement l'expérience
**P3 (Nice to have)** : Bonus apprécié
**P4 (Future)** : Vision à long terme

| Fonctionnalité | Priorité | Version |
|----------------|----------|---------|
| Structure de base | P1 | 1.0.0 |
| Gestion factures | P1 | 1.0.0 |
| Gestion eau/électricité | P1 | 1.0.0 |
| Graphiques | P2 | 1.1.0 |
| Achats échelonnés | P2 | 1.2.0 |
| Export PDF | P2 | 2.0.0 |
| Notifications | P3 | 2.0.0 |
| Thèmes | P3 | 2.1.0 |
| Cloud sync | P4 | 3.0.0 |

---

**Dernière mise à jour** : 21/01/2026
