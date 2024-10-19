using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Sword))]
public class SwordTest
{

    [Test]
    public void TestSword()
    {
        Sword espada = new Sword();
        Assert.That(espada.AttackValue, Is.EqualTo(20));
    }
}