namespace Ucu.Poo.RoleplayGame;

public class RuffianWizard: MagicalEnemy
{
    public RuffianWizard(string name, int vp) : base(name, vp)
    {
        IItem staff = new Staff();
        IMagicalItem spellbook = new SpellsBook();
        this.AddItem(staff);
        this.AddItem(spellbook);
    }   
}

