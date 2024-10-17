using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class EvilArcher: Enemy
{
    public EvilArcher(string name, int vp) : base(name, vp)
    {
        IItem bow = new Bow();
        IItem helmet = new Helmet();
        this.AddItem(bow);
        this.AddItem(helmet);
    }
}
