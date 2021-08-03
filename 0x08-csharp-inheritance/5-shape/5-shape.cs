using System;

/// <summary> Class Shape throws an exception error with a message.</summary>
class Shape
{
    /// <summary> Throws an exception error with a message.</summary>
    /// <returns> An exception.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}