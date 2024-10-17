using Ucu.Poo.RoleplayGame;

namespace Library;

public class Encounter
{
    public List<Hero> Heroes { get; private set; } = new List<Hero>();
    public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

    public virtual void DoEncounter()
    {
        while (this.Heroes.Count != 0 && this.Enemies.Count != 0)
        {
            if (this.Heroes.Count < this.Enemies.Count) //menos heroes
            {
                int count = 0; //cuenta enemigos que ya pegaron
                while (count < this.Enemies.Count && this.Heroes.Count > 0) //chequeo que queden enemigos por atacar
                {
                    foreach(Hero hero in this.Heroes.ToList()) //todos los heroes son atacados
                    {   
                        if (count < this.Enemies.Count) //vuelvo a chequear que queden enemigos por atacar
                        {
                            hero.ReceiveAttack(this.Enemies[count].AttackValue);
                            if (hero.Health == 0) //si muere lo elimino
                            {
                                this.Heroes.Remove(hero);
                            }
                            count++; //siguiente enemigo
                        }
                    }
                    
                }
            }
            else //menos enemigos o misma cantidad
            {
                for (int i = this.Enemies.Count - 1; i >= 0; i--) //recorre de der a izq para evitar problema de indices
                {
                    this.Heroes[i].ReceiveAttack(this.Enemies[i].AttackValue);
                    if (this.Heroes[i].Health == 0) //si muere lo elimino
                    {
                        this.Heroes.Remove(this.Heroes[i]);
                    }
                }
            }
            
            // le toca a los heroes
            foreach (Enemy enemy in this.Enemies.ToList()) //cada enemigo es golpeado por todos los heroes
            {
                foreach (Hero hero in this.Heroes)
                {
                    enemy.ReceiveAttack(hero.AttackValue);
                    if (enemy.Health == 0) //si muere
                    {
                        hero.VP += enemy.VP; //quien lo mata recive sus VP
                        this.Enemies.Remove(enemy);
                    }
                }
            }

            foreach (Hero hero in this.Heroes)
            {
                if (hero.VP >= 5) //los heroes con mas de 5VP se curan 
                {
                    hero.Cure();
                    hero.VP -= 5; //"canjea" los VP al curarse
                }
            }
        }

        if (this.Heroes.Count > 0)
        {
            Console.WriteLine("Los heroes ganaron :)");
        }
        else
        {
            Console.WriteLine("Los enemigos ganaron :(");
        }
    }

    public void AddHero(Hero hero)
    {
        if (!this.Heroes.Contains(hero))
        {
            this.Heroes.Add(hero);
        }
            
    }

    public void AddEnemy(Enemy enemy)
    {
        if (!this.Enemies.Contains(enemy))
        {
            this.Enemies.Add(enemy);
        }
    }
}