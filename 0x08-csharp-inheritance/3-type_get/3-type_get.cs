using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Class obj </summary>
class Obj
{
    /// <summary> Prints properties and methods </summary>
    /// <param name="myObj"> The obj we get the properties and methods from </param>
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var prop in myObj.GetType().GetProperties())
            Console.WriteLine(prop.Name);
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var meth in myObj.GetType().GetMethods())
            Console.WriteLine(meth.Name);
    }
}