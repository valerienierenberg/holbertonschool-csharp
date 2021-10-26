using System;

///<summary>Abstract Base class</summary>
public abstract class Base
{
    ///<summary>Public property name</summary>
    public string name = "";

    ///<summary>ToString() override method</summary>
    public override string ToString()
    {
        return $"{this.name}" + " is a " + $"{this.GetType()}";
    }
}
