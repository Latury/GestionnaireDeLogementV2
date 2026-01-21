<div align="center">

# 🏠 **Gestionnaire de Logement**

**Application WPF de gestion complète de logement**

![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp&logoColor=white&labelColor=384454)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white&labelColor=384454)
![WPF](https://img.shields.io/badge/WPF-Windows-0078D4?style=for-the-badge&logo=windows&logoColor=white&labelColor=384454)
![VERSION](https://img.shields.io/badge/VERSION-V1.0.0-F9DC5C?style=for-the-badge&logo=git&logoColor=white&labelColor=384454)
![STATUT](https://img.shields.io/badge/STATUT-EN%20DÉVELOPPEMENT-FFA500?style=for-the-badge&logo=checkmarx&logoColor=white&labelColor=384454)

_Développé par [Latury](https://github.com/Latury)_

---

💧 Eau • ⚡ Électricité • 🔥 Chauffage • 💳 Achats • 📊 Statistiques

</div>

---

## 🎯 **Vue d'ensemble**

**Gestionnaire de Logement** est une application de bureau Windows qui permet de gérer tous les aspects d'un logement : factures, consommations d'eau et d'électricité, chauffage, achats échelonnés, et budget mensuel.

**Version actuelle :** `1.0.0` (21/01/2026)  
**Statut :** 🟡 **En développement actif**

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
- Historique complet avec dates
- Graphiques d'évolution mensuelle et annuelle
- Estimation du montant basé sur le prix au m³

### **⚡ Gestion de l'électricité**
- Suivi des relevés de compteur (heures creuses et heures pleines)
- Calcul de la consommation en kWh
- Comparaison mensuelle et détection des variations
- Détection des pics de consommation anormaux
- Estimation du coût selon le tarif HC/HP

### **🔥 Gestion du chauffage**
- Suivi des relevés de consommation
- Calcul des coûts mensuels et annuels
- Statistiques saisonnières (hiver vs été)
- Comparaison avec les années précédentes

### **🧾 Gestion des factures**
- Ajout, modification et suppression de factures
- Catégorisation automatique (Eau, Électricité, Chauffage, Autre)
- Suivi du statut de paiement
- Alertes pour factures impayées
- Historique complet avec recherche et filtres
- Notes personnalisées par facture

### **💳 Achats échelonnés**
- Gestion des achats en plusieurs fois (crédits)
- Calcul automatique des mensualités
- Suivi des paiements effectués et restants
- Alertes d'échéances proches (7 jours)
- Vue calendrier des paiements à venir
- Calcul du coût total avec intérêts

### **📊 Tableaux de bord et statistiques**
- Vue d'ensemble des consommations du mois
- Graphiques interactifs et dynamiques
- Statistiques mensuelles et annuelles
- Comparaison avec les périodes précédentes
- Calcul automatique des économies réalisées
- Prévisions basées sur l'historique

### **🏡 Mon logement**
- Fiche d'informations du logement
- Surface, nombre de pièces, type de chauffage
- Prix de référence pour eau, électricité, chauffage
- Historique de modification

---

## 🏗️ **Architecture du projet**

```
GestionnaireDeLogement/
├── 📁 Ressources/ # Ressources visuelles centralisées
│ ├── Icons/ # Icônes (.png, .svg)
│ ├── Emojis/ # Emojis personnalisés
│ └── Images/ # Images diverses
│
├── 📁 Donnees/ # Gestion des données
│ └── GestionnaireDonnees.cs # Gestionnaire de fichiers JSON
│
├── 📁 Modeles/ # Modèles de données
│ ├── Facture.cs # Modèle Facture
│ ├── ReleveEau.cs # Modèle Relevé Eau
│ ├── ReleveElectricite.cs # Modèle Relevé Électricité
│ ├── AchatEchelonne.cs # Modèle Achat échelonné
│ └── Logement.cs # Modèle Logement
│
├── 📁 Vues/ # Vues de l'application (XAML + C#)
│ ├── AccueilVue.xaml # Page d'accueil (tableau de bord)
│ ├── FacturesVue.xaml # Gestion des factures
│ ├── EauVue.xaml # Gestion de l'eau
│ ├── ElectriciteVue.xaml # Gestion de l'électricité
│ └── ... # Autres vues
│
├── 📁 Styles/ # Styles et thèmes
│ ├── Couleurs.xaml # Dictionnaire de couleurs centralisé
│ ├── StylesBoutons.xaml # Styles pour les boutons
│ └── StylesTextes.xaml # Styles pour les textes
│
├── 📁 Utilitaires/ # Utilitaires et helpers
│ ├── Convertisseurs/ # Convertisseurs XAML
│ └── Assistants/ # Fonctions helper
│
└── 📁 Configurations/ # Fichiers de données (Git ignore)
├── factures.json
├── releves_eau.json
├── releves_electricite.json
└── logement.json
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

### **⚖️ Licence**
- **[LICENSE.txt](LICENSE.txt)** - Licence MIT avec attribution obligatoire

---

## 📋 **Roadmap**

### Version 1.0.0 (En cours - Février 2026)
- [x] Structure de base du projet
- [x] Documentation complète
- [x] Système de sauvegarde JSON
- [ ] Modèles de données (Facture, ReleveEau, ReleveElectricite)
- [ ] Gestion des factures (CRUD complet)
- [ ] Gestion de l'eau
- [ ] Gestion de l'électricité
- [ ] Interface d'accueil avec tableau de bord

### Version 1.0.1 (Stabilisation - Février 2026)
- [ ] Tests complets de toutes les fonctionnalités
- [ ] Corrections de bugs
- [ ] **Guide utilisateur simplifié (GUIDE_UTILISATEUR.md)**
- [ ] Tutoriel de prise en main rapide
- [ ] FAQ (Questions fréquentes)

### Version 1.1.0 (Mars 2026)
- [ ] Graphiques et statistiques avancées
- [ ] Gestion du chauffage
- [ ] Achats échelonnés
- [ ] Comparaisons mensuelles
- [ ] Détection automatique des économies
- [ ] Mode sombre (thème nuit)

### Version 1.2.0 (Avril 2026)
- [ ] Alertes et notifications
- [ ] Calendrier des paiements
- [ ] Rappels d'échéances
- [ ] Vue calendrier complète

### Version 2.0.0 (Mai-Juin 2026)
- [ ] Export PDF des factures et statistiques
- [ ] Export Excel/CSV pour analyse
- [ ] Import de données existantes
- [ ] Backup automatique
- [ ] Gestion multi-logements
- [ ] Thèmes personnalisables
- [ ] **Installateur Windows (.exe / .msi)**

### Version 3.0.0 (Septembre 2026)
- [ ] Synchronisation cloud (OneDrive, Google Drive)
- [ ] Application mobile compagnon (Android/iOS)
- [ ] Accès multi-appareils

📖 **Voir [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md) pour le détail complet de la roadmap**

---

## 🎨 **Système de couleurs**

Le projet utilise un système de couleurs centralisé dans `Styles/Couleurs.xaml` :

- **Couleurs principales** : Bleu (#3B82F6), Bleu foncé (#2563EB), Bleu clair (#60A5FA)
- **Succès** : Vert (#10B981)
- **Alertes** : Orange (#F59E0B), Jaune (#FBBF24)
- **Erreurs** : Rouge (#EF4444)
- **Neutres** : Palette de gris (Gris50 à Gris900)
- **Spécifiques** : Bleu eau (#06B6D4), Jaune électricité (#FBBF24), Orange chauffage (#F97316)

---

## 🔒 **Sécurité des données**

- **Stockage local** : Toutes les données sont stockées localement sur votre machine
- **Format JSON** : Fichiers lisibles et facilement récupérables
- **Backup** : Système de sauvegarde automatique (à venir en v2.0)
- **Aucune connexion externe** : Aucune donnée n'est envoyée sur internet (sauf si synchronisation cloud activée en v3.0)

---

## 📝 **Licence**

Ce projet est sous **licence MIT avec attribution obligatoire**.

### **Conditions d'utilisation**
- ✅ **Utilisation libre** (personnelle uniquement)
- ✅ **Modification autorisée**
- ✅ **Distribution autorisée**
- ⚠️ **Attribution obligatoire** : Vous devez conserver les informations du créateur original

### **Attribution requise**
Toute utilisation, modification ou distribution doit conserver :
- Nom du créateur : **Latury**
- Contact : **latury57@gmail.com**
- Lien du projet : [**https://github.com/Latury/GestionnaireDeLogement**]

📄 **Voir le fichier [LICENSE.txt](LICENSE.txt) pour le texte complet de la licence**

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
- **La communauté open-source C#** pour les ressources et tutoriels
- **GitHub** pour l'hébergement du code source
- **Draw.io** pour le maquettage d'interface
- **Les outils d'IA** pour l'assistance au développement

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

- **Langage principal** : C# (100%)
- **Framework** : WPF .NET 8.0
- **Architecture** : MVVM (prévu)
- **Lignes de code** : En croissance...
- **Documentation** : 7 fichiers markdown complets
- **Statut** : Projet d'apprentissage actif

---

## 🎯 **Prochaines étapes de développement**

1. **Phase 1** : Création des modèles de données (Facture, ReleveEau, ReleveElectricite)
2. **Phase 2** : Implémentation des pages de gestion (Factures, Eau, Électricité)
3. **Phase 3** : Développement du tableau de bord principal
4. **Phase 4** : Ajout des graphiques et statistiques
5. **Phase 5** : Tests, stabilisation et rédaction du guide utilisateur

📖 **Suivez l'avancement dans [FEUILLE_DE_ROUTE.md](FEUILLE_DE_ROUTE.md)**

---

<div align="center">

**⭐ Si ce projet vous plaît ou vous aide dans votre apprentissage, n'hésitez pas à lui donner une étoile ! ⭐**

**Développé en France 🇫🇷 | Projet open-source et éducatif**

---

**Version 1.0.0** • **Dernière mise à jour : 21 janvier 2026**

</div>
