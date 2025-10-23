# 3d-modelling-animation-unity-integration
An Animation Scene in Unity developed as part of an academic project for the course **Development of vector graphics(2D), models (3D) and Animation**.

## Project Overview
Modelling and Animating were made in Blender.  

### First Animation: The Flower
[Κατέβασε το βίντεο demo.mp4](animation-vid/animation1.mp4)  
The animation depicts a flower dancing to the rythm of jazz music. Every part of flower's body (stem, flower, petals, leaves) participates in the dance.
- **Frequency:** 25 fps
- **Duration:** 300 frames, 12 sec 
- Rigging με bones
- Skinning με Automatic Weights
- Έντονο acting
- Animation with Keyframes

### Second Animation: The Pensil Case
[Κατέβασε το βίντεο demo.mp4](animation-vid/animation2.mp4)  
The model consists of individual objects: two pencils, a ruler and a marker  
The animation depicts a pencil case reacting to an allergic episode, caused by the flower (the two animations interact on scene).
- **Frequency:** 25 fps
- **Duration:** 350 frames, 14 sec 
- Dynamic Camera movement
- Timing and anticipation
- Animation with Physics (Bake to Keyframes)

### Unity Scene
- Animations are controlled with Animation Controller component
- Cameras' movement, sound and UI were script-controlled  
  
There are 3 choices while running the demo:
- Animation 1 display *(with key A)*
- Animation 2 display *(with key B)*
- Whole animation scene display (both animations and their interaction) *(with key space)*

## Tech Stack
**Engine:** Unity  
**Language:** C#  
**Tools:** Blender

## How to Run
- Open the Project in Unity 2022.3.3f1
- The *Library* folder has been deleted to reduce the project size, so you need to select the *MainScene* from the *Scenes* folder.
- Press A,B or space
