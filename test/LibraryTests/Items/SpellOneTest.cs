using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(SpellOne))]
public class SpellOneTest
{

    [Test]
    public void TestSpellOne()
    {
        SpellOne hechizo = new SpellOne();
        Assert.That(hechizo.DefenseValue, Is.EqualTo(70));
        Assert.That(hechizo.AttackValue, Is.EqualTo(70));
    }
}