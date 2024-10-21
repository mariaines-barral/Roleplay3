using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Characters;

[TestFixture]
[TestOf(typeof(Archer))]
public class ArcherTest
{

    [Test]
    public void TestName()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.Name.Equals("Legolas"));
    }
    
    [Test]
    public void TestAttack()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.AttackValue.Equals(15));
    }

    
    [Test]
    public void TestDefense()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.DefenseValue.Equals(18));
    }
    
    [Test]
    public void TestLife()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.Health.Equals(100));

    }
    
    [Test]
    public void TestCureAndDamage()
    {
        Archer archer = new Archer("Legolas");
        archer.ReceiveAttack(50);
        Assert.That(archer.Health.Equals(68));
        archer.ReceiveAttack(150);
        Assert.That(archer.Health.Equals(0));
        archer.Cure();
        Assert.That(archer.Health.Equals(100));
    }
    
    [Test]
    public void TestAddItem()
    {
        Archer archer = new Archer("Legolas");
        Sword sword = new Sword();
        archer.AddItem(sword);
        Assert.That(archer.items.Contains(sword));
    }
    
    [Test]
    public void TestRemoveItem()
    {
        Archer archer = new Archer("Legolas");
        archer.RemoveItem(new Helmet());
        Assert.That(archer.items.Contains(new Helmet())is false);
    }
    
    [Test]
    public void TestVp()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.VP.Equals(0));
    }
    
    [Test]
    public void TestStartItems()
    {
        Archer archer = new Archer("Legolas");
        Assert.That(archer.items.Count.Equals(2));
    }
}