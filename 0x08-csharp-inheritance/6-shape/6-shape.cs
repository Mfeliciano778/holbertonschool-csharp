using System;
using System.Collections.Generic;

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

/// <summary> Class Rectangle inherits from Shape </summary>
class Rectangle : Shape
{
    /// <summary> Private fields </summary>
    private int width;
    private int height;

    /// <summary> A public property with a get and set. </summary>
    /// <value> value to set width </value>
    public int Width
    {
        get => width;
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary> A public property with a get and set. </summary>
    /// <value> value to set height </value>
    public int Height
    {
        get => height;
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}