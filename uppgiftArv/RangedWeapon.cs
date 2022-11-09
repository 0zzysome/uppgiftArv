using System;
public class RangedWeapon : Weapon
{
    public int Range { get; set; }= 10;
    public RangedWeapon()
    {
        Damage=15;
    }
}
