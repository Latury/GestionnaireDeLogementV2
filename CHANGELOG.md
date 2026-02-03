# 📜 CHANGELOG — Gestionnaire de Logement

Ce fichier liste les changements visibles et fonctionnels du projet,
du point de vue utilisateur.

Pour les détails techniques (code, refactor, architecture),
voir le fichier **PATCH_NOTES.md**.

---

## [1.0.0-dev] — En développement actif
📅 Février 2026

### ✨ Ajouts majeurs
- Mise en place de la structure complète du projet WPF (.NET 8)
- Navigation principale fonctionnelle entre les modules :
  - Accueil
  - Factures
  - Eau
  - Électricité
  - Chauffage
- Création du module **Chauffage** avec une architecture dédiée
- Ajout du modèle **ReleveChauffage**
- Fenêtre d’ajout de relevé de chauffage avec :
  - Validation visuelle immédiate (bordures rouges)
  - Adaptation automatique de l’unité selon le type de chauffage
  - Désactivation intelligente de certains champs
  - Résumé en temps réel avant validation
- Système de couleurs centralisé et cohérent sur toute l’application
- UX homogène entre les vues principales

### 🎨 Interface & UX
- Interfaces claires, lisibles et non surchargées
- Feedback utilisateur immédiat lors de la saisie
- Utilisation d’emojis pour améliorer la compréhension visuelle
- Styles centralisés pour faciliter l’évolution graphique

### 🧱 Architecture
- Séparation claire des modules (Chauffage, Vues principales, Modèles)
- Début de structuration MVVM (hybride)
- Dossiers organisés pour favoriser l’évolutivité
- Préparation à la connexion au stockage JSON

### 📚 Documentation
- README détaillé et à jour
- Feuille de route claire et réaliste
- Patch notes techniques détaillées
- Guides Git et conventions de commits
- Licence CC BY-NC 4.0 appliquée à tout le projet

### ⚠️ Limitations actuelles
- Données non encore connectées au stockage JSON
- CRUD incomplet sur les modules Eau / Électricité / Factures
- Statistiques et graphiques non encore implémentés
- Paramètres utilisateur en préparation

---

## Versions futures
Les prochaines versions sont détaillées dans :
➡️ **FEUILLE_DE_ROUTE.md**
