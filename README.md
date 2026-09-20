# ShooterGame

ShooterGame is an ongoing game development project built in C#.

The goal of the project from the beginning has been to develop a complete, installable game that can eventually connect to online services such as a shared leaderboard.

Instead of building separate small projects for each topic I wanted to learn, I decided to keep developing the same game and use each stage to introduce new concepts and solve new problems.

## Features

- Multiple playable characters with different health and attack values
- Character selection
- Shooting system
- Enemy projectile system
- Jumping
- Collision detection
- Sprite-based animations
- Damage and health systems
- Login and registration
- MySQL database integration
- Persistent leaderboard
- Feedback system
- Windows Forms graphical interface
- Victory and Game Over states
- ASP.NET Core Web API

## Screenshots

### Console Version

<img width="1394" height="1040" alt="Ekran görüntüsü 2026-07-11 002638" src="https://github.com/user-attachments/assets/8ba07a7f-51f2-4974-9737-bbe38ceb6f51" />

### Login

<img width="1430" height="958" alt="Ekran görüntüsü 2026-09-04 140821" src="https://github.com/user-attachments/assets/961498c6-11c6-432c-9cd0-c191d5ba673f" />

### Register

<img width="1452" height="976" alt="Ekran görüntüsü 2026-09-04 141939" src="https://github.com/user-attachments/assets/f822a10a-5cce-46c6-9067-39dbe16cf704" />

### Main Menu

<img width="1438" height="898" alt="Ekran görüntüsü 2026-09-04 140904" src="https://github.com/user-attachments/assets/a00f1489-2aa1-48fd-a8e3-ea87296ffb4f" />
### Character Selection

<img width="1446" height="942" alt="Ekran görüntüsü 2026-09-04 140918" src="https://github.com/user-attachments/assets/70cdf9dd-8574-4afe-b53f-3dbdfd05225c" />
### Gameplay

<img width="1436" height="992" alt="Ekran görüntüsü 2026-09-04 141008" src="https://github.com/user-attachments/assets/d6f0c415-b493-4e81-a31a-457e2c1ee0f1" />
<img width="1448" height="1000" alt="Ekran görüntüsü 2026-09-04 143316" src="https://github.com/user-attachments/assets/8c4e6857-aaa7-489d-82b8-5afcc13c5775" />

### Leaderboard

<img width="1456" height="938" alt="Ekran görüntüsü 2026-09-04 142809" src="https://github.com/user-attachments/assets/e7c5fc6c-b367-419a-95fa-2ead040da4f5" />
### Feedback

<img width="1470" height="1006" alt="Ekran görüntüsü 2026-09-20 141850" src="https://github.com/user-attachments/assets/0350e505-274a-4af4-b3bb-6125d82a1741" />

### API

The game client now communicates with a separate ASP.NET Core API.
<img width="2330" height="456" alt="Ekran görüntüsü 2026-09-20 142944" src="https://github.com/user-attachments/assets/6be7b5cf-7a09-4ed1-a81b-3b5799154630" />
<img width="1780" height="500" alt="Ekran görüntüsü 2026-09-20 143030" src="https://github.com/user-attachments/assets/ae62db23-93a4-493a-8c00-bcfcb91ceb99" />

## Characters

| Character | Health | Attack |
| --- | ---: | ---: |
| Fairy | 800 | 250 |
| Soldier | 500 | 500 |
| OldMan | 300 | 1000 |
| Enemy | 14000 | 100 |

The characters have different gameplay statistics and their own visual assets, animation frames, projectile graphics, and health-bar states.

## Roadmap

### Completed

✅ Console shooter game

✅ Login system

✅ Database integration

✅ Persistent leaderboard

✅ Graphical user interface with Windows Forms

✅ Improved project structure and code organization

✅ ASP.NET Core API architecture

### Next Steps

🔜 Deploy the backend and database and enable the online leaderboard.

## Project Progress

### ✅ Step 1 — Core Game

The project started as a console-based shooter.

The initial stage focused on building the core gameplay systems, including character selection, movement, shooting, jumping, projectiles, collision detection, scoring, and game-state handling.

This stage also strengthened my existing C# and object-oriented programming knowledge.

### ✅ Step 2 — Database Integration

The next stage introduced MySQL and persistent data.

This added user registration, login, persistent scores, leaderboard data, and feedback functionality.

I learned SQL, database design, and how database operations can be connected to application logic while continuing to develop the same game.

### ✅ Step 3 — Graphical UI

The project was then moved from the console to a Windows Forms graphical interface.

This required adapting the existing game systems to an event-driven graphical environment.

The game received graphical menus, character selection, animations, health bars, gameplay screens, leaderboard and feedback forms.

The goal was not simply to change the appearance of the game, but to make the existing game systems work inside a graphical application.

### ✅ Step 4 — API Architecture

The next architectural step was separating the game client from the database layer.

The project now contains a Windows Forms client and a separate ASP.NET Core Web API.

```text
ShooterGame
Windows Forms Client
        |
      HTTP
        |
        v
ShooterGameAPI
ASP.NET Core
        |
Entity Framework Core
        |
        v
      MySQL
