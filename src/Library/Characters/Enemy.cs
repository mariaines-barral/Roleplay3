namespace Ucu.Poo.RoleplayGame;

public abstract class Enemy : Character 
{
    public int VP { get; protected set; }

    public Enemy(string name, int vp): base(name)
    {
        this.VP = vp;
    }
}