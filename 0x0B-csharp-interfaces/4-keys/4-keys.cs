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

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    ///<summary>Constructor</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>Durability property</summary>
    public int durability { get; set; }

    ///<summary>Interact() method</summary>
    public void Interact()
    {
        if (this.durability > 0)
        {
            if (isQuestItem)
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
            else
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
        else
        {
            Console.WriteLine("The {0} has been broken.", this.name);        }
        }

    ///<summary>Break() method</summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        }
        else if (this.durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", this.name);
        }
    }
}

public class Key : Base, ICollectable
{
    ///<summary>Constructor</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary>isCollected property</summary>
    public bool isCollected { get; set; }

    ///<summary>Collect() method</summary>
    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
    }
}
