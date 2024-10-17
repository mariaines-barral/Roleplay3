namespace Ucu.Poo.RoleplayGame;

public abstract class MagicalHero : Hero
{
       private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

       public void AddItem(IMagicalItem magicalItem)
       {
             this.magicalItems.Add(magicalItem); 
       }

       public void RemoveItem(IMagicalItem magicalItem)
       {
           this.magicalItems.Remove(magicalItem);
       }

       public MagicalHero(string name, int vp) : base(name, vp)
       {

       }
}