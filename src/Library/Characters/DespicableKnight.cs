using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class DespicableKnight: Enemy
{
    public DespicableKnight(string name, int vp) : base(name, vp)
    {
        IItem sword = new Sword();
        IItem shield = new Shield();
        IItem armor = new Armor();
        this.AddItem(sword);
        this.AddItem(shield);
        this.AddItem(armor);
    }
}
