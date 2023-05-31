using System;

/// <summary> Decoration class </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary> isQuestItem Property </summary>
    public bool isQuestItem = false;
    ///<summary> durability Property </summary>
    public int durability { get; set; }

    ///<summary> Decoration Constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary> Interact Method </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", this.name);
            return;
        }
        if (isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    ///<summary> Break Method </summary>
    public void Break()
    {
        durability--;
        if (durability < 0)
            Console.WriteLine("The {0} is already broken.", this.name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
    }

}