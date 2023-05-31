using System;

/// <summary> Player class </summary>
public class Player
{
    /// <summary> Player name </summary>
    protected string name;
    /// <summary> Player maxHp </summary>
    protected float maxHp;
    /// <summary> Player hp </summary>
    protected float hp;

    /// <summary> Player Constructor </summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if( maxHp <= 0f){
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary> PrintHealth Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

}

public delegate void CalculateHealth(float amount);

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name, float maxHp)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        hp -= damage;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        hp += heal;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
