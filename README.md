# DeepTraffic3D
A 3D view the DeepTraffic project as part of MIT 6.S094 Deep Learning for Self-Driving Cars

https://chrmi.github.io/DeepTraffic3D/

This project aims to give a 3D view to the DeepTraffic project using Unity, targeting WebGL (as to leverage all of the same JavaScript functionality of the existing project).  

https://selfdrivingcars.mit.edu/deeptraffic/

### Progress
1.17.2018: 
* Simple first-person view from an Asset Store Collada car model.
* Animated textures on the road to give a motion implication (same as the falling dotted lines in the original).
* Animated sunset
* Several PoC cars are introduced to the scene on load.
* Cars are propelled forward using physics (force), vs fixed interval -- this will allow for applying a *gas pedal*, vs moving fixed units as speed.
* WebGL Template including auto-resizing canvas (responsive), and integration of ConvNetJS.
* Top-down Camera (disabled, used for debugging).

### TODO
1.17.2018:
* There is cross communication between the Unity and Browser layers to facilitate loading, but this should be expanded to support feeding ConvNetJS back into Unity.
* Better 3D models / graphics / design.
* A means to load simulations
* Support for simulations (remove placeholder cars).
* UI layer for switching between first person and top-down camera.
* Too much to list -- this is just an initial proof of concept.
