using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Shield))]
public class ShieldTest
{

    [Test]
    public void TestShield()
    {
        Shield escudo = new Shield();
        Assert.That(escudo.DefenseValue, Is.EqualTo(14));
    }
}