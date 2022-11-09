using System;

public class Item
{
    public int Rarity { get; set; }
    public string Name { get; set; }
    protected static Random generator = new(); 
}
