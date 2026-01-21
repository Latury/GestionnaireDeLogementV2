# 📋 Historique des versions

Toutes les modifications notables de ce projet sont documentées ici.

Le format est basé sur [Keep a Changelog](https://keepachangelog.com/fr/1.0.0/).

---

## [1.0.0] - 2026-01-21

### ✨ Ajouté
- 🏠 Structure de base du projet WPF .NET 8.0
- 💾 Système de sauvegarde JSON (GestionnaireDonnees.cs)
- 🎨 Dictionnaire de couleurs centralisé (Couleurs.xaml)
- 📄 Documentation complète du projet :
  - README.md (présentation générale)
  - LICENSE.txt (licence MIT avec attribution)
  - CHANGELOG.md (historique des versions)
  - PATCH_NOTES.md (notes techniques détaillées)
  - FEUILLE_DE_ROUTE.md (roadmap versions 1.0 à 3.0)
  - GUIDE_GITHUB_DESKTOP.md (guide Git pour débutants)
  - EXEMPLES_COMMITS.md (conventions de commit)
- 🗂️ Architecture des dossiers en français :
  - Ressources/ (Icons, Emojis, Images)
  - Donnees/ (GestionnaireDonnees.cs)
  - Modeles/ (classes de données)
  - Vues/ (pages XAML + code-behind)
  - Styles/ (Couleurs.xaml, styles boutons et textes)
  - Utilitaires/ (Convertisseurs, Assistants)
  - Configurations/ (fichiers JSON ignorés par Git)
- 📦 Modèles de données complets :
  - Facture.cs (gestion des factures)
  - ReleveEau.cs (relevés eau avec calcul automatique)
  - ReleveElectricite.cs (relevés électricité HC/HP)
- 🪟 Interface principale (MainWindow) :
  - Menu de navigation latéral (8 boutons)
  - Frame pour affichage des pages
  - Gestion du bouton actif
  - En-tête centré dans le menu bleu
  - Barre de titre alignée (80px)
  - Effet hover sur les boutons
- ⚙️ App.xaml configuré avec import des couleurs globales

### 🔧 Configuration
- ⚙️ Projet WPF .NET 8.0 avec C# 12.0
- 📦 Structure de dossiers organisée en français
- 🚫 Fichier .gitignore configuré (ignore bin/, obj/, Configurations/)
- 🎨 Système de couleurs centralisé avec palette complète
- 🔐 Licence MIT avec attribution obligatoire

### 🎓 Apprentissage
- 📐 Maquettage de l'interface avec Draw.io
- 🤖 Utilisation d'IA pour l'assistance au code
- 📚 Documentation exhaustive pour faciliter l'apprentissage
- 🎯 Premier projet WPF d'un développeur débutant

---

## [Non publié] - À venir en version 1.0.1 (Février 2026)

### ✨ Prévu
- 📄 Pages de gestion :
  - AccueilVue.xaml (tableau de bord)
  - FacturesVue.xaml (gestion des factures)
  - EauVue.xaml (gestion de l'eau)
  - ElectriciteVue.xaml (gestion de l'électricité)
- ⚙️ Fonctionnalités CRUD complètes pour les factures
- 📊 Affichage des listes de données
- ➕ Formulaires d'ajout/modification
- 🗑️ Suppression avec confirmation
- 📝 Guide utilisateur simplifié (GUIDE_UTILISATEUR.md)
- ✅ Tests et stabilisation

---

## [Non publié] - À venir en version 1.1.0 (Mars 2026)

### ✨ Prévu
- 📊 Graphiques interactifs et statistiques avancées
- 🔥 Gestion du chauffage
- 💳 Achats échelonnés avec échéancier
- 🌙 Mode sombre (thème nuit)
- 📈 Comparaisons mensuelles et détection d'économies

---

## [Non publié] - À venir en version 2.0.0 (Mai-Juin 2026)

### ✨ Prévu
- 📤 Export PDF des factures et statistiques
- 📊 Export Excel/CSV pour analyse externe
- 📥 Import de données existantes
- 💾 Backup automatique quotidien
- 🏘️ Gestion multi-logements
- 🎨 Thèmes personnalisables
- 📦 Installateur Windows (.exe / .msi)

---

## [Non publié] - À venir en version 3.0.0 (Septembre 2026)

### ✨ Prévu
- ☁️ Synchronisation cloud (OneDrive, Google Drive, Dropbox)
- 📱 Application mobile compagnon (Android/iOS)
- 🔄 Accès multi-appareils en temps réel

---

## Notes

### Format des versions
- **X.Y.Z** : Version publiée avec date
- **Non publié** : Fonctionnalités en développement

### Type de modifications
- **Ajouté** : Nouvelles fonctionnalités
- **Modifié** : Changements de fonctionnalités existantes
- **Corrigé** : Corrections de bugs
- **Supprimé** : Fonctionnalités retirées
- **Sécurité** : Corrections de sécurité
- **Documentation** : Modifications de documentation uniquement

---

**Dernière mise à jour** : 21 janvier 2026  
**Mainteneur** : Latury (latury57@gmail.com)
