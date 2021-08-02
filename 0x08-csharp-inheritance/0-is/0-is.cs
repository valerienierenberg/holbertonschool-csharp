using System;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsOfTypeInt method</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}

//
// another way:
//
// if (obj.GetType() == typeof(int))
//     return true
// else
//     return false
//