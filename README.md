# OpenUPM: Push Generic IID

This tool belongs to a group of generic input utilities that allow you to push data as integer events or compress binary values into integers.

Compressing data into integers enables remote control functionality that uses minimal bandwidth.

- For example, you can compress Xbox controller data into two integers (8 bytes).  
- A 25-LED display, like the micro:bit, can be compressed into a single integer.  
- A precise dual joystick setup can be represented as a single integer, such as `1899887766`.  
- MIDI input can be sent as an integer.  
- Mouse inputs can be transmitted using this method.  
- Quest 3 controller input can also be compressed and sent.  

The idea is to provide tools to compress input data into a single or dual-integer package, optionally including an execution or send date.  

This system is built using Unity3D's InputSystem.

Note: If you’re planning to build a massive multiplayer single-server system, you’ll need this tool alongside a JobSystem and ComputeShader utilities. Check out the repository here:  
[OpenUPM_PushGenericIIDToSNAM16K](https://github.com/EloiStree/OpenUPM_PushGenericIIDToSNAM16K.git)  
