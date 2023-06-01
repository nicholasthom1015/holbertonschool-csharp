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

    /// <summary> Status </summary>
    private string status;

    /// <summary> Player delegate </summary>
    public delegate void CalculateHealth(float amount);
    
    /// <summary> HPCheck EventHandler </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = String.Format("{0} is ready to go!", name);
        HPCheck += CheckStatus;
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
        ValidateHP(hp - damage);
    }

    /// <summary> HealDamage Method </summary>
    public void HealDamage(float heal)
    {
        if( heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);

    }

    /// <summary> Validates HP </summary>
    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0, maxHp);
        OnCheckStatus( new CurrentHPArgs(this.hp));
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp/maxHp <= 0.25)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if ( e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
            return ;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Health is low!");
        Console.ResetColor();
    }

    /// <summary> ApplyModifier Method </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }

    /// <summary> CheckStatus Method </summary>
    public void CheckStatus(object sender, CurrentHPArgs e)
    {
        float state = e.currentHp/maxHp;
        if (state == 1)
            status = String.Format("{0} is in perfect health!", name);
        else if (state >=0.5f)
            status = String.Format("{0} is doing well!", name);
        else if (state >=0.25f)
            status = String.Format("{0} isn't doing too great...", name);
        else if (state >0f)
            status = String.Format("{0} needs help!", name);
        else
            status = String.Format("{0} is knocked out!", name);


        Console.WriteLine(status);
    }


}

/// <summary> Modifier Enum </summary>
public enum Modifier
{
    /// <summary> Weak Modifier </summary>
    Weak,
    /// <summary> Base Modifier </summary>
    Base,
    /// <summary> Strong Modifier </summary>
    Strong
}

/// <summary> CalculateModifier Delegate </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> CurrentHPArgs Class </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> currentHp property </summary>
    public float currentHp { get; }

    /// <summary> CurrentHPArgs Constructor </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}