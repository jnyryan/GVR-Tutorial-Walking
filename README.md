# GVR-Tutorial1-Camera-On-Terrain

With Google Virtual Reality - We're going to create a scene with terrain and a skybox

Most of what follows is based on these Tutorials and amalgmating pieces of each

- [Movement In Mobile VR: Autowalk by NurFACEGAMES](https://www.youtube.com/watch?v=JmgOeQ3Gric) - Character Control using CaharacterController
- [Movement In Mobile VR: Look Walk by NurFACEGAMES](https://www.youtube.com/watch?v=kBTn2pGwZUk) - Walking
- [Creating a Google Cardboard VR app in Unity 2017 by Rabidgremlin](https://www.youtube.com/watch?v=EAaoEe9ksyE) - Object interaction
- [Unity 3D - How to make your First Terrain (Beginner Tutorial) By DEYEmaginary](https://www.youtube.com/watch?v=WMBsdhELSwE)
## Setup

- Install Unity
- Install [Google VR SDK](https://developers.google.com/vr/develop/unity/get-started-ios)
- Create Demo Project to verify it all works
- Additional setting
  - Under Resolution and Presentation, uncheck all except ***Landscape Left***, this fixes a bug in the GVR SDK

## Create the Scene

- Add the VR Assets as described in the link above

  - GvrEditorEmulator
  - GvrControllerMain
  - GvrEventSystem
  - GvrRecticlePointer (add to camera)
  - GvrPointerPhysicsRayCaster (add to camera)

- Create a Player
  - Create ```GameObject > Empty Object``` and rename to Player
  - On the Player Object add a CharacterComponent
  - Drag main camera to Player
  - Select Camera and right click on transform and click reset
  - Set Player Position to 1.8
    - we'll use each unit as a meter

- Create some interaction
  - Create ```GameObject > 3d Object > Cube```
  - Create a script that contains some [behaviour](/....)
  - Add component EventTrigger
    - allows the raycaster to detect it
  - Add a script

## Create Terrain and Skybox

- Create Terrain

  - Goto ```Assets >Import Package >Environment```
  - Goto Inspector > Click paint brush > Edit Textures

-- Create Skybox
  - Goto ```Window > Lighting > Settings```
  - Set the Skybox Material (i use Cope)

## Walking
