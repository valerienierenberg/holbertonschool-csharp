# 0x0A. C# - Generics
- [Project Page](https://intranet.hbtn.io/projects/485)

# Learning Objectives
- What are generics and what are their purpose
- What common generic classes and interfaces are provided in the .NET class library
- When and how to create generic classes
- When and how to create generic methods
- How access modifiers affect a class and its members
- What is the default(T) expression used for
- What is covariance and contravariance

## Requirements
- Allowed editors: Visual Studio Code
- All files will be compiled on Ubuntu 14.04 LTS using dotnet
- A README.md file, at the root of the folder of the project, is mandatory
- All default C# files named Program.cs should be renamed to the name given in each task.
- Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task - names on the folders are correct
- You do not need to push your obj/ or bin/ folders
- In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
- All your public classes and their members should have XML documentation tags
- All your private classes and members should be documented but without XML documentation tags

# Task Descriptions
- 0-queue/, 0-queue/0-queue.csproj, 0-queue/queue.cs : Create a new class called Queue<T>.
- 1-enqueue/, 1-enqueue/1-enqueue.csproj, 1-enqueue/queue.cs : Based on 0-queue, within Queue<T>, create a public class called Node.
- 2-dequeue/, 2-dequeue/2-dequeue.csproj, 2-dequeue/queue.cs : Based on 1-enqueue, add a new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value.
- 3-peek/, 3-peek/3-peek.csproj, 3-peek/queue.cs : Based on 2-dequeue, add a new method Peek() to the class Queue<T> that returns the value of the first node of the queue without removing the node.
- 4-print/, 4-print/4-print.csproj, 4-print/queue.cs : Based on 3-peek, add a new method Print() to the class Queue<T> that prints the queue, starting from the head.
- 5-concatenate/, 5-concatenate/5-concatenate.csproj, 5-concatenate/queue.cs : Based on 4-print, create a method Concatenate() that concatenates all values in the queue only if the queue is of type String or Char.
