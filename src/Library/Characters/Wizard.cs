using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard: MagicalHero
{
    public Wizard(string name, int vp) : base(name, vp)
    {
        IItem staff = new Staff();
        IMagicalItem spellbook = new SpellsBook();
        this.AddItem(staff);
        this.AddItem(spellbook);
    }   

}
