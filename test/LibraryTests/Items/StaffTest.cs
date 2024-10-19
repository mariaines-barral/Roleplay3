using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.Items;

[TestFixture]
[TestOf(typeof(Staff))]
public class StaffTest
{

    [Test]
    public void TestStaff()
    {
        Staff cetro = new Staff();
        Assert.That(cetro.DefenseValue, Is.EqualTo(100));
        Assert.That(cetro.AttackValue, Is.EqualTo(100));
    }
}