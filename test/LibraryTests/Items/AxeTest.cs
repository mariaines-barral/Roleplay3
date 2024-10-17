using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Axe))]
public class AxeTest
{

    [Test]
    public void TestAxe()
    {
        Axe hacha = new Axe();
        Assert.That(hacha.AttackValue, Is.EqualTo(25));

    }
}