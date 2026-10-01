# ShooterGame
## Project Overview

ShooterGame is a single-player shooter game developed in C#.
This project was created as a learning project focused on applying software development concepts through the continuous development of a single application rather than multiple isolated exercises.

Before development began, the project was planned around four primary goals:

* Building the game logic
* Integrating a database
* Creating a graphical interface
* Making the application available online

The project started as a console-based shooter and later evolved into a Windows Forms application connected to a cloud-hosted backend through an ASP.NET Core Web API.

Today, the project includes:

* User registration and login
* Secure password storage using BCrypt
* Character selection
* Online leaderboard
* Feedback submission
* Cloud-hosted API
* Cloud-hosted MySQL database
* Installable Windows application

Users can install and play the game without accessing the source code.
## Download
 
The latest installable version can be downloaded from the Releases page.
> Download: sha256:8edfa07e8de8dbf0b160500be953abe3eda0d578af5ed9670fb0f2e18d567382

## System Architecture

    ShooterGame (WinForms Client)
               │
             HTTP
               │
               ▼
        ShooterGameAPI
       (ASP.NET Core Web API)
               │
       Entity Framework Core
               │
               ▼
    Azure Database for MySQL

The Windows Forms application communicates with the backend through HTTP requests. The API handles application and database communication while Entity Framework Core provides access to the MySQL database.

## Features
### Gameplay
* Single-player shooter gameplay
* Multiple playable characters
* Character selection
* Unique health and attack values
* Shooting mechanics
* Enemy projectile system
* Jumping mechanics
* Collision detection
* Health system
* Score calculation
* Victory state
* Game Over state
### User System
* User registration
* User login
* BCrypt password hashing
* Secure password verification
### Online Features
* Online leaderboard
* Best-score tracking
* Feedback submission
* Cloud-hosted backend
### Desktop Application
* Windows Forms interface
* Installable setup package
* Desktop shortcut creation
* Custom application icon
* Fixed window size
* Controlled scaling configuration
### Leaderboard System

*The leaderboard displays the Top 10 scores.*

Each leaderboard record contains:

- Username
- Selected Character
- Score

Scores are calculated using a combination of:

- Damage dealt
- Remaining health
- Character attack value
- Survival time

**Only a player's highest score is stored.**

## Characters

| Character | Health | Attack |
|---|---:|---:|
| Fairy | 800 | 250 |
| Soldier | 500 | 500 |
| Old Man | 300 | 1000 |
| Enemy | 14000 | 100 |

Each character includes:

* Unique statistics
* Unique visual assets
* Unique animation frames
* Unique projectile graphics
* Unique health-bar states

## Technologies
| Category | Technology |
|----------|------------|
| Language | C# |
| Desktop Application | Windows Forms |
| Backend | ASP.NET Core Web API |
| Data Access | Entity Framework Core |
| Database | MySQL |
| Cloud Database | Azure Database for MySQL |
| Cloud Service | Azure App Service |
| Security | BCrypt Password Hashing |
| Distribution | Visual Studio Setup Project |

## Project Evolution
### Phase 1 — Core Game Development

The project began as a console-based shooter game. Before development began, the core *gameplay systems and development stages were planned*.

This phase focused on building the foundation of the application, including:

- Object-Oriented Programming principles
- Character system
- Health and damage mechanics
- Shooting system
- Enemy attacks
- Jumping mechanics
- Collision detection
- Score calculation
- Game state management

The initial game logic was developed within a few days and became the foundation for every later stage of the project. **As new technologies were added, the existing systems were adapted and expanded rather than rewritten from scratch**.

## Phase 2 — Database Integration

After the gameplay systems were established, the next step was adding persistent data.

To achieve this, a MySQL database was designed and integrated into the project.

This phase introduced:

- User registration
- User login
- Persistent leaderboard records

During this stage, the focus was on:

* SQL
* Database design
* Database connectivity
* Data persistence

## Phase 3 — Windows Forms Migration

The next stage involved moving the project from a console application to a graphical interface.

The primary challenge was adapting existing gameplay systems to an event-driven environment while preserving the original game mechanics.

During this phase, the project received:

- Login screen
- Registration screen
- Main menu
- Character selection screen
- Gameplay interface
- Leaderboard interface

This phase introduced:

* Windows Forms
* Event-driven programming
* Resource management
* Animation handling
* UI architecture

## Phase 4 — API Architecture

As the project grew, direct database communication was replaced with a dedicated backend layer.

To achieve this, an ASP.NET Core Web API was introduced.

The API:

- Performs CRUD operations
- Handles communication between the client and database
- Removes direct database access from the client application

This phase introduced:

* REST APIs
* HTTP communication
* Entity Framework Core
* Backend architecture
* Authentication workflows
* Feedback interface

**Passwords are hashed using BCrypt and verified during login.**

## Phase 5 — Cloud Deployment

The next goal was making the application *accessible outside the local environment*.

To achieve this, both the API and database were deployed to Microsoft Azure.

- Azure App Service
- Hosts the ASP.NET Core Web API.
- Azure Database for MySQL
- Hosts the production database.

This allows users to:

* Register accounts
* Login
* Submit feedback
* Appear on the online leaderboard

without requiring a local server or database installation.

## Phase 6 — Software Distribution

The final stage involved packaging the application as an installable Windows product.

The game now includes:

- Windows Installer
- Desktop shortcut creation
- Custom application icon
- Fixed window size
- Controlled scaling configuration

Users can download, install, and play the game without accessing the source code or building the project manually.

## Screenshots
### Console Version
<img width="1408" height="1058" alt="Ekran görüntüsü 2026-07-11 002415" src="https://github.com/user-attachments/assets/d665c0b4-4068-4bb1-bc5d-79724d635912" />

### Login
<img width="1430" height="958" alt="Ekran görüntüsü 2026-09-04 140821" src="https://github.com/user-attachments/assets/d46891b0-03ff-4f65-8f0e-b6e9c5c3b106" />

## Registration
<img width="1452" height="976" alt="Ekran görüntüsü 2026-09-04 141939" src="https://github.com/user-attachments/assets/4dc8cff9-5176-448e-a5b9-5732e565808b" />

## Main Menu
<img width="1438" height="898" alt="Ekran görüntüsü 2026-09-04 140904" src="https://github.com/user-attachments/assets/eda3959f-5932-4b8f-b453-b2fb1bf48eeb" />

## Character Selection

<img width="1446" height="942" alt="Ekran görüntüsü 2026-09-04 140918" src="https://github.com/user-attachments/assets/01aea7ea-1a74-4faa-8084-7653b26cb09f" />

## Gameplay
<img width="1448" height="998" alt="Ekran görüntüsü 2026-10-01 165152" src="https://github.com/user-attachments/assets/b05b3c31-cb87-4af2-80a8-7fb713212f91" />
<img width="1456" height="996" alt="Ekran görüntüsü 2026-10-01 165211" src="https://github.com/user-attachments/assets/f5dadfed-15e6-41c3-8744-630899bfa155" />
<img width="1444" height="1000" alt="Ekran görüntüsü 2026-10-01 165130" src="https://github.com/user-attachments/assets/f79351b6-1a7f-4e8f-8723-f9587a7009cc" />

## Leaderboard
<img width="1460" height="938" alt="image" src="https://github.com/user-attachments/assets/078d7d6a-3358-4edf-a25c-001fbea1d763" />

## Feedback
<img width="1470" height="1006" alt="Ekran görüntüsü 2026-09-20 141850" src="https://github.com/user-attachments/assets/7e6d673e-ba71-4afd-bf0d-b82ba4fc7fba" />

## API
<img width="1780" height="500" alt="Ekran görüntüsü 2026-09-20 143030" src="https://github.com/user-attachments/assets/a56e5703-ffec-4813-8eeb-cc027f22df1b" />
<img width="2330" height="456" alt="Ekran görüntüsü 2026-09-20 142944" src="https://github.com/user-attachments/assets/103b4b26-b904-45b1-a8d2-e5762b2f0771" />

## Installer
<img width="990" height="808" alt="image" src="https://github.com/user-attachments/assets/bd34a433-33aa-4fe0-a1ef-01a45b201162" />
<img width="190" height="210" alt="image" src="https://github.com/user-attachments/assets/0154b9c8-83b0-43a7-9442-b1769eed817d" />


## Installation
### Requirements
* Windows
* Internet connection for online features
### Installation Steps
* Download the latest release.
* Run the installer.
* Launch the game using the desktop shortcut.
* Register a new account.
* Login.
* Select a character.
* Play and compete for a place on the leaderboard.

## Visual Assets

**Visual assets were created using AI-assisted image generation tools and then adapted, organized, and integrated into the game by the developer.**

This includes:

* Character sprites
* Animation frames
* UI assets
* Environmental visuals

## What I Learned

Besides improving my *C# skills* and *learning SQL*, *Windows Forms*, *ASP.NET Core Web API*, *MySQL*, *Azure*, and *deployment concepts*, the project also helped me **develop skills that are not tied to a specific technology**.

These include:

* Resource management
* Database connectivity
* Application architecture
* API design
* Debugging
* Deployment
* Application distribution
* Problem investigation
* Structured problem solving

**The project required understanding not only how individual technologies work, but also how they interact within a complete software system**.

## Why This Project Matters To Me

The objective was never to learn a technology in isolation.

Instead, the goal was to continuously develop a single project while introducing new features, solving new problems, and expanding the architecture whenever new requirements appeared.

What started as a console-based shooter eventually became:

* A graphical desktop application
* A database-driven system
* A cloud-connected application
* An installable software product

The project achieved the goals originally defined during planning while also introducing additional concepts and challenges throughout development.

## Project Status

The current version represents the latest stage of the project, including the game client, backend API, database integration, cloud deployment, and Windows installer.
