using System;
using System.Collections.Generic;
using System.Collections;
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }

    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string Name = "Door")
    {
        name = Name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { set; get; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability < 1)
            System.Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            System.Console.WriteLine($"You look at the {name}. There's a key inside.");
        else if (isQuestItem == false)
            System.Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        durability--;

        if (durability > 0)
            System.Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability < 0)
            System.Console.WriteLine($"The {name} is already broken.");
        else
            System.Console.WriteLine($"You smash the {name}. What a mess.");
    }
}

class Key : Base, ICollectable
{
    public bool isCollected{ get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            System.Console.WriteLine($"You pick up the {name}.");
        } else if (isCollected == true)
        {
            System.Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

class Objs<T> : IEnumerable<T>
{
    private List<T> objectList = new List<T>();

    public void Add(T obj)
    {
        objectList.Add(obj);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return objectList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}