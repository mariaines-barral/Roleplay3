namespace Ucu.Poo.RoleplayGame;

public class RuffianWizard: MagicalEnemy
{
    public RuffianWizard(string name, int vp): base(name, vp)
    {
        this.AddItem(new Staff());
        this.AddItem(new SpellsBook());
    }
}