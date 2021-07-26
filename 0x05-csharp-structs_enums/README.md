# 0x05. C# - Structs, Enumerations
- [Project Page](https://intranet.hbtn.io/projects/425)

## Learning Objectives
- What is a struct
- What is a constructor
- What is a field
- What is a property
- What is an enumeration and when to use them
- What does toString do and how to override it

## Task Descriptions
- 0-dog/, 0-dog/0-dog.csproj, 0-dog/0-dog.cs : Define a new enum Rating with the values Good, Great, Excellent.
- 1-dog/, 1-dog/1-dog.csproj, 1-dog/1-dog.cs : Based on 0-dog, define a new struct Dog with the following members:
    - name, type: public string
    - age, type: public float
    - owner, type: public string
    - rating, type public Rating
- 2-dog/, 2-dog/2-dog.csproj, 2-dog/2-dog.cs : Based on 1-dog, add a constructor to struct Dog that takes parameters.
- 3-dog/, 3-dog/3-dog.csproj, 3-dog/3-dog.cs : Based on 2-dog, override the .ToString() method to print the Dog object’s attributes to stdout.
    - Format: 
    ```
    Dog Name: <name>
    Age: <age>
    Owner: <owner>
    Rating: <rating>
    ```
