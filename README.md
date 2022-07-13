# Indoor-Augmented-Reality-Navigation-System
An Indoor Augmented Reality Navigation System using Unity

Indoor AR Navigation is an Augmented Reality based navigation system that allows users to navigate within large buildings and spaces. The primary objective of the project is to design and build indoor navigation applications for the computer engineering for Advanced College of Engineering . 
The four core components of Indoor Augmented Reality Navigation can be described as follows:
1. AR-Core Localization
The real challenge in indoor navigation is positioning, orienting, and tracking a user’s device in the AR world. The motion tracking and environment understanding of ARCore will help us move the person correctly according to our own environment. The person has a camera as a child that looks straight down and renders its view to a raw image used as a Minimap.

2. Unity Nav-Mesh Navigation
When using Unity, we can make use of NavMesh components to indicate walkable surfaces and pathfinding can be done easily using built in functions. NavMesh is a map of the area where any object can walk. The object can automatically find a path to their destination and move there after a walkable surface is set.  
3. On-Touch Repositioning
The start position synchronization is handled using the on-touch function. The start position is already predefined, and when the user touches the screen start position gets repositioned to the original position. A person which is indicated as a sphere will be able to accurately follow real-life movement around on the map.

4. Path Showing with Augmented Reality
A line spawns in front of the user will point in the direction the user needs to go as soon as a destination is chosen. The line to the user is visible as soon as the user touches the screen.

Result

![image](https://user-images.githubusercontent.com/108611184/178309600-a4790180-848b-46fd-8cd3-5d3e53b5d8b1.png)

Output of Indoor AR Navigation System of ACEM


![image](https://user-images.githubusercontent.com/108611184/178309680-af282e15-1629-4a55-9417-af28271d208f.png)

Switch View with Minimap


![image](https://user-images.githubusercontent.com/108611184/178310286-61c1b52e-74d0-4275-85a2-fc10d17600a1.png)

Minimap for Indoor Navigation System of ACEM
A Minimap in 2D is shown with a small dot indicating the current location and following the path to destination. Minimap is centered on the object and the user is able to switch view from mini-map to full screen view so that the lines are easily visible and the information can be easily recognized by the user.


https://user-images.githubusercontent.com/108611184/178787331-c974bedb-3e6f-4037-973e-30ee60f35823.mp4

