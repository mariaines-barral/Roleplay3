namespace Ucu.Poo.RoleplayGame;

public abstract class MagicalHero : Hero
{
       private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
       
       public MagicalHero(string name) : base(name)
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