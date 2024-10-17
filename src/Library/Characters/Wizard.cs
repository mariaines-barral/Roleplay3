using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard: MagicalHero
{
    public Wizard(string name) : base(name)
    {
        this.AddItem(new Staff());
        this.AddItem(new SpellsBook());
    }   

}
