namespace Ucu.Poo.RoleplayGame;

public class MalignantDwarf: Enemy
{
    public MalignantDwarf(string name, int vp) : base(name, vp)
    {
        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }
}