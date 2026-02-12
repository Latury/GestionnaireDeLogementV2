# 🗺️ Feuille de Route – Gestionnaire de Logement

### 📌 Vision du projet

**Objectif**  

Créer une application WPF claire, structurée et pédagogique permettant de gérer :

- les factures,
- les relevés (eau, électricité, chauffage),
- les achats échelonnés (prévu),
- l’évolution des données dans le temps.

Le projet met l’accent sur :

- la compréhension du code,
- la structuration modulaire,
- l’UX cohérente,
- l’apprentissage progressif de C#, WPF et MVVM.

## 🧭 Philosophie

- Projet d’apprentissage avant tout
- Priorité à la lisibilité et à la cohérence UX
- Progression étape par étape
- Compréhension avant complexité
- Pas de promesses irréalistes

## ⚠️ Note importante

**Cette feuille de route est évolutive.**

**Elle peut être modifiée, ajustée ou réorganisée à tout moment selon:**

- la difficulté technique rencontrée,
- les apprentissages réalisés,
- les refactorisations nécessaires,
- ou les choix d’architecture réajustés.

**L’objectif n’est pas de respecter un planning figé,
mais de maintenir une progression cohérente et réaliste.**

---

### 🎯 Version 1.0.0-dev — Fondations & UX (actuelle)

**Statut:** 🔵 En cours
**Période**  : Janvier – Février 2026  
**Objectif** : Poser une architecture propre et une base UX cohérente avant la mise en place complète de la persistance des données.

## 🏗️ Infrastructure

- 🟢 Structure générale du projet WPF (.NET 8)
- 🟢 Organisation modulaire claire (Modeles / Vues / Services / VueModeles)
- 🟢 Configuration Git propre (.gitignore, .gitattributes)
- 🟢 Centralisation des ressources globales (App.xaml)
- 🟢 Navigation principale fonctionnelle entre modules
- 🟢 Documentation structurée (README, CHANGELOG, PATCH_NOTES, Roadmap, Licence)

## 💾 Modèles de données

- 🟢 Facture
- 🟢 ReleveEau
- 🟢 ReleveElectricite
- 🟢 ReleveChauffage
- ⚪ AchatEchelonne (prévu — non implémenté)
- ⚪ Logement (prévu — non implémenté)

## 📄 Pages principales

- 🟢 Accueil (structure tableau de bord)
- 🟢 Factures (affichage + structure CRUD partielle)
- 🟢 Eau (structure + filtres)
- 🟢 Électricité (structure + statistiques de base)
- 🟢 Chauffage (structure + filtrage par type)

## 🔥 Focus Chauffage (module le plus avancé)

- 🟢 Fenêtre dédiée d’ajout de relevé
- 🟢 Validation visuelle immédiate (bordures rouges)
- 🟢 Adaptation automatique de l’unité selon le type
- 🟢 Désactivation contextuelle de champs
- 🟢 Résumé en temps réel avant validation
- 🟢 Cohérence UX avancée par rapport aux autres modules

**Ce module sert actuellement de référence pour harmoniser les autres.**

## 🎨 Design & UX

- 🟢 Système de couleurs centralisé (Couleurs.xaml)
- 🟢 Styles homogènes (cartes, boutons, champs)
- 🟢 Préparation à un système d’icônes vectorielles centralisé
- 🟢 Validation utilisateur visuelle + début de validation métier

## 🟠 En cours

- 🔲 Connexion réelle des formulaires au stockage JSON
- 🔲 Finalisation des formulaires Eau / Électricité
- 🔲 Harmonisation UX complète entre tous les modules
- 🔲 Nettoyage progressif des incohérences d’architecture

---

### 🎯 Version 1.0.1 — Stabilisation fonctionnelle

**Statut:** ⚪ À faire
**Objectif:** Rendre l’application techniquement cohérente, persistante et stable avant toute nouvelle évolution.

**Priorités réelles:**

## 🔧 1. Finalisation de la persistance

- 🔲 Connexion complète des formulaires au stockage JSON (CRUD réel)
- 🔲 Vérification des flux complets : création → modification → suppression → persistance
- 🔲 Tests manuels module par module

## 🧠 2. Consolidation métier

- 🔲 Renforcement de la validation métier (au-delà du visuel)
- 🔲 Vérification des cas limites (valeurs nulles, incohérences, doublons)
- 🔲 Uniformisation des règles entre modules

## 🎨 3. Harmonisation UX

- 🔲 Cohérence des comportements entre modules
- 🔲 Alignement des messages utilisateur
- 🔲 Nettoyage des incohérences visuelles

## 🧹 4. Nettoyage & qualité de code

- 🔲 Suppression des duplications
- 🔲 Clarification des responsabilités
- 🔲 Nettoyage progressif de l’architecture hybride MVVM

## 📘 5. Documentation

- 🔲 Rédaction du GUIDE_UTILISATEUR.md
- 🔲 Mise à jour des captures / exemples si nécessaire

**📌 Important
Cette version n’ajoute aucune nouvelle fonctionnalité.
Elle consolide, stabilise et fiabilise l’existant.**

---

### 🎯 Version 1.1.0 — Analyse des données existantes

**Statut:** ⚪ À faire
**Objectif:** Exploiter les données déjà persistées (Eau, Électricité, Chauffage, Factures)

## 📊 Analyse & exploitation

- 🔲 Graphiques dynamiques (consommation, évolution)
- 🔲 Comparaisons mensuelles automatisées
- 🔲 Calculs automatiques des coûts
- 🔲 Tableaux statistiques exploitables

**👉 Cette version ne crée pas de nouveau module.**
**👉 Elle valorise l’existant.**

## 🎨 UI — Harmonisation visuelle (progressive)

- 🔲 Intégration complète des icônes XAML centralisées
- 🔲 Suppression définitive des symboles temporaires
- 🔲 Cohérence visuelle inter-modules

**⚠️ Le thème clair/sombre peut rester pour 1.2 ou 2.0.**

---

### 🎯 Version 1.2.0 — Nouveau module : Achats échelonnés

**Statut:** ⚪ À faire
**Objectif:** Ajouter une nouvelle entité métier complète

- 🔲 Modèle AchatEchelonne
- 🔲 CRUD complet
- 🔲 Calcul automatique des mensualités
- 🔲 Gestion des échéances
- 🔲 Intégration à l’historique

---

### 🎯 Version 2.0.0 — Stabilisation complète & fiabilité

**Objectif:** application réellement utilisable tous les jours sans crainte

- 🔲 Export CSV (prioritaire avant PDF)
- 🔲 Sauvegarde automatique locale
- 🔲 Restauration de sauvegarde
- 🔲 Tests manuels complets inter-modules
- 🔲 Gestion multi-logements
- 🔲 Installateur Windows propre (.exe / .msi)

---

### 🎯 Version 3.0.0 — Exploration possible (vision long terme)

- 🔲 Synchronisation cloud (si architecture suffisamment stable)
- 🔲 API locale / backend expérimental
- 🔲 Prototype mobile compagnon
- 🔲 Partage multi-utilisateurs (exploratoire)

---

## 📊 Suivi global (réaliste)

| Version   | Statut       | Progression estimée                       |
| --------- | -----------  | ----------------------------------------- |
| 1.0.0-dev | 🔵 En cours  | ~70–75 % structure / ~40 % logique métier |
| 1.0.1     | ⚪ À faire   | 0 %                                       |
| 1.1.0     | ⚪ À faire   | 0 %                                       |
| 1.2.0     | ⚪ À faire   | 0 %                                       |
| 2.0.0     | ⚪ À faire   | 0 %                                       |
| 3.0.0     | ⚪ À faire   | 0 %                                       |

**⚠️ La progression distingue la structure architecturale de l’implémentation complète de la logique métier et de la persistance des données.**

### Légende
- 🟢 Terminé
- 🔵 En cours
- ⚪ À faire
- 🔴 Abandonné / annulé

---

## 🎓 Apprentissage visé

- 🟢 WPF / XAML (bases solides)
- 🟢 Structuration modulaire
- 🔵 Validation UX + logique métier complète
- ⚪ MVVM avancé (découplage strict + bindings avancés)
- ⚪ Data-visualisation
- ⚪ Export / persistance avancée
- ⚪ Architecture évolutive à long terme
- 🔵 Gestion de la complexité et refactorisation progressive

---

## 📝 Notes importantes

- Cette feuille de route est évolutive.
- Les fonctionnalités peuvent être ajustées selon la complexité réelle rencontrée.
- Certaines priorités peuvent être réorganisées.
- L’objectif principal reste l’apprentissage progressif, pas la rapidité.

---

**Dernière mise à jour** : 12 Février 2026  23h35
**Auteur** : Latury
