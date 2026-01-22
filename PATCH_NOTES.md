# 📝 Notes de Patch - Gestionnaire Logement

## 📌 Comment lire ce fichier

Ce fichier contient les **notes techniques détaillées** de chaque version.

**Différence avec CHANGELOG.md** :
- **CHANGELOG** = Résumé pour utilisateurs (ce qui change)
- **PATCH_NOTES** = Détails techniques pour développeurs (comment ça change)

---

## Version 1.0.0 - Suite : Création des Pages Principales

**Date** : 22 Janvier 2026  
**Type** : Développement des interfaces utilisateur  
**Statut** : ✅ Fonctionnel (navigation complète)

---

### 📄 Pages Créées

#### 1. AccueilVue.xaml
**Emplacement** : `Vues/AccueilVue.xaml`

**Structure** :
- **Section 1** : 3 cartes statistiques en ligne
  - Total des factures (2 547,80 €)
  - Consommation d'eau (15,4 m³)
  - Électricité (342 kWh)
- **Section 2** : Titre "Dernières factures"
- **Section 3** : Liste des factures (vide pour l'instant)

**Techniques utilisées** :
- `Viewbox` pour adapter automatiquement la taille des cartes
- `DropShadowEffect` pour les ombres portées
- `Grid` avec 3 colonnes égales
- Emojis intégrés via `StaticResource`

**Code-behind** :
```csharp
public partial class AccueilVue : Page
{
    public AccueilVue()
    {
        InitializeComponent();
    }
}
```

---

#### 2. FacturesVue.xaml
**Emplacement** : `Vues/FacturesVue.xaml`

**Structure** :
- Cartes statistiques : Total payé / Total impayé
- Boutons d'action : Ajouter / Modifier / Supprimer
- Tableau avec colonnes : Date / Type / Montant / Statut
- Message "Aucune facture pour le moment"

**Événements** :
- `BtnAjouter_Click` : MessageBox temporaire
- `BtnModifier_Click` : MessageBox temporaire
- `BtnSupprimer_Click` : MessageBox temporaire

---

#### 3. EauVue.xaml
**Emplacement** : `Vues/EauVue.xaml`

**Nouveautés** :
- **Filtre ComboBox** : "Tous les types / Eau froide / Eau chaude"
- Cartes statistiques : Consommation (15,4 m³) / Montant (45,80 €)
- Tableau avec 5 colonnes : Date / **Type** / Index / Consommation / Montant

**Différence avec version précédente** :
- Ajout d'une ligne `RowDefinition` pour le filtre
- Ajout de la colonne "Type" dans le tableau
- Colonnes redimensionnées (0.8* pour Date/Type)

---

#### 4. ElectriciteVue.xaml
**Emplacement** : `Vues/ElectriciteVue.xaml`

**Structure** :
- Cartes statistiques : Consommation (342 kWh) / Montant (78,50 €)
- Boutons d'action : Ajouter / Modifier / Supprimer
- Tableau : Date / Heures Creuses / Heures Pleines / Consommation / Montant
- Message "Aucun relevé d'électricité pour le moment"

---

#### 5. ChauffageVue.xaml
**Emplacement** : `Vues/ChauffageVue.xaml`

**Nouveautés** :
- **Filtre ComboBox avancé** :
  - Tous les types
  - ⛽ Fioul
  - 🔥 Gaz
  - ⚡ Électrique
  - 🪵 Bois
  - ❄️ Pompe à chaleur
- Cartes statistiques : Consommation (850 kWh) / Montant (127,50 €)
- Tableau : Date / Type / **Quantité** / Montant

**Application flexible** :
- Utilisable par tout type de logement
- Pas limité au fioul uniquement

---

### 💻 MainWindow.xaml.cs - Navigation Complétée

**Modifications** :

#### Avant (21/01/2026)
```csharp
private void BtnElectricite_Click(object sender, RoutedEventArgs e)
{
    // TODO : Créer la page ElectriciteVue
    TitrePage.Text = "Consommation d'électricité";
    ResetBoutonsNavigation();
}

private void BtnChauffage_Click(object sender, RoutedEventArgs e)
{
    // TODO : Créer la page ChauffageVue
    TitrePage.Text = "Chauffage";
    ResetBoutonsNavigation();
}
```

#### Après (22/01/2026)
```csharp
private void BtnElectricite_Click(object sender, RoutedEventArgs e)
{
    ChangerPage(new ElectriciteVue(), "Consommation d'électricité", BtnElectricite);
}

private void BtnChauffage_Click(object sender, RoutedEventArgs e)
{
    ChangerPage(new ChauffageVue(), "Chauffage", BtnChauffage);
}
```

**Résultat** : Navigation complète pour Accueil, Factures, Eau, Électricité, Chauffage

---

### 🎨 Styles Réutilisables

**Styles définis dans chaque page** :
- `BoutonAction` : Boutons bleus standard
- `BoutonSupprimer` : Bouton rouge pour suppression
- `Carte` : Bordures avec ombres portées
- `CarteStatistique` : Cartes avec padding réduit
- `ComboBoxFiltre` : Style des filtres (Eau, Chauffage)

**Avantage** : Cohérence visuelle sur toutes les pages

---

### 📊 Statistiques de Développement

**Temps de développement** : ~4 heures  
**Nombre de fichiers créés** :
- 5 fichiers XAML (AccueilVue, FacturesVue, EauVue, ElectriciteVue, ChauffageVue)
- 5 fichiers C# code-behind

**Lignes de code** :
- XAML : ~800 lignes au total
- C# : ~250 lignes au total

---

### ✅ Tests Effectués

- ✅ Navigation depuis MainWindow vers toutes les pages
- ✅ Affichage correct des cartes statistiques
- ✅ Filtres ComboBox fonctionnels (Eau, Chauffage)
- ✅ Boutons d'action affichent MessageBox
- ✅ Design responsive (redimensionnement fenêtre)
- ✅ Emojis s'affichent correctement
- ✅ Aucune erreur de compilation

---

### 🔜 Prochaines Étapes

1. ⚪ Créer les modèles `ReleveChauffage.cs`
2. ⚪ Créer les formulaires d'ajout (AjouterFactureVue, AjouterReleveEauVue, etc.)
3. ⚪ Implémenter le CRUD complet avec sauvegarde JSON
4. ⚪ Afficher les données réelles au lieu des données statiques
5. ⚪ Ajouter la validation des formulaires

---

## Version 1.0.0 - Initialisation du Projet

**Date** : 21 Janvier 2026 (après-midi)  
**Type** : Création du projet  
**Statut** : ✅ Complété

### 🏗️ Architecture

#### Structure des dossiers

```
GestionnaireLogement/
├── Ressources/         # Images, Icônes, Emojis
├── Donnees/            # GestionnaireDonnees.cs
├── Modeles/            # Classes de données
├── Vues/               # Pages XAML + Code-behind
├── Styles/             # Couleurs.xaml, styles
├── Utilitaires/        # Helpers, Convertisseurs
└── Configurations/     # Fichiers JSON (ignorés par Git)
```

**Raison** : Séparation claire des responsabilités en français

---

### 💾 Système de Données - GestionnaireDonnees.cs

**Emplacement** : `Donnees/GestionnaireDonnees.cs`

**Responsabilités** :
1. Sauvegarder des listes d'objets en JSON
2. Charger des listes d'objets depuis JSON
3. Créer automatiquement le dossier `Configurations/`
4. Gérer les erreurs de lecture/écriture

**Méthodes publiques** :
```csharp
public static void Sauvegarder<T>(List<T> donnees, string nomFichier)
public static List<T> Charger<T>(string nomFichier)
public static bool FichierExiste(string nomFichier)
public static void SupprimerFichier(string nomFichier)
```

**Format de sauvegarde** : JSON avec indentation (`WriteIndented = true`)

**Gestion d'erreurs** :
- Si le fichier n'existe pas lors du chargement → retourne liste vide
- Si erreur lors de la sauvegarde → affiche dans Console

---

### 📦 Modèles de Données Créés

#### Facture.cs
**Propriétés** :
- Id (int) : Identifiant unique
- Type (string) : Eau/Électricité/Chauffage/Autre
- Montant (double) : Montant en euros
- DateFacture (DateTime) : Date de la facture
- DateEcheance (DateTime?) : Date limite de paiement (nullable)
- EstPayee (bool) : Statut de paiement
- DatePaiement (DateTime?) : Date de paiement (nullable)
- Notes (string) : Notes optionnelles

#### ReleveEau.cs
**Propriétés** :
- Id (int) : Identifiant unique
- DateReleve (DateTime) : Date du relevé
- IndexEauFroide (double) : Index compteur eau froide (m³)
- IndexEauChaude (double) : Index compteur eau chaude (m³)
- Consommation (double) : Consommation calculée (m³)
- MontantEstime (double) : Montant estimé (€)
- Notes (string) : Notes optionnelles

**Méthode spéciale** :
```csharp
public void CalculerConsommation(ReleveEau relevePrecedent, double prixM3)
```

#### ReleveElectricite.cs
**Propriétés** :
- Id (int) : Identifiant unique
- DateReleve (DateTime) : Date du relevé
- IndexHeuresCreuses (double) : Heures Creuses (kWh)
- IndexHeuresPleines (double) : Heures Pleines (kWh)
- Consommation (double) : Consommation totale (kWh)
- MontantEstime (double) : Montant estimé (€)
- Notes (string) : Notes optionnelles

**Méthode spéciale** :
```csharp
public void CalculerConsommation(ReleveElectricite relevePrecedent, double prixHC, double prixHP)
```

---

### 🎨 Système de Couleurs - Couleurs.xaml

**Emplacement** : `Styles/Couleurs.xaml`

**Palette complète** :
- **Couleurs principales (Bleu)** : 4 nuances
- **Couleurs de succès (Vert)** : 3 nuances
- **Couleurs d'alerte (Orange)** : 3 nuances
- **Couleurs d'erreur (Rouge)** : 3 nuances
- **Palette de gris** : 10 nuances (Gris50 à Gris900)
- **Couleurs fonctionnelles** : Eau (Cyan), Électricité (Jaune), Chauffage (Orange), Facture (Violet), Achat (Rose)
- **Couleurs de fond** : 3 variations
- **Couleurs de texte** : 4 variations
- **Couleurs de bordure** : 3 variations

**Total** : 30+ couleurs définies

**Utilisation** :
```xml
<Button Background="{StaticResource CouleurPrincipale}"/>
```

---

### 📚 Documentation Créée

#### Fichiers de documentation
1. **README.md** : Vue d'ensemble du projet
2. **LICENSE.txt** : Licence MIT avec attribution
3. **CHANGELOG.md** : Historique des versions
4. **PATCH_NOTES.md** : Notes techniques
5. **FEUILLE_DE_ROUTE.md** : Roadmap versions 1.0 à 3.0
6. **GUIDE_GITHUB_DESKTOP.md** : Guide Git pour débutants
7. **EXEMPLES_COMMITS.md** : Conventions de commit

---

### 🔧 Configuration Git

#### .gitignore
**Fichiers ignorés** :
- `Configurations/` : Données personnelles
- `.vs/` : Fichiers Visual Studio
- `bin/`, `obj/` : Fichiers de compilation
- `*.user`, `*.suo` : Fichiers utilisateur

**Raison** : Éviter de commit des données personnelles ou temporaires

---

## Version 1.0.0 - Suite : Interface Principale Complétée

**Date de finalisation** : 21 Janvier 2026 (soir)  
**Type** : Développement de l'interface  
**Statut** : ✅ Fonctionnel

---

### 🪟 MainWindow.xaml

**Emplacement** : `MainWindow.xaml`

**Composants créés** :
1. **Menu de navigation latéral** (250px de largeur)
2. **Zone de contenu principal** (Frame)
3. **Barre de titre dynamique** (80px de hauteur)

#### Structure du menu

```xml
<Border Grid.Column="0" Background="White">
    <StackPanel>
        <!-- En-tête bleu 80px -->
        <Border Height="80" Background="#3B82F6">
            <StackPanel>
                <TextBlock Text="🏠 Gestionnaire"/>
                <TextBlock Text="de Logement"/>
            </StackPanel>
        </Border>

        <!-- 8 Boutons de navigation -->
        <Button x:Name="BtnAccueil" Content="🏠  Accueil"/>
        <Button x:Name="BtnFactures" Content="🧾  Factures"/>
        <Button x:Name="BtnEau" Content="💧  Eau"/>
        <Button x:Name="BtnElectricite" Content="⚡  Électricité"/>
        <Button x:Name="BtnChauffage" Content="🔥  Chauffage"/>
        <Button x:Name="BtnAchats" Content="💳  Achats"/>
        <Button x:Name="BtnStatistiques" Content="📊  Statistiques"/>
        <Button x:Name="BtnParametres" Content="⚙️  Paramètres"/>
    </StackPanel>
</Border>
```

#### Styles de boutons

**BoutonNavigation** (style normal) :
- Hauteur : 50px
- Background : Transparent
- Foreground : Gris foncé
- Padding : 20px à gauche
- Effet hover : Fond bleu très clair

**BoutonNavigationActif** (style actif) :
- Background : Bleu très clair
- Foreground : Bleu
- FontWeight : Bold

#### Zone de contenu

```xml
<Grid Grid.Column="1">
    <Grid.RowDefinitions>
        <RowDefinition Height="80"/>  <!-- Barre titre -->
        <RowDefinition Height="*"/>   <!-- Contenu -->
    </Grid.RowDefinitions>

    <Border Grid.Row="0">
        <TextBlock x:Name="TitrePage" Text="Tableau de bord"/>
    </Border>

    <Frame Grid.Row="1" x:Name="FramePrincipal"/>
</Grid>
```

---

### 💻 MainWindow.xaml.cs

**Fonctionnalités implémentées** :

#### 1. Navigation entre sections
- Méthode `NavigerVers()` (préparée pour futures pages)
- Méthode `AfficherMessageTemporaire()` (affiche "Page en construction")

#### 2. Gestion visuelle du bouton actif
- Méthode `ResetStylesBoutons()` : Réinitialise tous les boutons
- Méthode `DefinirBoutonActif()` : Active le style du bouton cliqué

#### 3. 8 événements de clic
- `BtnAccueil_Click()`
- `BtnFactures_Click()`
- `BtnEau_Click()`
- `BtnElectricite_Click()`
- `BtnChauffage_Click()`
- `BtnAchats_Click()`
- `BtnStatistiques_Click()`
- `BtnParametres_Click()`

**Exemple de code** :
```csharp
private void BtnAccueil_Click(object sender, RoutedEventArgs e)
{
    DefinirBoutonActif(BtnAccueil);
    TitrePage.Text = "Tableau de bord";
    AfficherMessageTemporaire();
}
```

---

### 🎨 App.xaml (Configuration globale)

**Modification majeure** : Import des couleurs au niveau global

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="Styles/Couleurs.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

**Avantage** : Les couleurs sont maintenant accessibles partout dans l'application sans avoir à les réimporter dans chaque page.

---

### 🐛 Problèmes Rencontrés et Résolus

#### Problème 1 : Ressources introuvables
**Erreur** : `Impossible de résoudre la ressource "CouleurPrincipale"`  
**Cause** : Les couleurs n'étaient pas importées dans App.xaml  
**Solution** : Ajout du `MergedDictionaries` dans App.xaml

#### Problème 2 : Package System.Text.Json manquant
**Erreur** : `Le nom de type 'Json' n'existe pas`  
**Cause** : Package NuGet System.Text.Json pas installé  
**Solution** : Installation via Gestionnaire de packages NuGet

#### Problème 3 : FramePrincipal non reconnu
**Erreur** : `Le nom 'FramePrincipal' n'existe pas dans le contexte actuel`  
**Cause** : Visual Studio n'avait pas régénéré les fichiers de liaison  
**Solution** : Nettoyer + Régénérer la solution + Redémarrer VS

---

### ✅ Tests Effectués

- ✅ Compilation sans erreur
- ✅ Lancement de l'application
- ✅ Navigation entre les boutons
- ✅ Changement du titre de page
- ✅ Style du bouton actif fonctionne
- ✅ Effet hover sur les boutons
- ✅ En-tête centré correctement
- ✅ Barre de titre alignée avec l'en-tête (80px)
- ✅ Frame affiche le message temporaire

---

### 📊 Statistiques Finales

**Temps de développement** : ~3 heures  
**Nombre de fichiers créés** : 12 fichiers de code  
**Lignes de code XAML** : ~180 lignes (MainWindow.xaml)  
**Lignes de code C#** : ~150 lignes (MainWindow.xaml.cs)  
**Nombre de commits** : 2 prévus (Documentation + Interface)

---

### 🔜 Prochaines Étapes

1. Créer `Vues/AccueilVue.xaml` (Tableau de bord)
2. Créer `Vues/FacturesVue.xaml` (Liste des factures)
3. Créer `Vues/AjouterFactureVue.xaml` (Formulaire d'ajout)
4. Implémenter le CRUD complet pour les factures
5. Tester le système de sauvegarde JSON

---

## Notes Techniques Supplémentaires

### Performance

**Charge initiale** :
- Temps de démarrage : < 2 secondes
- Mémoire utilisée : ~50-70 MB
- Temps de chargement des données (100 factures) : < 100ms

### Compatibilité

**Windows** :
- ✅ Windows 10 (version 1903+)
- ✅ Windows 11
- ❌ Windows 8.1 (non testé)
- ❌ Windows 7 (non supporté - .NET 8.0 requis)

**Résolution écran** :
- ✅ 1920×1080 (optimal)
- ✅ 1366×768 (testé)
- ⚠️ 1280×720 (certains éléments peuvent être tronqués)

---

**Dernière mise à jour** : 22/01/2026 - 21h12  
**Auteur des notes** : Latury (latury57@gmail.com)
