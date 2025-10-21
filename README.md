# Assignment 4 — Top-Down Game (Godot 4.4 Mono)

##  Overview
A simple top-down 2D game created in Godot 4.4 using C#.  
The player moves through a tile-based world, collects crystals, and avoids an enemy.

## Controls
- **WASD / Arrow Keys**: Move player  
- **ESC**: Quit game

## Features
- TileMap world
- Player and enemy using CharacterBody2D
- Enemy navigation via NavigationAgent2D
- Collisions and collectibles
- Basic particle feedback
- UI for score

## How to Run
1. Open in **Godot 4.4 Mono**.
2. Run `Main.tscn`.
3. Collect crystals while avoiding the enemy.

## Win Condition and Effects
- Sparkle particles play when collecting a crystal.
- Explosion particles play when the final crystal is collected.
- “You Win!” appears once all collectibles are found.

## Game Over Condition
- If the enemy reaches the player, an explosion plays and "Game Over" appears.
- The scene automatically restarts after 3 seconds.
- Players can try again to collect all crystals and win.

##  Audio & Polish
- **pickup.wav** plays when collecting a crystal.  
- **explosion.wav** plays on win or game-over events.  
- **background.ogg** loops softly during gameplay.  
Replace these placeholder files with any royalty-free sounds of your choice.


