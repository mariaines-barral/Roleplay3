using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Bow))]
public class BowTest
{

    [Test]
    public void TestBow()
    {
        Bow arco = new Bow();
        Assert.That(arco.AttackValue, Is.EqualTo(15));
    }
}