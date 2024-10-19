using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(SpellsBook))]
public class SpellsBookTest
{

    [Test]
    public void TestSpellsBook()
    {
        SpellsBook libro = new SpellsBook();
        Assert.That(libro.DefenseValue, Is.EqualTo(0));
        Assert.That(libro.AttackValue, Is.EqualTo(0));
        SpellOne hechizo = new SpellOne();
        libro.AddSpell(hechizo);
        Assert.That(libro.DefenseValue, Is.EqualTo(70));
        Assert.That(libro.AttackValue, Is.EqualTo(70));
        libro.RemoveSpell(hechizo);
        Assert.That(libro.DefenseValue, Is.EqualTo(0));
        Assert.That(libro.AttackValue, Is.EqualTo(0));
    }
}