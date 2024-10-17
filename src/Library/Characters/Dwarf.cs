using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Dwarf: Hero
{
    public Dwarf(string name) : base(name)
    {
        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }
}
