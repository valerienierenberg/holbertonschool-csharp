using System;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsjInstanceOfArray method</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
