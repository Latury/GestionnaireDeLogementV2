# 📝 PATCH NOTES – Gestionnaire de Logement

Ce fichier contient les **notes techniques détaillées** du projet  
**Gestionnaire de Logement**.

---

## 📌 Différence avec les autres fichiers

- **README.md** → Présentation générale (utilisateurs & contributeurs)
- **CHANGELOG.md** → Résumé fonctionnel par version
- **PATCH_NOTES.md** → Détails techniques (ce qui a été fait, comment, pourquoi)

---

## 📌 Convention utilisée

Chaque version contient :

- 📅 **Période**
- 🎯 **Objectif technique**
- 🛠️ **Modifications réalisées**
- 🧠 **Décisions techniques**
- 📊 **État du code**

---

# 🚀 Version 1.0.0-dev — Fondations, Restructuration & UX

📅 **Période** : Janvier – Février 2026  
📌 **Statut** : 🟡 Développement actif  
🎯 **Objectif** : Stabiliser l’architecture, professionnaliser l’interface et préparer la persistance des données

---

## 🏗️ Architecture & Structure

### 📁 Restructuration complète du projet

Adoption d’une structure modulaire claire par domaine métier :

- `Chauffage`
- `Eau`
- `Electricite`
- `Facture`
- `Historique`
- `Configurations`
- `Application`
- `Outils`
- `Ressources`

Chaque module respecte la séparation :

- `Modeles`
- `Services`
- `VueModeles`
- `Vues`

### 🎯 Objectif technique

- Éviter les dossiers génériques confus
- Rendre le projet lisible pour un développeur débutant
- Préparer une montée en puissance vers un MVVM plus strict

---

## ♻️ Suppression complète des emojis

### 🔧 Problème

Les emojis étaient utilisés directement dans :

- Titres de fenêtres
- Boutons
- Messages système
- Commentaires

### ✅ Solution

- Suppression globale via scripts PowerShell
- Nettoyage des chaînes C# et XAML
- Remplacement par icônes vectorielles XAML centralisées

### 🎨 Nouvelle approche

Centralisation des icônes dans :

```
Ressources/Icones/
```

Organisation thématique :

- actions_boutons_interactions
- consommations
- navigation_menu_principal
- statuts_succes_erreur_info
- etc.

👉 Décision :  
Interface professionnelle > décorations visuelles.

---

## 🔥 Module Chauffage

### ChauffageVue

- Filtrage par type :
  - Gaz
  - Fioul
  - Bois
  - Électrique
- Structure cohérente avec les autres modules

---

### AjouterReleveChauffageVue

#### UX implémentée

- Validation visuelle immédiate (bordures rouges)
- Adaptation automatique de l’unité :
  - Gaz → m³
  - Fioul → litres
  - Électrique → kWh
  - Bois → stères
- Résumé en temps réel
- Désactivation conditionnelle de champs

#### Décisions techniques

- Validation côté interface avant logique métier
- Pas de calcul automatique du coût (volontaire)
- Préparation à liaison future avec `Configurations`

---

## 💧 Module Eau

- Ajout de relevé
- Modification de relevé
- Structure MVVM partielle
- Préparation pour persistance JSON

---

## ⚡ Module Électricité

- Ajout de relevé
- Modification de relevé
- Structure alignée avec Eau

---

## 🧾 Module Facture

- Ajout
- Modification
- Suppression
- Organisation modulaire propre
- Préparation au suivi via Historique

---

## 📜 Module Historique

### Structure

- `HistoriqueModification.cs`
- `GestionnaireHistorique.cs`
- `HistoriqueVue`

### Fonctionnalités techniques

- Enregistrement des actions :
  - Ajout
  - Modification
  - Suppression
- Filtrage par catégorie
- Suppression ciblée
- Suppression globale

### Objectif

Fournir une traçabilité pédagogique et transparente des actions utilisateur.

---

### 💾 Gestion des données (JSON)

## État actuel

- Structure prête via `GestionnaireDonnees`
- Services dédiés par module
- Sérialisation JSON prévue
- Persistance JSON partiellement connectée
- Intégration complète prévue en 1.0.1

## Décision stratégique

Stabiliser l’UX avant de connecter complètement la persistance.

---

### 🎨 Système de styles

## Couleurs.xaml

- Centralisation complète
- Palette cohérente
- Préparation thème sombre
- Contraste vérifié

## Philosophie UI

- Lisibilité prioritaire
- Feedback immédiat
- Pas de surcharge visuelle
- Comportements prévisibles

---

## 📚 Documentation technique

Documents maintenus :

- README.md
- CHANGELOG.md
- PATCH_NOTES.md
- FEUILLE_DE_ROUTE.md
- GUIDE_GITHUB_DESKTOP.md
- EXEMPLES_COMMITS.md
- LICENSE.txt

Objectif :

> Un projet compréhensible même pour un développeur débutant.

---

### ⚖️ Licence & conformité

- Licence : **CC BY-NC 4.0**
- En-tête obligatoire ajouté dans :
  - Tous les `.cs`
  - Tous les `.xaml`
- Attribution obligatoire
- Usage commercial interdit

---

## 📊 État technique global

- Architecture : MVVM hybride évolutif
- Modules métier : 6 (Eau, Électricité, Chauffage, Facture, Historique, Configurations)
- Icônes : centralisées et vectorielles (XAML)
- Emojis : 0
- Build : Stable
- Restructuration : stabilisée (évolutive)
- Persistance JSON : partiellement connectée (finalisation prévue en 1.0.1)

---

### ⏭️ Prochaines étapes (1.0.1)

- Connexion complète aux fichiers JSON
- CRUD totalement fonctionnel sur tous les modules
- Validation métier renforcée
- Paramètres avancés
- Optimisation progressive

---

### 🧭 Philosophie technique

- Pas de sur-ingénierie
- Code lisible avant tout
- Modularité claire
- Progression maîtrisée
- Chaque étape validée avant la suivante

---

📌 **Dernière mise à jour** : 12 Février 2026  23h49  
👤 **Auteur** : Flo Latury  
🤖 Assistance technique : IA pédagogique ChatGPT 5.2 (Alias : "Jarvis")
