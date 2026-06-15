## Technologies

### Backend
- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (ou SQLite selon ton projet)

### Frontend
- Blazor
- Razor Components
- HTML5
- CSS3



## Fonctionnalités

✔ Consultation des jeux vidéo

✔ Ajout d'un nouveau jeu

✔ Modification d'un jeu existant

✔ Suppression d'un jeu

✔ Validation des données

✔ Communication Frontend ↔ API REST



## Architecture

Le projet est composé de deux applications :

### GameStore.API

API REST développée avec ASP.NET Core.

Fonctionnalités :
- Gestion des jeux vidéo
- CRUD complet
- Accès à la base de données

### GameStore.Frontend

Application Blazor consommant l'API REST.

Fonctionnalités :
- Affichage de la liste des jeux
- Création de nouveaux jeux
- Modification et suppression
- Communication avec l'API via HttpClient




## Installation

### Prérequis

- .NET 8 SDK
- Visual Studio Code ou Visual Studio

### 1. Cloner le dépôt

```bash
git clone https://github.com/RomainSalinas/GameStore.git
```

### 2. Lancer l'API

```bash
cd GameStore.API
dotnet restore
dotnet run
```

### 3. Lancer le Frontend Blazor

Ouvrir un second terminal :

```bash
cd GameStore.Frontend/GameStore.Frontend
dotnet restore
dotnet run
```

### 4. Accéder à l'application

Frontend :
```text
https://localhost:7181
http://localhost:5071
```

API :
```text
https://localhost:7255
http://localhost:5113
```
