using System;
using System.Reflection;
using System.Linq;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsOnlyASubclass method</summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] pInfo;
        MethodInfo[] mInfo;

        pInfo = myObj.GetType().GetProperties();
        mInfo = myObj.GetType().GetMethods();
        Console.WriteLine("{0} Properties:", myObj.GetType().Name); // prints the type of the object
        for (int i = 0; i < pInfo.Length; i++)
        {
            Console.WriteLine(pInfo[i].Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name); // prints the type of the object
        for (int i = 0; i < mInfo.Length; i++)
        {
            Console.WriteLine(mInfo[i].Name);
        }
    }
}
