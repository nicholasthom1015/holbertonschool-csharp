using System;

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
