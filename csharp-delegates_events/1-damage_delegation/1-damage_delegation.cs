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

    /// <summary> Player delegate </summary>
    public delegate void CalculateHealth(float amount);

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

    /// <summary> TakeDamage Method </summary>
    public void TakeDamage(float damage)
    {
        if( damage < 0f)
            damage = 0f;
            Console.WriteLine("{0} takes {1} damage!", name, damage);
            hp -= damage;
            hp = math.clamp(hp, 0f, maxHp);
    }

    /// <summary> HealDamage Method </summary>
    public void HealDamage(float heal)
    {
        if( heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        hp += heal;
        hp = math.clamp(hp, 0f, maxHp);
    }

}