# TetrisZombies

1. Introduction
This document specifies a design for the game “Zombie Tetris” whose name is subject to change. The concept for the game is based off the idea of smashing two gametypes together (that being zombie survival and the ever popular bricklaying game) into one cohesive experience. This idea has been discussed between Eubanks, Layton and Ensminger on November 27th 2017 and is aimed to have a deliverable product on December 4th, 2018.

1.1 Scope

This document is meant both for the eyes of the programmers and the professor requesting completion of this project.
2. Specifications and Gameplay
2.1 Concept
The aim of “Zombie Tetris” is to produce an addictive cross between tetris and a stationary zombie shooter, through which the player will be able to test their skills and survive as long as they can at their last stand.
2.2 Game Structure
In the final product of the game, several stages will be offered with several types of zombies the player must kill. This is meant to add a sense of variety to the gameplay in addition to the tetris and zombie killing aspects. Currently there is only a survival mode, however additional modes may be added should time allow, including a points based mode and modes involving the rescue of civilians (i.e. certain bullets shot save civilians while certain bullets kill zombies and civilians, leading to reduction of score). Difficulty will increment from beginning to end, with a Easy, Medium and Hard difficulty, which should mainly adjust the speed of zombies, and the rate by which any special types show up.



2.3 Action and Gameplay
Players will be able to switch between a turret section and the game of tetris at the press of a button. 

Before actually playing, upon pressing the play button, the player will be able to choose a perk: The Guy, The Hero, The Mobster, the Soldier or the Cheater, all having different numbers of starting bullets, money values and times they can teleport assigned.

The game itself will work as such:

2.3.1 Shooting Section
When the player is turned toward the shooting section (which may or may not display an actual turret) a crosshair and a barrier will be visible. Past the barrier, the player will see an endless wave of zombies (potentially of different types) roaming towards them at various speeds. A crosshair will be visible where the mouse is supposed to be. By placing the reticle over any given zombie and pressing the fire button, a bullet will be fired at the zombie, killing it with anything between one and five shots. The number of bullets available will be located on the side of the screen on the UI. When switching from shooting Section to Tetris Section, the game will continue to play. However, the player will be able to see where the zombies are located on the map.

The zombies will be roaming around a maze that will buy the player time as they shoot at them and attempt to defeat them. They will have a finite number of teleports (provided they don’t choose the cheater perk) 

2.3.2 Tetris Section
When the player is turned toward the tetris section, a screen akin to that of a tetris board will be present. It will play like a regular game of tetris, only with the appropriate signifier graphics when certain conditions, such as a line being blown or a tetris being achieved to signify how many bullets were given, or by what multiplier those bullets are given. Next to the board, there will be a button (that may be bound to a key on the keyboard) that will be used to create a bullet, or all the bullets one can make at once. In the standard game, there will be only one bullet to convert resources into bullets, but in other possible game modes, different bullets may be created (see Rules and Objectives)

2.4 Rules and Objectives
For a standard game, the rules are simple: the player must survive as long as possible, as well as to wrack up as many points as possible. When a zombie reaches the barrier which the player sits behind, they will lose a life. Once the player is out of lives, it’s game over.

To fight the zombies, the player is equipped with a turret -- signified by the aiming reticle on screen. Should the player fire at a zombie, it will take a randomly determined amount of hit (whose range may change from zombie type to zombie type, which shall be differentiated by color or drastic design differences) up to 5-7 shots per zombie. However, resources are limited as the player only has a finite number of bullets.

By switching over to the Tetris window by the press of a button, the player will turn towards a tetris board that will be paused while they are not looking directly at it. When they are looking at the board, the pieces will begin to fall, with the player being able to speed up the descent, change the position and rotation of the various blocks, like a regular game of tetris. However, once you clear a row or number of rows, the player will receive the blocks they cleared as resources, with which they are able to press a button to convert those blocks into bullets (something like 2 blocks might equate to a certain type of bullet and so on). 

The zombies do not stop moving when the player is not looking at them, so the player must be conscious of how close or far the zombies are as they are gathering resources.

The game in this sense is a resource management type game in which the player must defeat zombies, while periodically switching from the tetris board to gain bullets to the zombies to defend their position as long as possible, while defeating as many of the dead as they possibly can.

This does not at all account for potential game modes that may be added in the future, but simply the standard version that should be completed by the delivery date.

3. Resources
Resources should include the following:

All six types of Tetris block
Simple Zombie models
Graphic for Aiming reticle
Barrier
Turret (possible omission)
Button Graphics
Background for Splash Screen
4. Project Timeline
November 28th, 2018 -- Have Blueprint of Unity Project Laid out and Uploaded to GitHub
November 29th, 2018 -- Begin logic for tetris and zombies
December 1st, 2018 -- Zombie AI is complete, Killing Zombies is possible and Tetris Logic is complete
December 2nd, 2018 -- Resource Management and shifting between 
December 4th, 2018 -- Big Play Testing Day
End of the Semester -- SHOWCASE-ABLE
