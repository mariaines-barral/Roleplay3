using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Armor))]
public class ArmorTest
{

    [Test]
    public void TestArmor()
    {
        Armor armadura = new Armor();
        Assert.That(armadura.DefenseValue, Is.EqualTo(25));
    }
}