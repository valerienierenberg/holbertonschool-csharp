using System;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}

//
// another way:
//
// if (obj.GetType() == typeof(int))
//     return true....
//