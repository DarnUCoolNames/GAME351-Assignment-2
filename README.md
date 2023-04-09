Program 2
School of Information, University of Arizona 
April 9, 2023

Team:
Teresa Tran
Hannah Klecan
Samantha Jackson
Ian Roach

1. Primary functionality

For this Cross Country Hovercar Game, the team has implemented the main required functionalties as follows:

    Hovercraft Driving:

	-Implemented hovercraft driving using the “A” and “D” keys to turn the hovercraft left and right, respectively.
	-Use the “W” and “S” keys to accelerate the hovercraft forward and backward, respectively.
	-The hovercraft moves to follow the terrain naturally, without going through the terrain.
	-Implemented a follow camera that stays locked in a third-person view behind the active car and moves in sync with the hovercraft as it travels across the terrain.
	-The elevation of the camera relative to the hovercraft as it moves over the terrain uses the method Terrain.SampleHeight to control the camera's elevation.

    Three Car Types:

	-Created three visually distinct types of hovercraft, each with specific abilities.
	-Type 1, The "0RegularCar" is an average car with average speed and cornering.
	-Type 2, The "1FastCar" is a fast car with the fastest speed but slower-than-average cornering.
	-Type 3, The "2FastTurnCar" has the best cornering, turning left or right very quickly, but slower-than-average speed.
    	-The speed and cornering rates settable in the inspector for each car type.

    Hovercraft Levitation:
	
	-The hovercraft levitates above the ground, with the bottom of the cars not appearing to touch the terrain surface at any time.
    	-The cars should quiver slightly while not moving to simulate the running of the hover engines.

    Toggling Between Cars:

	-Allows the player to control/drive one hovercraft at a time and cycle through them using the “C” key.
	-The current active hovercraft always occupies the center of the screen, the camera changes each time the active car is toggled.
  	-Allows the player to cycle continuously through the cars, with the game looping back to the first car when the player toggles away from the last car.
	-Anomalies: When cycling to the 2nd and 3rd cars, the camera angle was problematic during development. Eventually the team was able to get the camera 
	 to follow the active car properly, but the orientation of the first car was not able to be replicated. There was an inconsitency between the camera view 
	 in Unity and the actual camera view in game mode. 


2. Choice Features implemented



To install the project, follow these steps:

1. Create a blank "3D URP" project in Unity Hub.
    Note: Your project MUST use the Universal Rendering Pipeline for textures and effects to render properly.

2. Allow the Unity editor to initialize the project.

3. Save your blank 3D URP project and exit Unity.

4. Navigate to project directory in file system.

5. Drop the "Assets" and "Project Settings" folders into this directory.

6. Open and reload the Unity project you created.

7. In the project navigator, go to the assets directory and find the "Scenes" folder.

8. Click on the "Cross-Country Scene" to load it.

9. Go to Unity->File->Build Settings and verify that the "Cross-Country Scene" is in the "Scenes in Build" list.

10. If the scene is not in the build list, click "Add Open Scenes". The scene should appear checked.

11. The game template then should be ready for building and running.

Credits:

Sample code by Leonard D. Brown, University of Arizona. This program was developed for educational purposes.

Freeware media assets were used from the following sources: (1) http://millionthvector.blogspot.com/ (2) https://assetstore.unity.com/ (3) https://www.gameartguppy.com/ (4) https://www.videvo.net/royalty-free-sound-effects/ (5) https://freesound.org/search/
