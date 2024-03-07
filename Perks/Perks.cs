using System;

namespace HeroPerks
{
 [Flags]
public enum Perks
{
    None = 0,
    WaterBreathing = 1,
    Stealth = 2,
    AutoHeal = 4,
    DoubleJump = 8
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}
}