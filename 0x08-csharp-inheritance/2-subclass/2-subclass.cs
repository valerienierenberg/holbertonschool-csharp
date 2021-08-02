using System;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsOnlyASubclass method</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
