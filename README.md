<div align="center">

# 🏠 **Gestionnaire de Logement**

**Application WPF de gestion complète de logement**

![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp&logoColor=white&labelColor=384454)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white&labelColor=384454)
![WPF](https://img.shields.io/badge/WPF-Windows-0078D4?style=for-the-badge&logo=windows&logoColor=white&labelColor=384454)
![VERSION](https://img.shields.io/badge/VERSION-V1.0.0--dev-F9DC5C?style=for-the-badge&logo=git&logoColor=white&labelColor=384454)
![STATUT](https://img.shields.io/badge/STATUT-EN%20DÉVELOPPEMENT-FFA500?style=for-the-badge&logo=checkmarx&logoColor=white&labelColor=384454)

_Développé par [Latury](https://github.com/Latury)_

---

**💧 Eau • ⚡ Électricité • 🔥 Chauffage • 🧾 Factures • 📜 Historique**

</div>

---

## 🎯 **Vue d'ensemble**

**Gestionnaire de Logement** est une application Windows développée en **WPF (.NET 8)** permettant de gérer et suivre :

1. Les relevés d’eau
2. Les relevés d’électricité
3. Les relevés de chauffage
4. Les factures
5. L’historique des modifications

L’application est conçue comme un projet pédagogique structuré, avec une approche progressive de C#, WPF et de l’architecture MVVM.

Il ne s’agit pas seulement d’un outil de gestion, mais d’un support d’apprentissage visant à comprendre la structuration d’un projet réel, modulaire et évolutif.

**Version actuelle:** 1.0.0-dev
**Statut:** 🟡 Développement actif — architecture stabilisée, logique métier et persistance JSON en cours d’implémentation.

---

## 🌱 **À propos du développeur**

**Autodidacte en C# et WPF, en apprentissage progressif.**

Ce projet est avant tout un support pédagogique personnel.
Il me permet d’expérimenter, de structurer ma pensée et de comprendre les bases du développement d’applications Windows.

**Démarche adoptée:**

1. Approche progressive de l’architecture MVVM.
2. Structuration modulaire claire (Modeles / Vues / Services / ViewModeles).
3. Organisation logique des dossiers et séparation des responsabilités.
4. Mise en place d’un stockage local en JSON.
5. Documentation détaillée pour comprendre chaque étape.

**L’objectif n’est pas uniquement de produire une application fonctionnelle,
mais de comprendre chaque décision technique, même les plus simples.**

**Les erreurs font partie du processus.
La priorité est donnée à la clarté, à la cohérence et à l’apprentissage.**

### **🛠️ Outils et méthodes utilisés**

- **Maquettage** : [Draw.io](https://draw.io) pour concevoir l'interface et la structure
- **Développement** : Visual Studio 2022 avec .NET 8.0
- **Versioning** : Git avec GitHub Desktop pour un suivi clair des modifications
- **Stockage des données** : JSON local pour une gestion simple et transparente
- **Assistance pédagogique** : Intelligence artificielle ChatGPT 5.2 (Alias Jarvis) utilisée comme outil d’apprentissage et de structuration du projet
- **Documentation** : Rédaction continue (README, PATCH_NOTES, FEUILLE_DE_ROUTE)

### **🎓 Objectifs d'apprentissage**
**Ce projet s’inscrit dans une démarche autodidacte structurée.**

**Objectifs personnels:**

1. Comprendre réellement les bases de C# et de WPF
2. Assimiler progressivement l’architecture MVVM
3. Structurer un projet modulaire propre (Modeles / Vues / Services / ViewModeles)
4. Mettre en place une gestion locale des données en JSON
5. Apprendre les bonnes pratiques de versioning avec Git
6. Développer une méthode de travail claire et documentée

### **💪 Philosophie du projet**

Ce projet est avant tout un support d’apprentissage par la pratique.
L’objectif n’est pas seulement de faire fonctionner une application, mais de comprendre les choix techniques, la structuration du code et l’évolution d’une architecture au fil du temps.

Le code est volontairement documenté et organisé de manière pédagogique afin de rester lisible, même pour un développeur en phase d’apprentissage.

Ce dépôt peut ainsi servir de référence à d’autres personnes autodidactes souhaitant comprendre comment structurer progressivement un projet WPF en C#.

---

## ✨ **Fonctionnalités principales**

### **💧 Gestion de l'eau**

**Fonctionnel:**

1. Ajout et modification de relevés (eau froide / eau chaude)
2. Calcul de la consommation entre deux relevés
3. Filtrage par type
4. Historique des relevés avec dates

**En cours / prévu:**

1. Estimation automatique du montant basé sur le prix au m³
2. Graphiques d’évolution mensuelle et annuelle

### **⚡ Gestion de l'électricité**

**Fonctionnel:**

1. Suivi des relevés (heures pleines / heures creuses)
2. Calcul de consommation en kWh
3. Structure prête pour affichage statistique

**En cours / prévu:**

1. Estimation automatique du coût selon tarif HP/HC
2. Détection des variations importantes
3. Graphiques d’évolution

### **🔥 Gestion du chauffage**

**Fonctionnel:**

1. Support multi-types : Fioul, Gaz, Électrique, Bois
2. Ajout de relevé avec validation visuelle immédiate
3. Adaptation automatique de l’unité selon le type
4. Désactivation contextuelle de champs
5. Résumé en temps réel avant validation
6. Filtrage par type

**Prévu:**

1. Calcul automatique du coût via paramètres
2. Statistiques saisonnières

### **🧾 Gestion des factures**

**Fonctionnel:**

1. Ajout, modification et suppression
2. Catégorisation (Eau, Électricité, Chauffage, Autre)
3. Gestion du statut de paiement
4. Recherche et filtres
5. Notes associées

**Prévu:**

1. Alertes de factures impayées

### **📜 Gestion de l’historique**

**Fonctionnel:**

1. Enregistrement des actions (ajout / modification / suppression)
2. Filtrage par catégorie
3. Suppression ciblée
4. Suppression complète de l’historique

### 💳 Achats échelonnés _(prévu en v1.2.0)_

Prévu en version 1.2.0
Module non encore implémenté.

### **📊 Tableaux de bord et statistiques**

**Partiellement structuré:**

1. Cartes statistiques de base

**Prévu:**

1. Graphiques dynamiques
2. Comparaisons mensuelles
3. Calcul d’économies
4. Prévisions basées sur l’historique

### **🏡 Mon logement** _(à venir)_

Prévu
Structure non encore implémentée.

---

## 🧠 Expérience utilisateur (UX)

Une attention particulière est portée à la clarté et à la compréhension immédiate de l’interface.

**Fonctionnalités actuellement implémentées:**

1. Validation visuelle immédiate des champs (bordures rouges en cas d’erreur)
2. Messages explicites en cas de saisie invalide
3. Résumé en temps réel des données dans le module Chauffage
4. Adaptation dynamique de certains champs selon le contexte (ex : type de chauffage sélectionné)
5. Interfaces structurées, sans surcharge visuelle
6. Hiérarchie claire des informations

**Approche adoptée:**

1. Priorité à la lisibilité plutôt qu’aux effets graphiques
2. Feedback utilisateur systématique avant validation
3. Comportements prévisibles et cohérents entre les modules

🎯 Objectif : proposer une application compréhensible, même pour un utilisateur non technique.

---

## 🏗️ **Architecture du projet**

```
GestionnaireDeLogement/
│
├── .gitattributes
├── .gitignore
├── App.config
├── App.xaml
├── App.xaml.cs
├── EXEMPLES_COMMITS.md
├── FEUILLE_DE_ROUTE.md
├── GestionnaireDeLogement.csproj
├── GestionnaireDeLogement.sln
├── GUIDE_GITHUB_DESKTOP.md
├── LICENSE.txt
├── PATCH_NOTES.md
├── README.md
│
├── 📁 Application/
│   └── 📁 Vues/
│       ├── AccueilVue.xaml
│       ├── AccueilVue.xaml.cs
│       ├── ConfirmationSuppressionDialogue.xaml
│       ├── ConfirmationSuppressionDialogue.xaml.cs
│       ├── MainWindow.xaml
│       └── MainWindow.xaml.cs
│
├── 📁 Chauffage/
│   ├── 📁 Modeles/
│   │   └── ReleveChauffage.cs
│   │
│   ├── 📁 Services/
│   │   └── GestionnaireJsonChauffage.cs
│   │
│   ├── 📁 VueModeles/
│   │   └── ChauffageVueModele.cs
│   │
│   └── 📁 Vues/
│       ├── ChauffageVue.xaml
│       ├── ChauffageVue.xaml.cs
│       │
│       └── 📁 RelevesChauffage/
│           ├── AjouterReleveChauffageVue.xaml
│           ├── AjouterReleveChauffageVue.xaml.cs
│           ├── ModifierReleveChauffageVue.xaml
│           └── ModifierReleveChauffageVue.xaml.cs
│
├── 📁 Configurations/
│   ├── 📁 Modeles/
│   │   └── ConfigurationGlobale.cs
│   │
│   ├── 📁 Services/
│   │   └── ConfigurationService.cs
│   │
│   ├── 📁 VueModeles/
│   │   └── ConfigurationVueModele.cs
│   │
│   └── 📁 Vues/
│       ├── ConfigurationVue.xaml
│       └── ConfigurationVue.xaml.cs
│
├── 📁 Donnees/
│   ├── chauffage.json
│   └── GestionnaireDonnees.cs
│
├── 📁 Eau/
│   ├── 📁 Modeles/
│   │   └── ReleveEau.cs
│   │
│   ├── 📁 Services/
│   │
│   ├── 📁 VueModeles/
│   │   ├── EauVueModele.cs
│   │   └── ModifierEauVueModele.cs
│   │
│   └── 📁 Vues/
│       ├── AjouterReleveEauDialogue.xaml
│       ├── AjouterReleveEauDialogue.xaml.cs
│       ├── EauVue.xaml
│       ├── EauVue.xaml.cs
│       ├── ModifierReleveEauVue.xaml
│       └── ModifierReleveEauVue.xaml.cs
│
├── 📁 Electricite/
│   ├── 📁 Modeles/
│   │   └── ReleveElectricite.cs
│   │
│   ├── 📁 Services/
│   │
│   ├── 📁 VueModeles/
│   │   ├── ElectriciteVueModele.cs
│   │   └── ModifierElectriciteVueModele.cs
│   │
│   └── 📁 Vues/
│       ├── ElectriciteVue.xaml
│       ├── ElectriciteVue.xaml.cs
│       ├── ModifierReleveElectriciteVue.xaml
│       └── ModifierReleveElectriciteVue.xaml.cs
│
├── 📁 Facture/
│   ├── 📁 Modeles/
│   │   └── Facture.cs
│   │
│   ├── 📁 Services/
│   │
│   ├── 📁 VueModeles/
│   │
│   └── 📁 Vues/
│       ├── AjouterFactureVue.xaml
│       ├── AjouterFactureVue.xaml.cs
│       ├── FacturesVue.xaml
│       ├── FacturesVue.xaml.cs
│       ├── ModifierFactureVue.xaml
│       └── ModifierFactureVue.xaml.cs
│
├── 📁 Historique/
│   ├── 📁 Modeles/
│   │   └── HistoriqueModification.cs
│   │
│   ├── 📁 Services/
│   │   └── GestionnaireHistorique.cs
│   │
│   └── 📁 Vues/
│       ├── HistoriqueVue.xaml
│       └── HistoriqueVue.xaml.cs
│
├── 📁 Outils/
│   ├── 📁 Notifications/
│   │   └── BaseNotification.cs
│   │
│   ├── 📁 Styles/
│   │   └── Couleurs.xaml
│   │
│   └── 📁 Utilitaires/
│       └── Couleurs.cs
│
├── 📁 Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Settings.settings
│   └── fichiers générés
│
└── 📁 Ressources/
    ├── 📁 Icones/
    │   ├── Icones.xaml
    │   └── (toutes les icônes vectorielles XAML organisées par catégorie)
    │
    └── 📁 Images/
```
---

## 🛠️ **Technologies utilisées**

| Technologie                     | Version        | Rôle dans le projet                                 |
| ------------------------------- | -------------- | --------------------------------------------------- |
| **C#**                          |      12.0      | Langage principal                                   |
| **.NET**                        |    8.0  LTS    | Runtime et framework d’exécution                    |
| **WPF**                         | .NET 8 Desktop | Interface graphique Windows                         |
| **XAML**                        | —              | Définition déclarative de l’interface utilisateur   |
| **System.Text.Json**            | Inclus .NET 8  | Sérialisation et persistance locale des données     |
| **Visual Studio 2022**          | —              | Environnement de développement                      |
| **Git**                         | —              | Gestion de version                                  |
| **Draw.io**                     | —              | Conception des maquettes                            |
| **IA d’assistance pédagogique** | —              | Support à la compréhension et structuration du code |


---

## 📚 **Documentation du projet**

**Le projet est accompagné d’une documentation structurée afin de faciliter:**

1. la compréhension globale,
2. le suivi des évolutions,
3. la maintenance,
4. l’apprentissage technique.

### **📖 Documentation utilisateur**
- **[README.md](README.md)** — Présentation complète du projet (vision, architecture, fonctionnalités).
- **GUIDE_UTILISATEUR.md** - (prévu en v1.0.1) — Guide d’utilisation simplifié destiné aux utilisateurs finaux.

### **🛠️ Documentation technique**
- **[PATCH_NOTES.md](PATCH_NOTES.md)** — Notes techniques détaillées : décisions d’architecture, refactorisations, choix techniques.
- **[FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md)** — Plan d’évolution du projet (versions futures, objectifs, priorités).

### **🐙 Documentation Git & GitHub**
- **[GUIDE_GITHUB_DESKTOP.md](GUIDE_GITHUB_DESKTOP.md)** — Guide pratique d’utilisation de GitHub Desktop.
- **[EXEMPLES_COMMITS.md](EXEMPLES_COMMITS.md)** — Convention et exemples de messages de commit structurés.

## 📝 **Licence**

Ce projet est distribué sous la licence:

**Creative Commons Attribution – NonCommercial 4.0 International (CC BY-NC 4.0)**

## Cette licence autorise:

✔️ L’utilisation personnelle
✔️ L’étude et l’apprentissage
✔️ La modification du code source
✔️ La redistribution non commerciale

## Elle interdit:

❌ Toute utilisation commerciale
❌ La vente du logiciel ou d’une version dérivée
❌ L’intégration dans un produit payant

## Attribution obligatoire

Toute utilisation ou redistribution doit mentionner :

- Créateur original : **Flo (Latury)**
- Projet : **Gestionnaire de Logement**
- Dépôt GitHub : https://github.com/Latury/GestionnaireDeLogement

📄 Voir le fichier [LICENSE.txt](LICENSE.txt) pour le texte complet de la licence.

---

## 📋 Roadmap réaliste

### 🟡 Version 1.0.0-dev — Fondations & UX (actuel)

**📌 Objectif : poser une architecture propre et une base UX cohérente**

**✅ Réalisé**

Structure générale du projet WPF (.NET 8)
Organisation modulaire claire :

1. ✅Modeles
2. ✅Vues
3. ✅Services
4. ✅VueModeles

**✅Modules séparés (Eau, Électricité, Chauffage, Factures, Historique)**
**✅Modèles de données principaux:**

✅Facture
✅ReleveEau
✅ReleveElectricite
✅ReleveChauffage

**✅Système de styles centralisé (Couleurs.xaml)**
**✅Navigation principale entre les modules**
**✅Module Chauffage avec UX avancée:**

✅Validation visuelle immédiate
✅Adaptation automatique des unités
✅Désactivation contextuelle de champs
✅Résumé en temps réel

**✅Système d’historique des modifications**
**✅Documentation structurée complète**
**✅Licence CC BY-NC 4.0 appliquée**

🟠 **En cours**

- 🔲 Connexion progressive des formulaires au stockage JSON réel
- 🔲 Harmonisation UX complète entre tous les modules
- 🔲 Finalisation des formulaires Eau / Électricité

### 🟢 Version 1.0.1 — Stabilisation fonctionnelle

**📌 Objectif : rendre l’application fiable et cohérente**

- 🔲 Connexion complète CRUD ↔ JSON
- 🔲 Tests manuels systématiques
- 🔲 Correction des incohérences UX
- 🔲 Renforcement validation métier
- 🔲 Création du GUIDE_UTILISATEUR.md
- 🔲 Nettoyage et homogénéisation du code

### 🔵 Version 1.1.0 — Analyse & valeur ajoutée

**📌 Objectif : ajouter de l’intelligence aux données**

- 🔲 Graphiques dynamiques
- 🔲 Statistiques mensuelles / annuelles
- 🔲 Comparaisons automatiques
- 🔲 Calculs automatiques des coûts

### 🟣 Version 1.2.0 — Confort utilisateur

**📌 Objectif : améliorer l’expérience**	

- 🔲 Module Achats échelonnés
- 🔲 Alertes et rappels
- 🔲 Vue calendrier
- 🔲 Paramètres utilisateur avancés
- 🔲 Optimisations de performance

### 🟠 Version 2.0.0 — Version mature

**📌 Objectif : usage quotidien stable**	

- 🔲 Export PDF / CSV
- 🔲 Import de données
- 🔲 Sauvegarde automatique
- 🔲 Gestion multi-logements
- 🔲 Thèmes personnalisables
- 🔲 Installateur Windows

### 🔴 Version 3.0.0 — Vision long terme

**📌 Objectif : extension avancée**

- 🔲 Synchronisation cloud optionnelle
- 🔲 Application mobile compagnon
- 🔲 Accès multi-appareils

### 🧭 Philosophie de la roadmap

- Pas de promesses irréalistes
- Priorité à la stabilité avant les fonctionnalités avancées
- Compréhension avant complexité
- UX avant sophistication technique

📖 **Voir [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md) pour le détail complet de la roadmap**

---

## 🎨 Système de couleurs (version corrigée)

Le projet utilise un système de couleurs centralisé dans `Outils/Styles/Couleurs.xaml` afin de garantir une cohérence visuelle globale et une maintenance simplifiée.

Les couleurs sont définies sous forme de ressources réutilisables dans l’ensemble des vues.

**Couleurs principales:**

- Bleu (#3B82F6)
- Bleu foncé (#2563EB)
- Bleu clair (#60A5FA)

**Succès:** - Vert (#10B981)

**Alertes:** - Orange (#F59E0B), Jaune (#FBBF24)

**Erreurs:** - Rouge (#EF4444)

**Neutres:** - Palette complète de gris (Gris50 à Gris900)

**Couleurs contextuelles:**

- Eau : Bleu (#06B6D4)
- Électricité : Jaune (#FBBF24)
- Chauffage : Orange (#F97316)

🎯 Objectif :
Lisibilité, contraste maîtrisé et feedback visuel immédiat, sans surcharge graphique.

---

## 🔒 Sécurité des données (version plus rigoureuse)

**🔒 Sécurité des données**

**Stockage 100 % local:**
- Toutes les données sont enregistrées localement sur la machine de l’utilisateur.

**Format JSON lisible:**
- Les fichiers sont transparents et récupérables manuellement.

**Aucune connexion réseau active:**
- L’application ne communique avec aucun serveur externe.

**Aucune télémétrie:**
- Aucun tracking, aucune collecte de données.

**Sauvegarde automatique:**
- Fonction prévue pour une version ultérieure (v2.0).

**⚠️ À ce stade, il ne s’agit pas d’un système chiffré sécurisé.
L’objectif actuel est la transparence et la simplicité.**

---

## 👤 **Auteur**

**Flo (Latury)**  
📧 Email : latury57@gmail.com  
🐙 GitHub : https://github.com/Latury  
🌍 Localisation : France  
💼 Statut : Autodidacte débutant en apprentissage

---

## 🙏 **Remerciements**

- Microsoft pour .NET 8 et WPF
- La communauté C# / WPF
- GitHub pour l’hébergement du projet
- Draw.io pour le maquettage

**Assistance pédagogique via ChatGPT 5.2 (alias Jarvis) pour:**
- Structuration du projet
- Réflexion UX
- Vulgarisation des concepts techniques

---

## 📞 **Support et Contact**

### **Besoin d'aide ?**
- 📖 Consultez la [documentation complète](GUIDE_GITHUB_DESKTOP.md)
- 🐛 Signalez un bug via [GitHub Issues](https://github.com/Latury/GestionnaireDeLogement/issues)
- 💬 Des questions sur le projet ? Créez une nouvelle [Issue](https://github.com/Latury/GestionnaireDeLogement/issues) et décrivez votre problème

### **Contribuer au projet**
Les contributions sont les bienvenues ! Consultez [EXEMPLES_COMMITS.md](EXEMPLES_COMMITS.md) pour les conventions de commit.

---

## 📊 État actuel du projet

- Langage principal : C#
- Framework : WPF (.NET 8 LTS)
- Architecture : MVVM hybride (progressif)
- Modules structurés : Eau, Électricité, Chauffage, Factures, Historique
- Stockage : JSON local (connexion en cours d’implémentation)
- Validation UX avancée : module Chauffage
- Documentation maintenue : README, PATCH_NOTES, FEUILLE_DE_ROUTE

📌 Projet structuré et stable sur le plan architectural.
📌 Persistance et logique métier encore en cours d’implémentation.

---

## 🎯 Prochaines étapes

1. Finaliser la connexion complète des formulaires au stockage JSON
2. Stabiliser les validations métier
3. Harmoniser l’UX entre tous les modules
4. Préparer l’intégration des statistiques
5. Pour le détail complet :

📖 **Suivez l'avancement dans [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md)**

---

<div align="center">

⭐ Si ce projet vous aide dans votre apprentissage, n'hésitez pas à lui donner une étoile.

Projet open-source à vocation pédagogique  
Développé en France 🇫🇷

---

💾  **Version** : **1.0.0-dev**  
📌 **Dernière mise à jour** : 17 Février 2026 19h00
👤 **Auteur** : Flo Latury

</div>
