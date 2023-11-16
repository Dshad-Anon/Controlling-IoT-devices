# Controlling IoT devices
**Objective:**
Develop a C# console application using the Command Pattern to simulate controlling IoT devices. 
This assignment focuses on applying design patterns in a practical scenario to enhance understanding of object-oriented design and C# programming.

**REQUIREMENTS:**
**1.Command Pattern Implementation:**

Utilize the Command Pattern to encapsulate all requests sent to the IoT devices as command objects.
Implement a RemoteController class as the invoker to execute these commands.

**2.IoT Devices:**
-Simulate two IoT devices: a Light and a Thermostat.
-The Light should have commands for turning on and off.
-The Thermostat should have commands for increasing and decreasing the temperature.
-(optional) Try adding additional IoT devices
    e.g. music player, (consider what other functions the number keys (buttons) could have to operate the player, on/off, volume up/down, change song next/prev, etc...) 
    Could some of these functionalities be combined with each other
(optional) Add feature that allows us to turn all devices off at the same time (multiple commands)

**3.Composite Command:**
Implement a composite commands that turns the light on/off and decreases/increases the thermostat's temperature.

**4.User Interaction:**
The program should accept input from the console, using number keys to trigger different commands. (e.g. 1 = turn light on, 2 = turn light off)
Ensure the application provides clear instructions to the user on which keys to press for each command.
Should be able to tell what each key press is going to do
Console should show the current status of each connected device (e.g. the light is ON, thermostat temperature 20)

**5.Error Handling:**
The application should gracefully handle invalid inputs without crashing.

**6.Code Quality:**
Follow C# coding conventions and best practices.
Write clear, maintainable code.
Include comments explaining major sections of the code and any complex logic.
