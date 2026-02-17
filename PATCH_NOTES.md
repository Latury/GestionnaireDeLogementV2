# 📝 PATCH NOTES – Gestionnaire de Logement

Ce fichier contient les notes techniques et fonctionnelles détaillées du projet
Gestionnaire de Logement.

---

## 📌 Organisation de la documentation (Mise à jour)

À partir de la version **1.0.0-dev**, le fichier **CHANGELOG.md** est supprimé.

- **README.md** → Présentation générale du projet (utilisateurs & contributeurs)
- **FEUILLE_DE_ROUTE.md** → Vision et plan d’évolution
- **PATCH_NOTES.md** →Historique complet (fonctionnel + technique) - (ce qui a été fait, comment, pourquoi)

🎯 Objectif : simplifier la maintenance et éviter la duplication d’informations.

---

## 📌 Convention utilisée

Chaque version contient :

- 📅 **Période**
- 🎯 **Objectif technique**
- 🛠️ **Modifications réalisées**
- 🧠 **Décisions techniques**
- 📊 **État du code**

---

# 🚀 Version 1.0.0-dev

**Fondations – Restructuration – UX Professionnalisée**

📅 **Période** : Janvier – Février 2026  
📌 **Statut** : 🟡 Développement actif  
🎯 **Objectif** : Stabiliser l’architecture, professionnaliser l’interface et préparer la persistance JSON complète.

---

### ✨ État Fonctionnel Actuel

## 🧭 Navigation

Navigation principale fonctionnelle entre :

- Tableau de bord

- Eau

- Électricité

- Chauffage

- Factures

- Historique

- Paramètres

- Navigation unifiée via MainWindow avec gestion du bouton actif.

---

### 🔥 Module Chauffage

**Fonctionnalités**

   - Ajout de relevé
   - Modification de relevé
   - Filtrage par type :
       - Gaz
       - Fioul
       - Bois
       - Électrique
   - Validation visuelle immédiate (bordures rouges)
   - Adaptation automatique de l’unité
   - Désactivation contextuelle de champs
   - Résumé en temps réel avant validation

**Rôle**

Module le plus avancé UX → référence d’harmonisation des autres modules.

---

### 💧 Module Eau

- Ajout de relevé
- Modification de relevé
- Structure MVVM partielle
- Préparation à la persistance JSON

---

### ⚡ Module Électricité

- Ajout de relevé
- Modification de relevé
- Structure alignée avec Eau

---

### 📄 Module Factures

- Ajout
- Modification
- Suppression
- Catégorisation
- Préparation à l’intégration complète avec Historique

---

### 📜 Module Historique

**Fonctionnalités**

   - Enregistrement des actions :
       - Ajout
       - Modification
       - Suppression
   - Filtrage par catégorie
   - Suppression ciblée
   - Suppression complète

Objectif : traçabilité pédagogique et transparence des actions.

---

### 🏗️ Architecture & Structure

## 📁 Restructuration modulaire complète

Organisation par domaine métier :
   - Chauffage
   - Eau
   - Electricite
   - Facture
   - Historique
   - Configurations
   - Application
   - Outils
   - Ressources

Chaque module respecte :
   - Modeles
   - Services
   - VueModeles
   - Vues

🎯 But : lisibilité, pédagogie, évolutivité.

---

### ♻️ Suppression des Emojis

**Problème initial**

Les emojis étaient présents dans :

   - Boutons
   - Titres
   - Messages
   - Commentaires

**Solution**
   - Suppression complète
   - Remplacement par icônes vectorielles XAML

---

### 🎨 Système d’icônes vectorielles centralisé

## Dossier :

**Ressources/Icones/Icones.xaml**

- Icônes en Path XAML
- Centralisation complète
- Réutilisation via StaticResource
- Cohérence visuelle inter-modules

🎯 Interface professionnelle > décoration visuelle.

---

### 💾 Persistance JSON

**État actuel**
   - GestionnaireDonnees prêt
   - Services dédiés par module
   - Sérialisation prévue
   - Connexion partielle implémentée

**Décision stratégique**
   - Stabiliser l’UX avant connexion complète CRUD ↔ JSON.

Finalisation prévue en **1.0.1.**

---

### 🎨 Système de styles

**Couleurs.xaml**
   - Centralisation complète
   - Palette cohérente
   - Contraste vérifié
   - Préparation thème sombre

**Philosophie UI**
   - Lisibilité prioritaire
   - Feedback immédiat
   - Pas de surcharge
   - Comportements prévisibles

   ---

### 🧠 Décisions Techniques Importantes

- MVVM hybride évolutif (transition progressive)
- Validation UX avant validation métier stricte
- Pas de sur-ingénierie
- Modularité claire avant optimisation
- Architecture pensée pour un développeur autodidacte

---

### ⚠️ Limitations actuelles

- Persistance JSON non totalement connectée
- Validation métier encore partielle
- Pas de statistiques dynamiques
- Pas d’export CSV / PDF
- Pas de sauvegarde automatique globale
- Paramètres avancés non finalisés

---

### 📊 État global du projet

- Architecture : stable
- Build : stable
- Icônes : vectorielles centralisées
- Emojis : 0
- Modules métier : 6
- Persistance : en cours
- UX : avancée sur Chauffage

---

### ⏭️ Prochaine étape – Version 1.0.1

Objectif : Stabilisation complète.
   - Connexion CRUD ↔ JSON sur tous les modules
   - Tests manuels systématiques
   - Validation métier renforcée
   - Harmonisation UX complète
   - Création GUIDE_UTILISATEUR.md

**⚠️ Aucune nouvelle fonctionnalité prévue.
Stabilisation uniquement.**

---

### ⚖️ Licence & conformité

Licence : **Creative Commons BY-NC 4.0**
   - Attribution obligatoire
   - Usage commercial interdit
   - En-tête licence ajouté dans tous les .cs et .xaml

---

💾  **Version** : **1.0.0-dev**  
📌 **Dernière mise à jour** : 17 Février 2026 19h00
👤 **Auteur** : Flo Latury
