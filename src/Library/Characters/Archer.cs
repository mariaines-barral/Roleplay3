using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Archer: Hero
{
    public Archer(string name) : base(name)
    {
        IItem bow = new Bow();
        IItem helmet = new Helmet();
        this.AddItem(bow);
        this.AddItem(helmet);
    }
}
