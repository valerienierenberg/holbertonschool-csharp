# 0x0B. C# - Interfaces
- [Project Page](https://intranet.hbtn.io/projects/477)

## Learning Objectives
- What is an interface
- What are interfaces used for
- How do interfaces, classes, and structs differ
- What is an abstract class
- How are interfaces different from abstract classes
- How is an interface implemented explicitly
- What is the as keyword and how to use it

## Requirements
- Allowed editors: Visual Studio Code
- All files will be compiled on Ubuntu 14.04 LTS using dotnet
- A README.md file, at the root of the folder of the project, is mandatory
- You can organize and name your files as you like for this project, just ensure you do not push a file containing a Main method, it may conflict with our testing files.
- Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task - names on the folders are correct
- You do not need to push your obj/ or bin/ folders
- In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
- All your public classes and their members should have XML documentation tags
- All your private classes and members should be documented but without XML documentation tags

## Task Descriptions
- 0-abstract_thinking/, 0-abstract_thinking/0-abstract_thinking.csproj, 0-abstract_thinking/0-abstract_thinking.cs : Create an abstract class called Base
- 1-user_interface/, 1-user_interface/1-user_interface.csproj, 1-user_interface/1-user_interface.cs : Based on 0-abstract_thinking, create an interface called IInteractive.
- 2-doors/, 2-doors/2-doors.csproj, 2-doors/2-doors.cs : Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive.
- 3-decorations/, 3-decorations/3-decorations.csproj, 3-decorations/3-decorations.cs : Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable.
- 4-keys/, 4-keys/4-keys.csproj, 4-keys/4-keys.cs : Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable.
- 5-iterate_act/, 5-iterate_act/5-iterate_act.csproj, 5-iterate_act/5-iterate_act.cs : Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it)
- 6-generic_iteration/, 6-generic_iteration/6-generic_iteration.csproj, 6-generic_iteration/6-generic_iteration.cs : Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach.