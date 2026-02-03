# 📝 PATCH NOTES – Gestionnaire de Logement

Ce fichier contient les **notes techniques détaillées** du projet **Gestionnaire de Logement**.

## Différence avec les autres fichiers
- **README.md** → Présentation générale (utilisateurs & contributeurs)
- **CHANGELOG.md** → Résumé des changements par version
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

# 🚀 Version 1.0.0-dev — Fondations & UX (actuelle)

📅 **Période** : Janvier – Février 2026  
📌 **Statut** : 🟡 En développement actif  
🎯 **Objectif** : Poser une base propre, pédagogique et agréable à utiliser

---

## 🏗️ Architecture & Structure

### 📁 Organisation du projet
- Mise en place d’une **structure modulaire claire**
- Séparation logique :
  - `Modeles`
  - `Vues`
  - `Chauffage` (module dédié)
  - `Styles`
  - `Utilitaires`
  - `Configurations` (ignoré par Git)

👉 Objectif : faciliter la compréhension pour un développeur débutant.

---

## 🎨 Système de styles & couleurs

### Styles/Couleurs.xaml
- Centralisation complète des couleurs
- Nommage explicite (Eau / Électricité / Chauffage / Neutres)
- Palette cohérente et réutilisable
- Préparation pour futur thème sombre

### Choix UX
- Contraste suffisant
- Feedback visuel immédiat
- Lisibilité prioritaire

---

## 🔥 Module Chauffage (le plus avancé)

### 🪟 ChauffageVue
- Filtrage par type de chauffage :
  - Fioul
  - Gaz
  - Électrique
  - Bois
- Interface cohérente avec les autres modules

---

### ➕ AjouterReleveChauffageVue

#### Fonctionnalités UX implémentées
- Validation visuelle immédiate :
  - Bordure rouge si champ invalide
- Adaptation automatique de l’unité :
  - Gaz → m³
  - Fioul → litres
  - Électrique → kWh
  - Bois → stères
- Désactivation intelligente de certains champs selon le type
- Résumé **temps réel discret** sous le formulaire
- Aucune sauvegarde silencieuse (volontaire)

#### Choix techniques
- Validation **côté interface** avant toute logique métier
- Pas de calcul automatique du coût pour le moment
- Préparation pour liaison avec paramètres ultérieurs

---

## 🧾 Modèles de données

### Modèles existants
- `Facture.cs`
- `ReleveEau.cs`
- `ReleveElectricite.cs`
- `ReleveChauffage.cs`

🔧 Les modèles sont volontairement simples :
- Propriétés claires
- Pas de logique complexe embarquée
- Lisibilité > optimisation

---

## 💾 Gestion des données (JSON)

### GestionnaireDonnees.cs
- Structure prête pour :
  - Lecture
  - Écriture
  - Sérialisation JSON
- Pas encore branché sur les formulaires

👉 Décision volontaire :
> Stabiliser l’UX avant de connecter la persistance

---

## 🧠 Expérience utilisateur (UX)

Principes appliqués :
- Pas de surcharge visuelle
- Validation explicite
- Feedback immédiat
- Comportements prévisibles
- Lisibilité pour non-techniciens

---

## 📚 Documentation

Documents maintenus :
- README.md
- CHANGELOG.md
- PATCH_NOTES.md
- FEUILLE_DE_ROUTE.md
- GUIDE_GITHUB_DESKTOP.md
- EXEMPLES_COMMITS.md
- LICENSE.txt

🎯 Objectif :
> Un projet compréhensible **sans connaissance préalable**

---

## ⚖️ Licence & conformité

- Licence : **CC BY-NC 4.0**
- En-tête obligatoire ajouté dans :
  - Tous les fichiers `.cs`
  - Tous les fichiers `.xaml`
- Usage commercial interdit
- Attribution obligatoire

---

## 📊 État technique global

- Architecture : MVVM hybride (progressif)
- Lignes de code : ~1 500 (XAML + C#)
- Modules actifs : 4
- Formulaires avancés : Chauffage
- Stockage : JSON local (non encore connecté)
- Build : Stable

---

# ⏭️ Prochaines étapes techniques (1.0.1)

- Connexion réelle aux fichiers JSON
- CRUD fonctionnel (Eau / Électricité / Chauffage)
- Finalisation des formulaires d’ajout
- Validation métier renforcée
- Guide utilisateur simplifié

---

## 🧭 Philosophie du projet

- Pas de sur-ingénierie
- Pas de fonctionnalités « gadget »
- Priorité à :
  - Compréhension
  - UX
  - Apprentissage
- Chaque étape est validée avant d’avancer

---

📌 **Dernière mise à jour** : 03 février 2026  
👤 **Auteur** : Latury (Flo)  
🤖 **Assistance** : Jarvis – IA d’accompagnement pédagogique
