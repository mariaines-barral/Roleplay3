using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Knight: Hero
{
    public Knight(string name, int vp) : base(name, vp)
    {
        IItem sword = new Sword();
        IItem shield = new Shield();
        IItem armor = new Armor();
        this.AddItem(sword);
        this.AddItem(shield);
        this.AddItem(armor);
    }
}
