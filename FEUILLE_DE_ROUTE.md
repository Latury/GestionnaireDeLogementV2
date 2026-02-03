# 🗺️ Feuille de Route – Gestionnaire de Logement

## 📌 Vision du projet

**Objectif**  
Créer une application WPF claire et pédagogique permettant de gérer :
- les factures,
- les relevés (eau, électricité, chauffage),
- les achats échelonnés,
tout en mettant l’accent sur l’UX, la compréhension du code et l’apprentissage.

**Philosophie**
- Projet d’apprentissage avant tout
- Priorité à la lisibilité, à la cohérence UX et à la progression étape par étape
- Pas de promesses irréalistes, chaque version a un objectif clair

---

## 🎯 Version 1.0.0-dev — Fondations & UX (actuelle)

**Statut** : 🔵 **EN COURS**  
**Période** : Janvier – Février 2026  
**Objectif** : Poser une base saine, structurée et agréable à utiliser

### 🏗️ Infrastructure
- 🟢 Structure générale du projet WPF (.NET 8)
- 🟢 Organisation claire des dossiers (Modules, Vues, ViewModels)
- 🟢 Configuration Git (.gitignore, .gitattributes)
- 🟢 Import global des ressources (App.xaml)
- 🟢 Navigation principale fonctionnelle
- 🟢 Documentation projet complète (README, LICENSE, etc.)

### 💾 Modèles de données
- 🟢 Facture
- 🟢 Relevé Eau
- 🟢 Relevé Électricité
- 🟢 Relevé Chauffage
- ⚪ Achat échelonné (prévu)
- ⚪ Logement (prévu)

### 📄 Pages principales
- 🟢 Accueil (tableau de bord)
- 🟢 Factures (structure + affichage)
- 🟢 Eau (structure + filtres)
- 🟢 Électricité (structure + statistiques de base)
- 🟢 Chauffage (structure + filtres par type)

### 🔥 Focus Chauffage (module le plus avancé)
- 🟢 Fenêtre dédiée d’ajout de relevé
- 🟢 Validation visuelle immédiate (bordures rouges)
- 🟢 Adaptation automatique de l’unité selon le type
- 🟢 Désactivation intelligente de champs
- 🟢 Résumé en temps réel discret
- 🟢 UX cohérente et moderne

### 🎨 Design & UX
- 🟢 Système de couleurs centralisé (Couleurs.xaml)
- 🟢 Styles cohérents (cartes, boutons, champs)
- 🟢 Emojis intégrés pour la lisibilité
- 🟢 Validation utilisateur visuelle et métier

### 🟠 En cours
- 🔲 Connexion réelle des formulaires au stockage JSON
- 🔲 Finalisation des formulaires Eau / Électricité
- 🔲 Harmonisation UX entre tous les modules

---

## 🎯 Version 1.0.1 — Stabilisation

**Statut** : ⚪ **À FAIRE**  
**Objectif** : Fiabilité et cohérence fonctionnelle

- 🔲 Connexion complète au stockage JSON (CRUD réel)
- 🔲 Tests manuels de toutes les pages
- 🔲 Corrections de bugs UX / logique
- 🔲 Validation utilisateur renforcée (messages + visuel)
- 🔲 Guide utilisateur simplifié (GUIDE_UTILISATEUR.md)
- 🔲 Nettoyage et commentaires finaux du code

---

## 🎯 Version 1.1.0 — Fonctionnalités avancées

**Statut** : ⚪ **À FAIRE**  
**Objectif** : Apporter de la valeur via l’analyse des données

- 🔲 Graphiques et statistiques avancées
- 🔲 Comparaisons mensuelles
- 🔲 Module Achats échelonnés
- 🔲 Calculs automatiques (coûts, totaux)
- 🔲 Premiers tableaux de statistiques exploitables

---

## 🎯 Version 1.2.0 — Confort & automatisation

**Statut** : ⚪ **À FAIRE**  
**Objectif** : Améliorer le confort d’utilisation

- 🔲 Alertes (factures, échéances)
- 🔲 Rappels visuels
- 🔲 Vue calendrier
- 🔲 Début du système de paramètres utilisateur
- 🔲 Optimisations de performances

---

## 🎯 Version 2.0.0 — Maturité

**Statut** : ⚪ **À FAIRE**  
**Objectif** : Usage quotidien stable

- 🔲 Export PDF / CSV
- 🔲 Import de données
- 🔲 Sauvegarde automatique
- 🔲 Gestion multi-logements
- 🔲 Thèmes personnalisables
- 🔲 Installateur Windows (.exe / .msi)

---

## 🎯 Version 3.0.0 — Long terme

**Statut** : ⚪ **À FAIRE**  
**Objectif** : Mobilité et synchronisation

- 🔲 Synchronisation cloud (optionnelle)
- 🔲 Application mobile compagnon
- 🔲 Accès multi-appareils
- 🔲 Partage de données (famille / colocataires)

---

## 📊 Suivi global

| Version | Statut | Progression |
|-------|--------|-------------|
| 1.0.0-dev | 🔵 En cours | ~75 % |
| 1.0.1 | ⚪ À faire | 0 % |
| 1.1.0 | ⚪ À faire | 0 % |
| 1.2.0 | ⚪ À faire | 0 % |
| 2.0.0 | ⚪ À faire | 0 % |
| 3.0.0 | ⚪ À faire | 0 % |

### Légende
- 🟢 Terminé
- 🔵 En cours
- ⚪ À faire
- 🔴 Abandonné / annulé

---

## 🎓 Apprentissage visé

- ✅ WPF / XAML
- ✅ Structuration de projet
- 🔵 Validation UX et logique métier
- ⚪ MVVM avancé
- ⚪ Graphiques et data-viz
- ⚪ Export / sauvegarde
- ⚪ Synchronisation et mobilité

---

## 📝 Notes

- Cette feuille de route est **évolutive**
- Les dates sont indicatives
- La priorité reste l’apprentissage, la compréhension et l’UX

---

**Dernière mise à jour** : Février 2026  
**Auteur** : Latury
