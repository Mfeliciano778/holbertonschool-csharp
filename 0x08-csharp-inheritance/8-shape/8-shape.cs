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

    /// <summary> Finds and returns the area of a rectangle </summary>
    /// <returns> Area of Rectangle </returns>
    public new int Area()
    {
        return (Height * Width);
    }

    /// <summary> .toString() override to print Rectangle information. </summary>
    /// <returns> [Rectangle] width / height. </returns>
    public override string ToString()
    {
        return ("[Rectangle] " + Width + " / " + Height);
    }
}

class Square : Rectangle
{
    /// <summary> Private fields </summary>
    private int size;

    /// <summary> A public property with a get and set. </summary>
    /// <value> value to set height, size and width </value>
    public int Size {
        get => size;
        set {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                Height = size;
                Width = size;
            }
        }
    }
}