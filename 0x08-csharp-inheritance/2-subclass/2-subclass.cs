using System;

/// <summary> Class Obj </summary>
class Obj
{
    /// <summary> Returns true if the object is a subclass of a class</summary>
    /// <param name="derivedType"> Subclass/child </param>
    /// <param name="baseType"> Class/parent </param>
    /// <returns>true or false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
