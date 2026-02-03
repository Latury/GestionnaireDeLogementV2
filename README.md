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

💧 Eau • ⚡ Électricité • 🔥 Chauffage • 💳 Achats • 📊 Statistiques

</div>

---

## 🎯 **Vue d'ensemble**

**Gestionnaire de Logement** est une application de bureau Windows qui permet de gérer tous les aspects d'un logement : factures, consommations d'eau et d'électricité, chauffage, achats échelonnés, et budget mensuel.

**Version actuelle :** `1.0.0-dev` (février 2026)  
**Statut :** 🟡 **En développement actif (stabilisation UX en cours)**

---

## 🌱 **À propos du développeur**

> **Je suis un développeur totalement débutant en C# et WPF !**

Ce projet est mon **premier grand projet** en développement d'applications Windows. Voici mon parcours :

### **🛠️ Outils et méthodes utilisés**
- **Maquettage** : [Draw.io](https://draw.io) pour concevoir l'interface et la structure
- **Développement** : Visual Studio 2022 avec .NET 8.0
- **Assistance** : Intelligence artificielle pour l'apprentissage du code et la résolution de problèmes
- **Documentation** : Rédaction complète pour comprendre chaque étape

### **🎓 Objectifs d'apprentissage**
- Maîtriser les bases de **C#** et **WPF**
- Comprendre l'architecture **MVVM**
- Apprendre la **gestion de données avec JSON**
- Développer des bonnes pratiques de **versioning avec Git**

### **💪 Philosophie du projet**
Ce projet me permet d'apprendre en pratiquant. Chaque ligne de code est documentée pour faciliter ma compréhension et aider d'autres débutants qui souhaiteraient s'inspirer de ce projet.

**Si vous êtes débutant comme moi, n'hésitez pas à explorer le code et la documentation ! 🚀**

---

## ✨ **Fonctionnalités principales**

### **💧 Gestion de l'eau**
- Suivi des relevés de compteur (eau froide et eau chaude)
- Calcul automatique de la consommation en m³
- Filtrage par type (Eau froide / Eau chaude)
- Historique complet avec dates
- Graphiques d'évolution mensuelle et annuelle _(à venir)_
- Estimation du montant basé sur le prix au m³

### **⚡ Gestion de l'électricité**
- Suivi des relevés de compteur (heures creuses et heures pleines)
- Calcul de la consommation en kWh
- Cartes statistiques avec consommation et montant
- Comparaison mensuelle et détection des variations _(à venir)_
- Détection des pics de consommation anormaux _(à venir)_
- Estimation du coût selon le tarif HC/HP

### 🔥 Gestion du chauffage
- Suivi des relevés de consommation de chauffage
- Support multi-types :
  - ⛽ Fioul
  - 🔥 Gaz
  - ⚡ Électrique
  - 🪵 Bois
- Fenêtre dédiée d’ajout de relevé avec :
  - Validation visuelle immédiate (bordures rouges)
  - Adaptation automatique de l’unité selon le type
  - Désactivation intelligente de certains champs selon le contexte
  - Résumé en temps réel discret sous le formulaire
- Interface UX moderne et cohérente avec le reste de l’application
- Filtrage par type de chauffage
- Base prête pour :
  - Calcul automatique du coût (via paramètres)
  - Statistiques saisonnières _(à venir)_

### **🧾 Gestion des factures**
- Ajout, modification et suppression de factures
- Catégorisation automatique (Eau, Électricité, Chauffage, Autre)
- Suivi du statut de paiement
- Alertes pour factures impayées _(à venir)_
- Historique complet avec recherche et filtres
- Notes personnalisées par facture

### **💳 Achats échelonnés** _(à venir v1.1.0)_
- Gestion des achats en plusieurs fois (crédits)
- Calcul automatique des mensualités
- Suivi des paiements effectués et restants
- Alertes d'échéances proches (7 jours)
- Vue calendrier des paiements à venir
- Calcul du coût total avec intérêts

### **📊 Tableaux de bord et statistiques**
- Vue d'ensemble des consommations du mois
- Cartes statistiques par type (Factures, Eau, Électricité, Chauffage)
- Graphiques interactifs et dynamiques _(à venir)_
- Statistiques mensuelles et annuelles _(à venir)_
- Comparaison avec les périodes précédentes _(à venir)_
- Calcul automatique des économies réalisées _(à venir)_
- Prévisions basées sur l'historique _(à venir)_

### **🏡 Mon logement** _(à venir)_
- Fiche d'informations du logement
- Surface, nombre de pièces, type de chauffage
- Prix de référence pour eau, électricité, chauffage
- Historique de modification

---

## 🧠 Expérience utilisateur (UX)

Un soin particulier est apporté à l’expérience utilisateur :

- Validation visuelle immédiate des champs (bordures rouges)
- Feedback en temps réel lors de la saisie
- Résumé discret et lisible des données avant validation
- Interfaces non surchargeantes, claires et cohérentes
- Comportements intelligents selon le contexte (ex : type de chauffage)

🎯 Objectif : une application compréhensible, même sans connaissances techniques.

---

## 🏗️ **Architecture du projet**

```
GestionnaireDeLogement/
├── 📁 Ressources/                      # Ressources visuelles centralisées
│   ├── Icons/                          # Icônes (.png, .svg)
│   ├── Emojis/                         # Emojis personnalisés
│   └── Images/                         # Images diverses
│
├── 📁 Donnees/                         # Gestion des données
│   └── GestionnaireDonnees.cs          # Gestionnaire JSON (chargement / sauvegarde)
│
├── 📁 Modeles/                         # Modèles de données
│   ├── Facture.cs                      # Modèle Facture
│   ├── ReleveEau.cs                    # Modèle Relevé Eau
│   ├── ReleveElectricite.cs            # Modèle Relevé Électricité
│   ├── ReleveChauffage.cs              # Modèle Relevé Chauffage
│   ├── AchatEchelonne.cs               # Modèle Achat échelonné (à venir)
│   └── Logement.cs                     # Modèle Logement (à venir)
│
├── 📁 Chauffage/                       # Module Chauffage (structuré)
│   ├── 📁 Vues/
│   │   ├── ChauffageVue.xaml           # ✅ Vue principale Chauffage
│   │   ├── ChauffageVue.xaml.cs
│   │   │
│   │   └── 📁 RelevesChauffage/        # Fenêtres liées aux relevés
│   │       ├── AjouterReleveChauffageVue.xaml
│   │       ├── AjouterReleveChauffageVue.xaml.cs
│   │       ├── ModifierReleveChauffageVue.xaml      # (prévu / en cours)
│   │       └── ModifierReleveChauffageVue.xaml.cs
│   │
│   └── 📁 VueModeles/
│       └── ChauffageVueModele.cs       # ViewModel Chauffage (MVVM)
│
├── 📁 Vues/                            # Vues principales de navigation
│   ├── AccueilVue.xaml                 # ✅ Page d'accueil (tableau de bord)
│   ├── AccueilVue.xaml.cs
│   ├── FacturesVue.xaml                # ✅ Gestion des factures
│   ├── FacturesVue.xaml.cs
│   ├── EauVue.xaml                     # ✅ Gestion de l'eau
│   ├── EauVue.xaml.cs
│   ├── ElectriciteVue.xaml             # ✅ Gestion de l'électricité
│   ├── ElectriciteVue.xaml.cs
│   ├── AchatsVue.xaml                  # ⚪ Achats échelonnés (à venir)
│   ├── StatistiquesVue.xaml            # ⚪ Statistiques (à venir)
│   └── ParametresVue.xaml              # ⚪ Paramètres (à venir)
│
├── 📁 Styles/                          # Styles et thèmes centralisés
│   ├── Couleurs.xaml                   # 🎨 Dictionnaire de couleurs global
│   ├── StylesBoutons.xaml              # Styles boutons (en cours)
│   └── StylesTextes.xaml               # Styles textes (en cours)
│
├── 📁 Utilitaires/                     # Helpers & outils
│   ├── Convertisseurs/                 # Convertisseurs XAML (à venir)
│   └── Assistants/                     # Fonctions utilitaires (à venir)
│
├── 📁 Configurations/                  # Données utilisateur (ignorées par Git)
│   ├── factures.json
│   ├── releves_eau.json
│   ├── releves_electricite.json
│   ├── releves_chauffage.json
│   └── logement.json
│
├── 📄 README.md                        # Présentation du projet
├── 📄 CHANGELOG.md                     # Historique des versions
├── 📄 PATCH_NOTES.md                   # Notes techniques détaillées
├── 📄 FEUILLE_DE_ROUTE.md              # Roadmap complète
├── 📄 GUIDE_GITHUB_DESKTOP.md          # Guide GitHub Desktop
├── 📄 EXEMPLES_COMMITS.md              # Exemples de commits
├── 📄 LICENSE.txt                      # Licence CC BY-NC 4.0
├── 📄 .gitignore
└── 📄 .gitattributes
```

---

## 🛠️ **Technologies utilisées**

| Technologie | Version | Usage |
|-------------|---------|-------|
| **C#** | 12.0 | Langage principal |
| **.NET** | 8.0 LTS | Framework |
| **WPF** | Windows Desktop | Interface graphique |
| **XAML** | - | Conception d'interface |
| **JSON** | System.Text.Json | Stockage des données |
| **Draw.io** | - | Maquettage des interfaces |
| **Git** | - | Versioning du code |
| **IA** | - | Assistance au développement |

---

## 📚 **Documentation du projet**

Ce projet contient une documentation complète pour faciliter le développement et la maintenance :

### **📖 Documentation utilisateur**
- **[README.md](README.md)** _(ce fichier)_ - Présentation générale du projet
- **[CHANGELOG.md](CHANGELOG.md)** - Historique des versions et modifications
- **GUIDE_UTILISATEUR.md** _(à venir en v1.0.1)_ - Guide d'utilisation complet et simplifié

### **🛠️ Documentation technique**
- **[PATCH_NOTES.md](PATCH_NOTES.md)** - Notes techniques détaillées de chaque version
- **[FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md)** - Roadmap complète du projet (versions 1.0 à 3.0)

### **🐙 Documentation Git & GitHub**
- **[GUIDE_GITHUB_DESKTOP.md](GUIDE_GITHUB_DESKTOP.md)** - Guide complet d'utilisation de GitHub Desktop
- **[EXEMPLES_COMMITS.md](EXEMPLES_COMMITS.md)** - Exemples de messages de commit professionnels

## 📝 **Licence**

Ce projet est distribué sous la licence :

### **Creative Commons Attribution – NonCommercial 4.0 International (CC BY-NC 4.0)**

### ✔️ Autorisé
- Utilisation personnelle
- Étude et apprentissage
- Modification du code source
- Redistribution non commerciale

### ❌ Interdit
- Toute utilisation commerciale
- La vente du logiciel ou d’une version dérivée
- L’intégration dans un produit payant

### 🔖 Attribution obligatoire
Toute utilisation, modification ou redistribution doit conserver :
- **Créateur original** : Flo (Latury)
- **Projet** : Gestionnaire de Logement
- **Dépôt GitHub** : https://github.com/Latury/GestionnaireDeLogement

📄 Voir le fichier [LICENSE.txt](LICENSE.txt) pour le texte complet de la licence.

---

## 📋 **Roadmap**

### Version 1.0.0-dev — Fondations & UX (actuel)

**📌 Objectif : poser une base saine, compréhensible et agréable à utiliser**

✅ **Terminé**
🔲 **À faire**

- ✅ Structure générale du projet WPF (.NET 8)
- ✅ Organisation claire des dossiers (Modules, Vues, ViewModels)

- ✅ **Modèles de données principaux:**
- 🔲 Facture
- 🔲 Relevé Eau
- 🔲 Relevé Électricité
- 🔲 Relevé Chauffage

- 🔲 **Pages principales de navigation:**
- 🔲 Accueil (Tableau de bord)
- 🔲 Eau
- 🔲 Électricité
- 🔲 Chauffage
- 🔲 Factures
- ✅ Système de styles centralisé (Couleurs.xaml)

- ✅ **Module **Chauffage** le plus avancé:**
- 🔲 Fenêtre dédiée d’ajout de relevé
- 🔲 Validation visuelle immédiate (bordures rouges)
- 🔲 Adaptation automatique de l’unité selon le type
- 🔲 Désactivation intelligente de champs
- 🔲 Résumé en temps réel discret

- ✅ UX cohérente et moderne sur l’ensemble des vues
- ✅ Documentation complète (README, roadmap, patch notes, etc.)
- ✅ Licence CC BY-NC 4.0 appliquée à tout le projet

🟠 En cours

- 🔲 Connexion réelle des formulaires au système de sauvegarde JSON
- 🔲 Finalisation des formulaires d’ajout/modification (Eau / Électricité)
- 🔲 Harmonisation complète UX entre tous les modules

### 🟢 Version 1.0.1 — Stabilisation (prochaine étape)

**📌 Objectif : fiabilité et cohérence fonctionnelle**

- 🔲 Connexion complète au stockage JSON (CRUD réel)
- 🔲 Tests manuels de toutes les pages
- 🔲 Corrections de bugs UX / logique
- 🔲 Validation utilisateur renforcée (messages + visuel)
- 🔲 Guide utilisateur simplifié (GUIDE_UTILISATEUR.md)
- 🔲 Nettoyage et commentaires finaux du code

### 🔵 Version 1.1.0 — Fonctionnalités avancées

**📌 Objectif : commencer l’analyse et la valeur ajoutée:**

- 🔲 Graphiques et statistiques avancées
- 🔲 Comparaisons avancées mois / mois
- 🔲 Module avancées **Achats échelonnés**
- 🔲 Calculs automatiques (coûts, totaux)
- 🔲 Premiers tableaux de statistiques

### 🟣 Version 1.2.0 — Confort & automatisation

**📌 Objectif : rendre l’application plus intelligente et agréable**	

- 🔲 Alertes (factures, échéances)
- 🔲 Rappels visuels
- 🔲 Vue calendrier
- 🔲 Amélioration des performances
- 🔲 Début du système de paramètres utilisateur

### 🟠 Version 2.0.0 — Maturité

**📌 Objectif : version stable et complète pour un usage quotidien**	

- 🔲 Export PDF / CSV
- 🔲 Import de données
- 🔲 Sauvegarde automatique
- 🔲 Gestion multi-logements
- 🔲 Thèmes personnalisables
- 🔲 Installateur Windows (.exe / .msi) 

### 🔴 Version 3.0.0 — Long terme

**📌 Objectif : fonctionnalités avancées et mobilité**

- 🔲 Synchronisation cloud (optionnelle)
- 🔲 Application mobile compagnon
- 🔲 Accès multi-appareils

### 🧭 Philosophie de la roadmap

-Pas de promesses irréalistes
-Chaque version a un objectif clair
-Le projet reste pédagogique et évolutif
-La priorité est donnée à la compréhension et à l’UX, pas à la course aux fonctionnalités

📖 **Voir [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md) pour le détail complet de la roadmap**

---

## 🎨 **Système de couleurs**

Le projet utilise un système de couleurs centralisé dans `Styles/Couleurs.xaml` afin de garantir une cohérence visuelle globale.

- **Couleurs principales** : Bleu (#3B82F6), Bleu foncé (#2563EB), Bleu clair (#60A5FA)
- **Succès** : Vert (#10B981)
- **Alertes** : Orange (#F59E0B), Jaune (#FBBF24)
- **Erreurs** : Rouge (#EF4444)
- **Neutres** : Palette de gris (Gris50 à Gris900)
- **Spécifiques** : Bleu eau (#06B6D4), Jaune électricité (#FBBF24), Orange chauffage (#F97316)

🎯 Objectif : lisibilité, contraste suffisant et feedback visuel immédiat.

---

## 🔒 **Sécurité des données**

- **Stockage 100 % local** : Toutes les données sont stockées localement sur votre machine, aucune donnée n’est envoyée sur internet
- **Format JSON** : fichiers lisibles, récupérables et transparents
- **Aucune dépendance cloud** : dans la version actuelle
- **Respect de la vie privée** : aucune télémétrie, aucun tracking
- **Backup** : Système de sauvegarde automatique (à venir en v2.0)
- **Aucune connexion externe** : Aucune donnée n'est envoyée sur internet (sauf si synchronisation cloud activée en v3.0)

---

## 👤 **Auteur**

**Latury**  
📧 Email : latury57@gmail.com  
🐙 GitHub : https://github.com/Latury  
🌍 Localisation : France  
💼 Statut : Développeur débutant en apprentissage

---

## 🙏 **Remerciements**

- **Microsoft** pour le framework .NET 8.0 et WPF
- **La communauté C# / WPF** pour les nombreuses ressources et exemples
- **GitHub** pour l’hébergement du projet et le versioning
- **Draw.io** pour le maquettage des interfaces
- **Jarvis (IA d’assistance) 🤖** Pour l’accompagnement pédagogique, l’aide à la structuration du projet, la réflexion UX et la vulgarisation des concepts complexes tout au long du développement

---

## 📞 **Support et Contact**

### **Besoin d'aide ?**
- 📖 Consultez la [documentation complète](GUIDE_GITHUB_DESKTOP.md)
- 🐛 Signalez un bug via [GitHub Issues](https://github.com/Latury/GestionnaireDeLogement/issues)
- 💬 Des questions sur le projet ? Créez une nouvelle [Issue](https://github.com/Latury/GestionnaireDeLogement/issues) et décrivez votre problème

### **Contribuer au projet**
Les contributions sont les bienvenues ! Consultez [EXEMPLES_COMMITS.md](EXEMPLES_COMMITS.md) pour les conventions de commit.

---

## 📊 **Statistiques du projet**

- **Langage principal** : C# (100 %)
- **Framework** : WPF (.NET 8.0 LTS)
- **Architecture** : MVVM hybride (en cours de structuration)
- **Modules fonctionnels actifs** : 4 (Eau, Électricité, Chauffage, Factures)
- **Pages / Fenêtres implémentées** : 6
  - AccueilVue
  - FacturesVue
  - EauVue
  - ElectriciteVue
  - ChauffageVue
  - Fenêtres d’ajout / modification de relevés
- **Formulaires avancés** : Chauffage (validation UX, adaptation contextuelle)
- **Validation utilisateur** : Visuelle + métier (bordures, contrôles, messages)
- **Stockage des données** : JSON local (structure prête, liaison progressive)
- **Lignes de code** : ~1 500 lignes (XAML + C#)
- **Documentation** : 7 fichiers Markdown maintenus
- **Licence** : CC BY-NC 4.0 (usage commercial interdit)
- **Statut global** : Projet d’apprentissage actif – **≈ 75 % de la version 1.0.0**

---

## 🎯 **Prochaines étapes de développement**

1. **Phase 1** : ✅ Création des modèles de données (Facture, ReleveEau, ReleveElectricite)
2. **Phase 2** : ✅ Implémentation des pages de gestion (Factures, Eau, Électricité, Chauffage)
3. **Phase 3** : 🔵 Connexion progressive des pages au système de sauvegarde JSON (lecture / écriture réelle des données)
4. **Phase 4** : ⚪ Finalisation des formulaires d’ajout / modification (validation UX complète, cohérence entre modules)
5. **Phase 5** : ⚪ Ajout des graphiques et statistiques (visualisation des consommations et coûts)
6. **Phase 6** : ⚪ Tests, stabilisation et rédaction du guide utilisateur

📖 **Suivez l'avancement dans [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md)**

---

<div align="center">

**⭐ Si ce projet vous plaît ou vous aide dans votre apprentissage, n'hésitez pas à lui donner une étoile ! ⭐**

**Développé en France 🇫🇷 | Projet open-source et éducatif**

---

**Version 1.0.0-dev** **• Dernière mise à jour : 03 Février 2026**

</div>