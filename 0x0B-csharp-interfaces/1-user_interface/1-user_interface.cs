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

    ///<summary>Break method</summary>
    void Collect();
}

///<summary>TestObject class</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>durability setter</summary>
    public int durability { get; set; } = 1;

    ///<summary>isCollected setter</summary>
    public bool isCollected { get; set; } = false;

    ///<summary>Interact method</summary>
    public void Interact()
    {
    }
    ///<summary>Break method</summary>
    public void Break()
    {
    }
    ///<summary>Collect method</summary>
    public void Collect()
    {
    }
}
