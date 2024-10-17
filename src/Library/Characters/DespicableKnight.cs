namespace Ucu.Poo.RoleplayGame;

public class DespicableKnight: Enemy
{
    public DespicableKnight(string name, int vp): base(name, vp)
    {
        this.AddItem(new Sword());
        //this.AddItem(new Armor());
    }
}