using System;
using System.Collections.Generic;

/// <summary> Class Obj </summary>
class Obj
{
    /// <summary> Returns true if an object is an instance of another class </summary>
    /// <param name="obj"> Object to check </param>
    /// <returns>true or false </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}