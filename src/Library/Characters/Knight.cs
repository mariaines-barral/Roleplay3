using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Knight: Hero
{
    public Knight(string name) : base(name)
    {
        this.AddItem(new Sword());
        //this.AddItem(new Armor());
    }
}
