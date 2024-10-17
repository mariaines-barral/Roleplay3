namespace Ucu.Poo.RoleplayGame;

public class MagicalEnemy : Enemy
{
    private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
    
    public MagicalEnemy(string name, int vp) : base(name, vp)
    {
        
    }

    public void AddItem(IMagicalItem magicalItem)
    {
        this.magicalItems.Add(magicalItem); 
    }

    public void RemoveItem(IMagicalItem magicalItem)
    {
        this.magicalItems.Remove(magicalItem);
    }
}