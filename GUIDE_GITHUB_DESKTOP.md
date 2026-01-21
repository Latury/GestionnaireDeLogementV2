# 🐙 Guide GitHub Desktop - Expliqué Simplement

## 📌 Qu'est-ce que GitHub Desktop ?

**GitHub Desktop** est un logiciel qui aide à **sauvegarder ton code** sur internet.

**Pourquoi c'est important ?**
- ✅ Si ton ordinateur casse, ton code est sauvegardé
- ✅ Tu peux revenir en arrière si tu fais une erreur
- ✅ Tu peux voir tout l'historique de ton projet
- ✅ Tu peux partager ton projet avec d'autres personnes

---

## 🎯 Les 3 Mots Importants

### 1️⃣ Repository (Dépôt)

**C'est quoi ?** Un dossier qui contient ton projet.

**Exemple** : `GestionnaireLogement` est ton repository.

**Analogie** : C'est comme une boîte qui contient tous tes fichiers de projet.

---

### 2️⃣ Commit

**C'est quoi ?** Une sauvegarde de ton code avec un message.

**Exemple** : "✨ Ajout de la page des factures"

**Analogie** : C'est comme prendre une photo de ton projet à un moment précis.

**Quand faire un commit ?**
- ✅ Après avoir ajouté une nouvelle fonctionnalité
- ✅ Après avoir corrigé un bug
- ✅ Toutes les 30-60 minutes de travail
- ❌ PAS si le code ne compile pas
- ❌ PAS si le code est incomplet

---

### 3️⃣ Push

**C'est quoi ?** Envoyer tes commits sur internet (GitHub.com).

**Exemple** : Tu as fait 3 commits sur ton ordinateur, tu fais un "Push" pour les envoyer sur GitHub.com.

**Analogie** : C'est comme envoyer une lettre que tu as écrite.

---

## 📥 Installation - Étape par Étape

### Étape 1 : Télécharger

1. Ouvre ton navigateur internet (Chrome, Firefox, Edge...)
2. Va sur : https://desktop.github.com/
3. Clique sur le gros bouton "Download for Windows"
4. Attends que le téléchargement se termine (fichier : `GitHubDesktopSetup.exe`)

---

### Étape 2 : Installer

1. Double-clique sur `GitHubDesktopSetup.exe`
2. Une fenêtre s'ouvre avec une barre de progression
3. Attends que l'installation se termine (environ 1-2 minutes)
4. GitHub Desktop s'ouvre automatiquement

---

### Étape 3 : Se connecter

1. Tu vois un écran "Welcome to GitHub Desktop"
2. Clique sur "Sign in to GitHub.com"
3. Une page web s'ouvre dans ton navigateur
4. Entre ton **nom d'utilisateur GitHub** (ou email)
5. Entre ton **mot de passe**
6. Clique sur "Sign in"
7. Une page dit "Success!" → Ferme le navigateur
8. Retourne sur GitHub Desktop

---

### Étape 4 : Configurer ton nom

1. Tu vois "Configure Git"
2. Entre ton **nom** (exemple : "Thomas")
3. Entre ton **email** (exemple : "thomas@example.com")
4. Clique sur "Finish"

**✅ C'est terminé ! GitHub Desktop est prêt.**

---

## 🆕 Créer Ton Premier Repository

### Étape 1 : Créer le repository

1. Dans GitHub Desktop, clique sur **"File"** (en haut à gauche)
2. Clique sur **"New repository..."**
3. Tu vois un formulaire avec plusieurs champs :

---

### Étape 2 : Remplir le formulaire

**Champ "Name"** (Nom)
- Tape : `GestionnaireLogement`
- ⚠️ Pas d'espaces, pas d'accents

**Champ "Description"** (Description)
- Tape : `Application WPF de gestion de logement`

**Champ "Local path"** (Emplacement)
- C'est l'endroit où le dossier sera créé sur ton ordinateur
- Exemple : `C:\Users\TonNom\Documents\GitHub\`
- Tu peux cliquer sur "Choose..." pour choisir un autre endroit

**Case "Initialize this repository with a README"**
- ✅ Coche cette case
- Ça crée un fichier README.md automatiquement

**Menu "Git ignore"**
- Choisis : **"Visual Studio"**
- Ça dit à Git d'ignorer les fichiers temporaires de Visual Studio

**Menu "License"**
- Choisis : **"MIT License"**
- On va modifier la licence après pour ajouter l'attribution

---

### Étape 3 : Créer

1. Clique sur **"Create repository"**
2. Attends 2-3 secondes
3. ✅ Ton repository est créé !

---

### Étape 4 : Publier sur GitHub.com

1. Tu vois un gros bouton bleu : **"Publish repository"**
2. Clique dessus
3. Une fenêtre s'ouvre :
   - **Name** : `GestionnaireLogement` (déjà rempli)
   - **Description** : `Application WPF de gestion de logement` (déjà rempli)
   - **Case "Keep this code private"** :
     - ✅ Coche si tu veux que ton projet soit privé (visible seulement par toi)
     - ❌ Décoche si tu veux que ton projet soit public (visible par tout le monde)
4. Clique sur **"Publish repository"**
5. Attends 5-10 secondes
6. ✅ Ton projet est maintenant sur GitHub.com !

---

## 💾 Faire Ton Premier Commit

### Situation

Tu as créé des fichiers dans ton projet Visual Studio. Maintenant tu veux les sauvegarder.

---

### Étape 1 : Ouvrir GitHub Desktop

1. Ouvre GitHub Desktop
2. Tu vois une liste de fichiers modifiés à gauche

**Exemple** :
```
✅ MainWindow.xaml
✅ MainWindow.xaml.cs
✅ AccueilPage.xaml
✅ AccueilPage.xaml.cs
```

---

### Étape 2 : Vérifier les fichiers

**À gauche, il y a des cases à cocher devant chaque fichier.**

- ✅ Case cochée = Ce fichier sera inclus dans le commit
- ❌ Case décochée = Ce fichier ne sera PAS inclus

**En général, coche tous les fichiers.**

---

### Étape 3 : Écrire le message de commit

**En bas à gauche, il y a 2 champs** :

**1. "Summary" (Résumé)** - OBLIGATOIRE
- C'est le titre de ton commit (court)
- Maximum 50 caractères
- Exemple : `✨ Ajout de la page Accueil`

**2. "Description" (Description)** - OPTIONNEL
- C'est le détail de ton commit (long)
- Tu peux écrire plusieurs lignes
- Exemple :
  ```
  - Création de AccueilPage.xaml
  - Ajout de 3 cartes statistiques
  - Ajout de la liste des dernières factures
  ```

---

### Étape 4 : Faire le commit

1. Clique sur le gros bouton bleu **"Commit to main"**
2. ✅ Ton commit est créé !

**Attention** : Le commit est seulement sur ton ordinateur pour l'instant.

---

### Étape 5 : Envoyer sur GitHub.com (Push)

1. En haut, tu vois un bouton : **"Push origin"**
2. Clique dessus
3. Une barre de progression apparaît
4. Attends 2-5 secondes
5. ✅ Ton code est maintenant sur GitHub.com !

---

## 📋 Exemples de Messages de Commit

### ✨ Ajout de fonctionnalité

**Summary** :
```
✨ Ajout de la page des factures
```

**Description** :
```
- Création de FacturesPage.xaml et FacturesPage.xaml.cs
- Ajout du bouton "Ajouter une facture"
- Ajout de la liste des factures
- Connexion avec DataManager pour charger les données
```

---

### 🐛 Correction de bug

**Summary** :
```
🐛 Correction du crash lors de la suppression
```

**Description** :
```
- Ajout de vérification null avant suppression
- Ajout d'un message de confirmation
- Correction de NullReferenceException dans FacturesPage.cs ligne 125
```

---

### 🎨 Changement visuel

**Summary** :
```
🎨 Amélioration des couleurs du thème
```

**Description** :
```
- Modification de Colors.xaml
- Changement du bleu principal : #3B82F6 → #2563EB
- Changement du vert succès : #10B981 → #059669
```

---

### 📝 Documentation

**Summary** :
```
📝 Mise à jour du README
```

**Description** :
```
- Ajout de la section "Installation"
- Ajout de captures d'écran
- Correction des fautes de frappe
```

---

## 🔄 Workflow Quotidien

Voici comment utiliser GitHub Desktop tous les jours :

### Matin (Début de session)

1. Ouvre GitHub Desktop
2. Clique sur **"Fetch origin"** (en haut)
   - Ça vérifie s'il y a des changements sur GitHub.com
   - (Utile si tu travailles sur plusieurs ordinateurs)
3. Ouvre Visual Studio et commence à coder

---

### Pendant le travail

**Toutes les 30-60 minutes** :

1. Sauvegarde tes fichiers dans Visual Studio (Ctrl+S)
2. Va sur GitHub Desktop
3. Vérifie les fichiers modifiés
4. Écris un message de commit
5. Clique sur "Commit to main"

---

### Soir (Fin de session)

1. Fais un dernier commit si tu as des changements non sauvegardés
2. Clique sur **"Push origin"**
3. Ferme GitHub Desktop
4. Ferme Visual Studio

**✅ Ton code est sauvegardé pour la journée !**

---

## 🆘 Problèmes Courants

### Problème 1 : "Push rejected"

**Message d'erreur** : "Push rejected because the remote contains work that you do not have locally"

**Cause** : Quelqu'un (ou toi sur un autre ordinateur) a fait des changements sur GitHub.com.

**Solution** :
1. Clique sur **"Fetch origin"**
2. Clique sur **"Pull origin"**
3. Réessaie de faire **"Push origin"**

---

### Problème 2 : "Merge conflict"

**Message d'erreur** : "Merge conflict in MainWindow.xaml"

**Cause** : Tu as modifié un fichier et quelqu'un d'autre aussi.

**Solution** :
1. Ouvre Visual Studio
2. Ouvre le fichier en conflit
3. Tu vois des lignes comme :
   ```
   <<<<<<< HEAD
   (ton code)
   =======
   (l'autre code)
   >>>>>>> main
   ```
4. Garde le bon code et supprime les lignes `<<<`, `===`, `>>>`
5. Sauvegarde le fichier
6. Retourne sur GitHub Desktop
7. Fais un commit avec le message : `🔀 Résolution de conflit`

---

### Problème 3 : "Authentication failed"

**Message d'erreur** : "Authentication failed"

**Cause** : GitHub Desktop n'est plus connecté à ton compte.

**Solution** :
1. Va dans **File > Options**
2. Clique sur **"Sign out"**
3. Clique sur **"Sign in to GitHub.com"**
4. Reconnecte-toi avec ton nom d'utilisateur et mot de passe

---

## 📊 Voir l'Historique

### Sur GitHub Desktop

1. Clique sur l'onglet **"History"** (en haut)
2. Tu vois tous tes commits
3. Clique sur un commit pour voir ce qui a changé

---

### Sur GitHub.com

1. Va sur https://github.com/
2. Clique sur ton repository **"GestionnaireLogement"**
3. Clique sur **"XX commits"** (en haut)
4. Tu vois tout l'historique

---

## 🎯 Résumé des Actions

| Action | Où | Quand |
|--------|-----|-------|
| **Commit** | GitHub Desktop | Toutes les 30-60 min |
| **Push** | GitHub Desktop | Fin de session |
| **Fetch** | GitHub Desktop | Début de session |
| **Pull** | GitHub Desktop | Si Fetch trouve des changements |

---

## 💡 Conseils

### ✅ BONNES PRATIQUES

- Fais des commits réguliers (toutes les 30-60 min)
- Écris des messages de commit clairs
- Push à la fin de chaque session
- Ne commit jamais du code qui ne compile pas

### ❌ À ÉVITER

- Ne commit pas de fichiers trop gros (>100 MB)
- Ne commit pas de mots de passe ou clés API
- Ne commit pas les fichiers dans `bin/` ou `obj/`
- Ne fais pas de commit avec juste "Update" comme message

---

## 📞 Aide Supplémentaire

Si tu es bloqué :

1. **Documentation GitHub Desktop** : https://docs.github.com/fr/desktop
2. **Vidéos YouTube** : Recherche "GitHub Desktop tutoriel français"
3. **Forum GitHub** : https://github.com/orgs/community/discussions

---

**Dernière mise à jour** : 21/01/2026  
**Auteur** : Guide adapté pour TSA
