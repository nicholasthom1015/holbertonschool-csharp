using System;
using System.Collections.Generic;

public class Item : BaseClass
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public List<string> Tags { get; set; }

    public Item(string name, float price)
    {
        Name = name;
        Price = Math.Round(price, 2);
        Tags = new List<string>();
    }
}
