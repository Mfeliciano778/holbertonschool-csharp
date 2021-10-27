using System;

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
            this.maxHp = 100f;
            this.hp = 100f;
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
    public delegate int CalculateHealth(float damage);

    /// <summary>
    /// Prints the amount of damage taken
    /// </summary>
    /// <param name="damage"> The amount of damage taken </param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            System.Console.WriteLine($"{name} takes 0 damage!");
        else
        {
            System.Console.WriteLine($"{name} takes {damage} damage!");   
        }
    }

    /// <summary>
    /// Prints the amount of heal given
    /// </summary>
    /// <param name="heal"> Amount of heal given </param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            System.Console.WriteLine($"{name} heals 0 HP!");
        else
        {
            System.Console.WriteLine($"{name} heals {heal} HP!");
        }
    }
}
