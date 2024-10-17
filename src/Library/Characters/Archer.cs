using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Archer: Hero
{
    public Archer(string name, int vp) : base(name, vp)
    {
        IItem bow = new Bow();
        IItem helmet = new Helmet();
        this.AddItem(bow);
        this.AddItem(helmet);
    }
}
