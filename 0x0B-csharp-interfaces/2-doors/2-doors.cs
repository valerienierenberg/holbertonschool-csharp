using System;

///<summary>Abstract Base class</summary>
public abstract class Base
{
    ///<summary>Public property name</summary>
    public string name { get; set; }

    ///<summary>ToString() override method</summary>
    public override string ToString()
    {
        return (this.name) + " is a " + (this.GetType());
    }
}

///<summary>IInteractive interface</summary>
public interface IInteractive
{
    void Interact();
}

///<summary>IBreakable interface</summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>ICollectable interface</summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class Door : Base, IInteractive
{
    ///<summary>Constructor</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary>Interact() method</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}
