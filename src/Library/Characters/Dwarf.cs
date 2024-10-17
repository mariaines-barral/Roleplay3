using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Dwarf: Hero
{
    public Dwarf(string name) : base(name)
    {
        IItem axe = new Axe();
        IItem shield = new Shield();
        IItem helmet = new Helmet();
        this.AddItem(axe);
        this.AddItem(shield);
        this.AddItem(helmet);
    }
}
