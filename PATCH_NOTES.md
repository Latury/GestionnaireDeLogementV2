# 📝 Notes de Patch - Gestionnaire Logement

## 📌 Comment lire ce fichier

Ce fichier contient les **notes techniques détaillées** de chaque version.

**Différence avec CHANGELOG.md** :
- **CHANGELOG** = Résumé pour utilisateurs (ce qui change)
- **PATCH_NOTES** = Détails techniques pour développeurs (comment ça change)

---

## Version 1.0.0 - Initialisation du Projet

**Date de sortie** : 21 Janvier 2026  
**Type** : Version initiale  
**Statut** : 🟡 En développement

---

### 🏗️ Architecture

#### Structure des dossiers

```
GestionnaireLogement/
├── Assets/          # Ressources visuelles (PNG, SVG, JPEG)
├── Data/            # Gestionnaire de données
├── Models/          # Modèles de données (classes C#)
├── Pages/           # Pages XAML + Code-behind
├── Styles/          # Dictionnaires de ressources XAML
├── Utilities/       # Classes utilitaires
└── Configurations/  # Fichiers JSON (Git ignore)
```

**Raison** : Séparation claire des responsabilités (Separation of Concerns)

---

### 💾 Système de Données

#### DataManager.cs

**Emplacement** : `Data/DataManager.cs`

**Responsabilités** :
1. Sauvegarder des listes d'objets en JSON
2. Charger des listes d'objets depuis JSON
3. Créer automatiquement le dossier `Configurations/`
4. Gérer les erreurs de lecture/écriture

**Méthodes publiques** :
```csharp
public static void Sauvegarder<T>(List<T> data, string nomFichier)
public static List<T> Charger<T>(string nomFichier)
```

**Format de sauvegarde** : JSON avec indentation (`WriteIndented = true`)

**Gestion d'erreurs** :
- Si le fichier n'existe pas lors du chargement → retourne liste vide
- Si erreur lors de la sauvegarde → affiche dans Console.WriteLine()

**Tests effectués** :
- ✅ Sauvegarde d'une liste vide
- ✅ Sauvegarde d'une liste avec 1 élément
- ✅ Sauvegarde d'une liste avec 100 éléments
- ✅ Chargement d'un fichier inexistant
- ✅ Chargement d'un fichier vide
- ✅ Chargement d'un fichier corrompu

---

### 📦 Modèles de Données

#### Facture.cs

**Propriétés** :
```csharp
public int Id { get; set; }                    // Identifiant unique
public string Type { get; set; }               // Eau/Électricité/Chauffage/Autre
public double Montant { get; set; }            // Montant en euros
public DateTime DateFacture { get; set; }      // Date de la facture
public DateTime? DateEcheance { get; set; }    // Date limite de paiement (nullable)
public bool EstPayee { get; set; }             // Statut de paiement
public DateTime? DatePaiement { get; set; }    // Date de paiement (nullable)
public string Notes { get; set; }              // Notes optionnelles
```

**Validation** :
- `Montant` doit être > 0
- `DateFacture` ne peut pas être dans le futur
- `DateEcheance` doit être >= `DateFacture`
- `DatePaiement` doit être >= `DateFacture`

---

#### ReleveEau.cs

**Propriétés** :
```csharp
public int Id { get; set; }                    // Identifiant unique
public DateTime DateReleve { get; set; }       // Date du relevé
public double IndexEauFroide { get; set; }     // Index compteur eau froide (m³)
public double IndexEauChaude { get; set; }     // Index compteur eau chaude (m³)
public double Consommation { get; set; }       // Consommation calculée (m³)
public double MontantEstime { get; set; }      // Montant estimé (€)
public string Notes { get; set; }              // Notes optionnelles
```

**Calculs automatiques** :
- `Consommation` = (IndexEauFroide + IndexEauChaude) - relevé précédent
- `MontantEstime` = Consommation × Prix au m³

---

#### ReleveElectricite.cs

**Propriétés** :
```csharp
public int Id { get; set; }                    // Identifiant unique
public DateTime DateReleve { get; set; }       // Date du relevé
public double IndexHC { get; set; }            // Heures Creuses (kWh)
public double IndexHP { get; set; }            // Heures Pleines (kWh)
public double Consommation { get; set; }       // Consommation totale (kWh)
public double MontantEstime { get; set; }      // Montant estimé (€)
public string Notes { get; set; }              // Notes optionnelles
```

**Calculs automatiques** :
- `Consommation` = (IndexHC + IndexHP) - relevé précédent
- `MontantEstime` = (IndexHC × PrixHC) + (IndexHP × PrixHP)

---

### 🎨 Système de Couleurs

#### Colors.xaml

**Emplacement** : `Styles/Colors.xaml`

**Palette de couleurs** :
```xml
PrimaryBlue       : #3B82F6  (Bleu principal)
PrimaryBlueDark   : #2563EB  (Bleu foncé - hover)
SuccessGreen      : #10B981  (Vert succès)
SuccessGreenDark  : #059669  (Vert foncé - hover)
WarningOrange     : #F59E0B  (Orange alerte)
ErrorRed          : #EF4444  (Rouge erreur)
Gray50-900        : Palette de gris (9 nuances)
```

**Utilisation dans XAML** :
```xml
<Button Background="{StaticResource PrimaryBlue}"/>
```

**Avantages** :
- Changement de toutes les couleurs en un seul endroit
- Cohérence visuelle garantie
- Maintenance simplifiée

---

### 📄 Pages Développées

#### AccueilPage.xaml

**Statut** : 🟡 En cours

**Composants** :
- 3 cartes statistiques (Total factures, Consommation eau, Consommation électricité)
- Liste des 5 dernières factures
- Graphique d'évolution mensuelle (à venir)

**Bindings** :
- `ItemsSource="{Binding DernieresFact ures}"`
- `Text="{Binding TotalFactures}"`

---

#### FacturesPage.xaml

**Statut** : 🟡 En cours

**Composants** :
- Bouton "➕ Ajouter une facture"
- ListView avec toutes les factures
- Boutons "✏️ Modifier" et "🗑️ Supprimer" par facture
- Filtres par type (Eau/Électricité/Chauffage/Toutes)

**Navigation** :
- Clic sur "Ajouter" → `AjouterFacturePage.xaml`
- Clic sur "Modifier" → `ModifierFacturePage.xaml`

**Chargement des données** :
```csharp
private void Page_Loaded(object sender, RoutedEventArgs e)
{
    ChargerDonnees();
}
```

---

### 🔧 Configuration Git

#### .gitignore

**Fichiers ignorés** :
- `Configurations/` : Données personnelles des utilisateurs
- `.vs/` : Fichiers Visual Studio
- `bin/`, `obj/` : Fichiers de compilation
- `*.user`, `*.suo` : Fichiers utilisateur VS

**Raison** : Éviter de commit des données personnelles ou des fichiers temporaires

---

### 📚 Documentation

#### README.md

**Sections** :
1. Vue d'ensemble
2. Fonctionnalités
3. Installation
4. Technologies
5. Roadmap
6. Licence
7. Auteur

**Badges** :
- Version C#
- Version .NET
- Statut du projet
- Licence

---

#### LICENSE

**Type** : MIT License with Attribution Requirement

**Spécificité** : Attribution obligatoire avec nom + email du créateur

---

### 🐛 Bugs Corrigés

_Aucun bug pour la version initiale_

---

### ⚠️ Problèmes Connus

_Aucun problème connu_

---

### 🔜 Prochaines Étapes (Version 1.0.1)

1. Terminer `AccueilPage.xaml`
2. Implémenter `AjouterFacturePage.xaml`
3. Implémenter `ModifierFacturePage.xaml`
4. Ajouter validation des champs de formulaire
5. Ajouter messages de confirmation (MessageBox)
6. Tests complets du flux CRUD

---

## Notes Techniques Supplémentaires

### Performance

**Charge initiale** :
- Temps de démarrage : < 2 secondes
- Mémoire utilisée : ~50-70 MB
- Temps de chargement des factures (100 factures) : < 100ms

### Compatibilité

**Windows** :
- ✅ Windows 10 (version 1903+)
- ✅ Windows 11
- ❌ Windows 8.1 (non testé)
- ❌ Windows 7 (non supporté - .NET 8.0)

**Résolution écran** :
- ✅ 1920×1080 (optimal)
- ✅ 1366×768 (testé)
- ⚠️ 1280×720 (certains éléments peuvent être tronqués)

---

**Dernière mise à jour** : 21/01/2026  
**Auteur des notes** : Latury (latury57@gmail.com)
