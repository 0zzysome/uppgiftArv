using System;



public class Bow :RangedWeapon
{
    public Bow()
    {
        Name = "Bow";
        Range = 5;
    }
    public override void attack(Character target)
    {
        System.Console.WriteLine($"{Name} attack!");
        Random generator = new Random();
        target.Hp -= generator.Next(5, 10);

    }
}
