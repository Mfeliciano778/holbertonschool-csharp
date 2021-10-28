using System;

/// <summary>
/// Enum that holds the values weak, base, strong
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak mod
    /// </summary>
    Weak,
    /// <summary>
    /// Base mod
    /// </summary>
    Base,
    /// <summary>
    /// Strong mod
    /// </summary>
    Strong
}

/// <summary>
/// The delegate to calculate the modifier
/// </summary>
/// <param name="baseValue"> The regular value of damage</param>
/// <param name="modifier"> Modified amount </param>
/// <returns> New damage amount </returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Class holding the properties and methods of a Player
/// </summary>
public class Player
{
    /// <summary>
    /// Name of the player
    /// </summary>
    private string name;
    /// <summary>
    /// The max HP of the player
    /// </summary>
    private float maxHp;
    /// <summary>
    /// The total hp the player has
    /// </summary>
    private float hp;

    /// <summary>
    /// The constructor of the Player class
    /// </summary>
    /// <param name="name"> Name of the player </param>
    /// <param name="maxHp"> Max HP of the player </param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.name = name;
    }

    /// <summary>
    /// Prints the health the player currently has
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Delegate to calculate health
    /// </summary>
    /// <param name="damage"> Amount of damage taken </param>
    /// <returns> Nothing yet </returns>
    public delegate void CalculateHealth(float damage);

    /// <summary>
    /// Prints the amount of damage taken
    /// </summary>
    /// <param name="damage"> The amount of damage taken </param>
    public void TakeDamage(float damage)
    {
        float newHp;

        if (damage < 0)
        {
            damage = 0;
            System.Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            System.Console.WriteLine($"{name} takes {damage} damage!");   
        }
        newHp = hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Prints the amount of heal given
    /// </summary>
    /// <param name="heal"> Amount of heal given </param>
    public void HealDamage(float heal)
    {
        float newHp;

        if (heal < 0)
        {
            heal = 0;
            System.Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            System.Console.WriteLine($"{name} heals {heal} HP!");
        }
        newHp = hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates the hp before setting it
    /// </summary>
    /// <param name="newHp"> The hp to validate </param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    /// <summary>
    /// Applies the modifier to the base value
    /// </summary>
    /// <param name="baseValue"> The regular damage amount </param>
    /// <param name="modifier"> Modified amount </param>
    /// <returns> New damage amount </returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}
