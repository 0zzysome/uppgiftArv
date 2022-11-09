using System;


public class Weapon
{
    public string Name { get; set; }    
    protected int Damage { get; set; } = 10;

    public virtual void attack(Character target)
    {
        
    }
}
