namespace Ucu.Poo.RoleplayGame;

public class EvilArcher: Enemy
{
    public EvilArcher(string name, int vp): base(name, vp)
    {
        this.AddItem(new Bow());
        this.AddItem(new Helmet());
    }
}