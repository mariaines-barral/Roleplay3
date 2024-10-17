using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Helmet))]
public class HelmetTest
{

    [Test]
    public void TestHelmet()
    {
        Helmet casco = new Helmet();
        Assert.That(casco.DefenseValue, Is.EqualTo(25));

    }
}