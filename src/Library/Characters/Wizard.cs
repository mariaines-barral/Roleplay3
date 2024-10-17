using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard: MagicalHero
{
    public Wizard(string name) : base(name)
    {
        IItem staff = new Staff();
        IMagicalItem spellbook = new SpellsBook();
        this.AddItem(staff);
        this.AddItem(spellbook);
    }   

}
