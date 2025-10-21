# Assignment 4 — Top-Down Game (Godot 4.4 Mono)

## Overview
A complete top-down 2D game developed using **Godot 4.4 Mono (C#)**.  
The player moves through a tile-based world, collects crystals, and avoids a pursuing enemy that uses navigation pathfinding.  
This project demonstrates the use of Godot’s **TileMap**, **NavigationAgent2D**, **AnimatedSprite2D**, **Particles2D**, and **AudioStreamPlayer** nodes with well-structured C# scripts.

---

## Controls
- **WASD / Arrow Keys:** Move the player  
- **ESC:** Quit the game

---

## Features Implemented
- ✅ **Tile-based level design** using `TileMap` and `TileSet`
- ✅ **Player movement** via `CharacterBody2D` and `move_and_slide()`
- ✅ **Enemy pathfinding** implemented with `NavigationAgent2D`
- ✅ **Collectibles (crystals)** using `Area2D` detection and scoring
- ✅ **Particle effects** (`Sparkle.tscn`, `Explosion.tscn`) for visual feedback
- ✅ **Audio feedback** (pickup, explosion, and looping background music)
- ✅ **Win condition:** triggered when all crystals are collected
- ✅ **Game Over condition:** triggered when the enemy reaches the player
- ✅ **Auto scene reload** after win/loss via `Timer`
- ✅ **UI** (`Label` in `CanvasLayer`) displays real-time score and status
- ✅ **Clean, well-commented C# scripts**

---

##  How to Run
1. Open this folder in **Godot 4.4 (Mono version)**.  
2. Open the **Main scene** (`res://scenes/Main.tscn`).  
3. Press **Play ▶️**.  
4. Move around using the controls to collect crystals and avoid the enemy.  
5. When all crystals are collected → *“🎉 You Win!”*  
   If caught by the enemy → *“💀 Game Over 💀”*

---

## Game Logic Summary
| Mechanic | Node(s) Used | Description |
|-----------|--------------|-------------|
| Player Movement | `CharacterBody2D`, `AnimatedSprite2D` | Uses input vector and `MoveAndSlide()` |
| Enemy Navigation | `NavigationAgent2D`, `CharacterBody2D` | Continuously updates path to player |
| Collectibles | `Area2D`, `CollisionShape2D` | Increments score and triggers sparkle |
| Particle Effects | `Particles2D`, `GPUParticles2D` | Visual feedback for events |
| UI | `CanvasLayer`, `Label` | Displays score and status text |
| Audio | `AudioStreamPlayer` | Plays background and event sounds |
| Restart System | `Timer` node | Restarts scene after win/loss |

---

## Win Condition and Effects
- **Sparkle particles** play when collecting a crystal.  
- **Explosion particles** and *“🎉 You Win! 🎉”* appear after collecting all.  
- Scene restarts automatically after 3 seconds.

---

## Game Over Condition
- If the **enemy** reaches the player, an **explosion** plays and *“💀 Game Over 💀”* appears.  
- The game restarts automatically after 3 seconds.

---

## Audio & Polish
- `pickup.wav` — plays when collecting a crystal.  
- `explosion.wav` — plays on win or game-over events.  
- `background.ogg` — loops softly throughout gameplay.  
> *All placeholder sounds are royalty-free and can be replaced with any audio of your choice.*

---

## Technical Notes
This project was developed using **Godot 4.4 (Mono)** and C#.  
All scripts are organized under the `/scripts` directory, and each scene uses proper node hierarchies following best practices from the official documentation.

---

## References
Concepts and code structure were informed by the following sources:
1. *Godot Engine Official Documentation* — “2D Movement and Physics” and “Navigation in 2D.”  
   [https://docs.godotengine.org/en/stable/](https://docs.godotengine.org/en/stable/)
2. KidsCanCode (2023). *Godot 4 Recipes: Top-Down Movement & Platform Character.*  
   [https://kidscancode.org/godot_recipes/4.x/2d/topdown_movement/](https://kidscancode.org/godot_recipes/4.x/2d/topdown_movement/)
3. Casraf Dev (2024). *Pathfinding Guide for 2D Tiles in Godot 4.3.*  
   [https://casraf.dev/2024/09/pathfinding-guide-for-2d-top-view-tiles-in-godot-4-3/](https://casraf.dev/2024/09/pathfinding-guide-for-2d-top-view-tiles-in-godot-4-3/)
4. Godot Docs (2023). *Particles2D and AnimatedSprite2D usage.*  
   [https://docs.godotengine.org/en/stable/tutorials/2d/particle_systems_2d.html](https://docs.godotengine.org/en/stable/tutorials/2d/particle_systems_2d.html)
5. Dev.to (2024). *Learn Godot 4 by Making a 2D Platformer (Part 4).*  
   [https://dev.to/christinec_dev/learn-godot-4-by-making-a-2d-platformer-part-4-level-creation-1-4obb](https://dev.to/christinec_dev/learn-godot-4-by-making-a-2d-platformer-part-4-level-creation-1-4obb)

---

## Submission Details
**Student:** Manjot Kaur  
**Course:** IMG 420 — Game Development (Northern Arizona University)   
**Assignment:** 4 — 2D Top-Down Game (C# in Godot 4.4)  
**GitHub Repository:** [https://github.com/Manjotkaur2003/IMG-420-Assignment-4](https://github.com/Manjotkaur2003/IMG-420-Assignment-4)

---

© 2025 Manjot Kaur. All rights reserved.  
Educational use only. References credited under fair use for instructional purposes.


