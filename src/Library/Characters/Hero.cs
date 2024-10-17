namespace Ucu.Poo.RoleplayGame;

public abstract class Hero : Character
{
    public int VP { get; set; }
    
    public Hero(string name) : base(name)
    {
        this.VP = 0;
    }
}