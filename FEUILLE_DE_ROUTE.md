# 🗺️ Feuille de Route - Gestionnaire Logement

## 📌 Vision du Projet

**Objectif** : Créer un gestionnaire complet de logement pour suivre les factures, relevés et achats.

**Versions planifiées** : 1.0 → 2.0 → 3.0

---

## 🎯 Version 1.0.0 - Fondations (Janvier 2026)

**Statut** : ✅ **COMPLÉTÉ** (21/01/2026)

**Objectif** : Créer la base du projet avec interface et modèles de données

### 🏗️ Infrastructure de base
- 🟢 Structure du projet
- 🟢 Système de sauvegarde JSON (GestionnaireDonnees)
- 🟢 Architecture des dossiers
- 🟢 Dictionnaire de couleurs centralisé
- 🟢 Fichiers de documentation (README, LICENSE, etc.)
- 🟢 Configuration Git (.gitignore)
- 🟢 App.xaml avec import global des couleurs
- 🟢 MainWindow.xaml avec menu de navigation
- 🟢 MainWindow.xaml.cs avec gestion des événements

### 💾 Modèles de données
- 🟢 Facture.cs
- 🟢 ReleveEau.cs
- 🟢 ReleveElectricite.cs
- ⚪ AchatEchelonne.cs
- ⚪ Logement.cs
- ⚪ Paiement.cs

### 📄 Pages de base
- 🟢 MainWindow.xaml (fenêtre principale avec navigation)
- ⚪ AccueilVue.xaml (tableau de bord)
- ⚪ FacturesVue.xaml (liste des factures)
- ⚪ AjouterFactureVue.xaml (formulaire d'ajout)

### 🎨 Design
- 🟢 Palette de couleurs complète
- 🟢 Styles de boutons
- ⚪ Styles de formulaires
- ⚪ Styles de cartes

**Date de livraison** : ✅ 21 Janvier 2026

---

## 🎯 Version 1.0.1 - CRUD Factures (Février 2026)

**Statut** : ⚪ **À FAIRE**

**Objectif** : Implémenter la gestion complète des factures

### ✅ Fonctionnalités CRUD
- ⚪ **C**reate : Ajouter une facture
- ⚪ **R**ead : Afficher la liste des factures
- ⚪ **U**pdate : Modifier une facture existante
- ⚪ **D**elete : Supprimer une facture (avec confirmation)

### 📄 Pages à créer
- ⚪ AccueilVue.xaml (tableau de bord avec statistiques)
- ⚪ FacturesVue.xaml (liste complète + filtres)
- ⚪ AjouterFactureVue.xaml (formulaire d'ajout)
- ⚪ ModifierFactureVue.xaml (formulaire de modification)

### 🔧 Fonctionnalités techniques
- ⚪ Validation des champs de formulaire
- ⚪ Messages de confirmation (MessageBox)
- ⚪ Filtrage par type de facture (Eau/Électricité/Chauffage/Toutes)
- ⚪ Tri par date/montant
- ⚪ Recherche par notes

### 📊 Statistiques de base
- ⚪ Total des factures payées
- ⚪ Total des factures impayées
- ⚪ Montant total dépensé ce mois
- ⚪ Liste des 5 dernières factures

**Date de livraison prévue** : 15 Février 2026

---

## 🎯 Version 1.0.2 - Gestion Eau (Février 2026)

**Statut** : ⚪ **À FAIRE**

**Objectif** : Implémenter la gestion de l'eau

### 📄 Pages
- ⚪ EauVue.xaml (liste des relevés)
- ⚪ AjouterReleveEauVue.xaml (formulaire)

### ✅ Fonctionnalités
- ⚪ Ajouter un relevé d'eau (froide + chaude)
- ⚪ Calcul automatique de la consommation
- ⚪ Estimation du montant
- ⚪ Graphique d'évolution de la consommation
- ⚪ Historique des relevés

**Date de livraison prévue** : 28 Février 2026

---

## 🎯 Version 1.0.3 - Gestion Électricité (Mars 2026)

**Statut** : ⚪ **À FAIRE**

**Objectif** : Implémenter la gestion de l'électricité

### 📄 Pages
- ⚪ ElectriciteVue.xaml (liste des relevés)
- ⚪ AjouterReleveElectriciteVue.xaml (formulaire)

### ✅ Fonctionnalités
- ⚪ Ajouter un relevé d'électricité (HC + HP)
- ⚪ Calcul automatique avec tarifs différenciés
- ⚪ Estimation du montant
- ⚪ Graphique d'évolution
- ⚪ Comparaison HC vs HP

**Date de livraison prévue** : 15 Mars 2026

---

## 🎯 Version 1.1.0 - Fonctionnalités Avancées (Mars-Avril 2026)

**Statut** : ⚪ **À FAIRE**

### 🔥 Gestion du chauffage
- ⚪ Page ChauffageVue.xaml
- ⚪ Suivi de la consommation de gaz/fioul/électrique

### 💳 Achats échelonnés
- ⚪ Page AchatsVue.xaml
- ⚪ Gestion des achats avec mensualités
- ⚪ Calcul des échéances
- ⚪ Notifications d'échéances proches

### 📊 Statistiques avancées
- ⚪ Graphiques interactifs (LiveCharts ou OxyPlot)
- ⚪ Comparaison mensuelle
- ⚪ Détection d'économies potentielles
- ⚪ Prévisions de consommation

### 🌙 Mode sombre
- ⚪ Thème clair/sombre
- ⚪ Sauvegarde de la préférence utilisateur

**Date de livraison prévue** : 30 Avril 2026

---

## 🎯 Version 2.0.0 - Export & Multi-logements (Mai-Juin 2026)

**Statut** : ⚪ **À FAIRE**

### 📤 Export de données
- ⚪ Export PDF (factures + statistiques)
- ⚪ Export Excel/CSV
- ⚪ Génération de rapports mensuels

### 📥 Import de données
- ⚪ Import CSV de factures
- ⚪ Import de relevés

### 🏘️ Multi-logements
- ⚪ Gestion de plusieurs logements
- ⚪ Comparaison entre logements
- ⚪ Statistiques par logement

### 💾 Backup automatique
- ⚪ Backup quotidien automatique
- ⚪ Restauration depuis backup

### 🎨 Personnalisation
- ⚪ Thèmes personnalisables
- ⚪ Choix des couleurs
- ⚪ Personnalisation des catégories

### 📦 Installation
- ⚪ Créer un installateur Windows (.msi)
- ⚪ Distribution sur Microsoft Store (optionnel)

**Date de livraison prévue** : 30 Juin 2026

---

## 🎯 Version 3.0.0 - Cloud & Mobile (Septembre 2026)

**Statut** : ⚪ **À FAIRE**

### ☁️ Synchronisation cloud
- ⚪ Intégration OneDrive
- ⚪ Intégration Google Drive
- ⚪ Intégration Dropbox
- ⚪ Synchronisation automatique

### 📱 Application mobile
- ⚪ Application mobile compagnon (Android)
- ⚪ Application mobile compagnon (iOS)
- ⚪ Scan de factures avec OCR
- ⚪ Notifications push pour échéances

### 🔄 Fonctionnalités avancées
- ⚪ Accès multi-appareils en temps réel
- ⚪ Partage de données entre utilisateurs
- ⚪ Mode collaboratif (famille/colocataires)

**Date de livraison prévue** : 30 Septembre 2026

---

## 📊 Suivi Global

### Statut des versions

| Version | Statut | Date prévue | Progression |
|---------|--------|-------------|-------------|
| 1.0.0 | ✅ Complété | 21/01/2026 | 100% |
| 1.0.1 | ⚪ À faire | 15/02/2026 | 0% |
| 1.0.2 | ⚪ À faire | 28/02/2026 | 0% |
| 1.0.3 | ⚪ À faire | 15/03/2026 | 0% |
| 1.1.0 | ⚪ À faire | 30/04/2026 | 0% |
| 2.0.0 | ⚪ À faire | 30/06/2026 | 0% |
| 3.0.0 | ⚪ À faire | 30/09/2026 | 0% |

### Légende
- 🟢 Fonctionnalité terminée
- 🔵 Fonctionnalité en cours
- ⚪ Fonctionnalité à faire
- 🔴 Fonctionnalité bloquée/annulée

---

## 🎓 Apprentissage Prévu

Au fil des versions, apprentissage de :
- ✅ WPF et XAML (Version 1.0)
- ✅ Architecture MVVM (Version 1.0)
- ⚪ Graphiques interactifs (Version 1.1)
- ⚪ Export PDF/Excel (Version 2.0)
- ⚪ Intégration cloud (Version 3.0)
- ⚪ Développement mobile Xamarin/MAUI (Version 3.0)

---

## 📝 Notes

- Cette feuille de route est **indicative** et peut évoluer
- Les dates sont des **objectifs**, pas des engagements stricts
- Les fonctionnalités peuvent être ajoutées/supprimées selon les besoins
- Ce projet est un **projet d'apprentissage** avant tout

---

**Dernière mise à jour** : 21 Janvier 2026  
**Auteur** : Latury (latury57@gmail.com)
