# 📜 CHANGELOG — Gestionnaire de Logement

Ce fichier liste les changements visibles et fonctionnels du projet,
du point de vue utilisateur.

Pour les détails techniques (refactorisations, architecture, décisions internes),
voir **PATCH_NOTES.md**.

---

## [1.0.0-dev] — Développement actif
📅 Février 2026

---

### ✨ Fonctionnalités disponibles

#### Navigation
- Navigation principale fonctionnelle entre :
  - Accueil
  - Eau
  - Électricité
  - Chauffage
  - Factures
  - Historique
  - Paramètres

---

#### Module Chauffage
- Ajout de relevé
- Modification de relevé
- Validation visuelle immédiate (bordures rouges)
- Adaptation automatique de l’unité selon le type
- Désactivation contextuelle de champs
- Résumé en temps réel avant validation

---

#### Module Eau
- Ajout de relevé
- Modification de relevé

---

#### Module Électricité
- Ajout de relevé
- Modification de relevé

---

#### Module Factures
- Ajout de facture
- Modification de facture
- Suppression de facture

---

#### Module Historique
- Affichage des actions (ajout / modification / suppression)
- Filtrage par catégorie
- Suppression ciblée
- Suppression complète de l’historique

---

### 🎨 Interface & UX

- Suppression complète des emojis dans l’interface
- Intégration d’icônes vectorielles XAML centralisées
- Interface homogène et cohérente
- Styles centralisés (couleurs, marges, hiérarchie visuelle)
- Feedback utilisateur immédiat lors de la saisie

---

### 🧱 Architecture

- Restructuration complète du projet par modules :
  - Chauffage
  - Eau
  - Électricité
  - Facture
  - Historique
  - Configurations
  - Adoption d’une organisation modulaire par domaine métier
  - Structuration MVVM progressive (Modeles / Services / VueModeles / Vues)
  - Centralisation des icônes dans `Ressources/Icones`
  - Nettoyage des anciens fichiers et dossiers obsolètes

---

### 📚 Documentation

- README restructuré et aligné avec l’état réel du projet
- Feuille de route mise à jour
- Patch notes techniques détaillées
- Convention de commits définie
- Licence CC BY-NC 4.0 appliquée à l’ensemble du projet

---

### ⚠️ Limitations actuelles

- Connexion complète au stockage JSON en cours d’implémentation
- Validation métier encore en cours d’harmonisation entre modules
- Statistiques et graphiques non encore implémentés
- Pas de sauvegarde automatique globale
- Paramètres avancés non finalisés

---

## Versions futures

Les évolutions prévues sont détaillées dans :
➡️ **FEUILLE_DE_ROUTE.md**
