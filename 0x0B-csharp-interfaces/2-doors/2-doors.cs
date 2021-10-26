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
    ///<summary>Interact method</summary>
    void Interact();
}

///<summary>IBreakable interface</summary>
public interface IBreakable
{
    ///<summary>durability setter</summary>
    int durability { get; set; }
    ///<summary>Break method</summary>
    void Break();
}

///<summary>ICollectable interface</summary>
public interface ICollectable
{
    ///<summary>isCollected setter</summary>
    bool isCollected { get; set; }
    ///<summary>Collect method</summary>
    void Collect();
}

///<summary>Door class</summary>
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
