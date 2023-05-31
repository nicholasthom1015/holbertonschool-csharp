using System;

/// <summary> Key Class </summary>
class Key : Base, ICollectable
{
    /// <summary> isCollected Property  </summary>
    public bool isCollected { get; set; }

    /// <summary> Key Constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary> Collect Method </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.",this.name);
        }
        else
            Console.WriteLine("You have already picked up the {0}.", this.name);
    }
}