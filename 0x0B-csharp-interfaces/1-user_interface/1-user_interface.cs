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

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; } = 1;
    public bool isCollected { get; set; } = false;

    public void Interact()
    {
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}
