# A Maze
Starter project for the Udacity [VR Developer Nanodegree](http://udacity.com/vr) program.

- Course: VR Software Development
- Project: A Maze


### Versions Used
- [Unity LTS Release 2017.4.4](https://unity3d.com/unity/qa/lts-releases?version=2017.4)
- [GVR SDK for Unity v1.100.1](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.100.1)


### Description of the submitted project
1- build-design of the maze
2- set coins-key positions
3- create player manager script that manages the game (how many coins collected - iskeycolleted or not )
3- create particular effect object with the audio source
4- add coin script to coin prefab
5- onCoinClicked it instantiate particular effect object and set its audio source to coin clip
6- add Key script to key prefab
7- onKeyClicked it instantiates particular effect object and set its audio source to key clip and call to playermanager to make key boolean is true
8- door script attached to door object and control whether it can be opened or not by calling to playermanager
9- signpost responsible to restart the scene and display how many coins collected
10- add some statics area-Lights And generated the lighting system

 
### Name of the main scene, i.e. the scene that should be loaded first
-the main scene that come with starter project

### Name of all other scenes that that should be reviewed, if any
-not

### Unity version used

- [Unity LTS Release 2017.2.0f3]

### GVR SDK for Unity version used

- [GVR SDK for Unity v1.100.1]

### Target deployment platform(s)

-Build For Android


### About the Starter Project
The included starter project represents a new Unity project where the following have been done:
- All assets needed to complete the project according to the project rubric have been imported.
- The imported models have been placed in the scene and organized in the scene hierarchy.
- Colliders have been added to the `Coin`, `Key`, `Left_Door`, `Right_Door`, and `The_Temple` game objects, and to the `Maze` game object's child game objects.


### Related Repositories
- [VR Software Development - Creating Scripts](https://github.com/udacity/VR-Software-Development_Creating-Scripts/releases)
- [VR Software Development - Controlling Objects Using Code](https://github.com/udacity/VR-Software-Development_Controlling-Objects-Using-Code/releases)
- [VR Software Development - VR Interaction](https://github.com/udacity/VR-Software-Development_VR-Interaction/releases)
- [VR Software Development - Programming Animations](https://github.com/udacity/VR-Software-Development_Programming-Animations/releases)
- [VR Software Development - Physics and Audio](https://github.com/udacity/VR-Software-Development_Physics-and-Audio/releases)
- [VR Software Development - Advanced VR Scripting](https://github.com/udacity/VR-Software-Development_Advanced-VR-Scripting/releases)
- VR Software Development - A Maze
