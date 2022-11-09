using System;



public class Tool : Item
{
    public Tool()
    {
        Name = "tool";
        Rarity = generator.Next(1, 10);
    }
}
