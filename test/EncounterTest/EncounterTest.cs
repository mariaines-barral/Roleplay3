using Library;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace EncounterTest;

[TestFixture]
[TestOf(typeof(Encounter))]
public class EncounterTest
{
    private Wizard magoBueno;
    private MalignantDwarf enanoMalo;
    private Archer arqueroBueno;
    private RuffianWizard magoMalo;
    private Encounter batalla;
    
    [SetUp]
    public void SetUp()
    {
        magoBueno = new Wizard("Gandalf");
        enanoMalo = new MalignantDwarf("Enano Malo", 6);
        arqueroBueno = new Archer("Arquero Malo");
        magoMalo = new RuffianWizard("Mago malo", 5);
        batalla = new Encounter();
        arqueroBueno.AddItem(new Sword());
    }

    [Test]
    public void TestAddToEnocunter()
    {
        batalla.AddToEncounter(magoBueno);
        batalla.AddToEncounter(magoMalo);
        Assert.That(batalla.Enemies.Contains(magoMalo));
        Assert.That(batalla.Heroes.Contains(magoBueno));
        batalla.AddToEncounter(arqueroBueno);
        Assert.That(batalla.Heroes.Count, Is.EqualTo(2));
    }
    
    [Test]
    public void TestVPAndCure()
    {
        arqueroBueno.AddItem(new Axe());
        batalla.AddToEncounter(enanoMalo);
        batalla.AddToEncounter(arqueroBueno);
        batalla.DoEncounter();
        Assert.That(arqueroBueno.VP, Is.EqualTo(1));
        Assert.That(arqueroBueno.Health, Is.EqualTo(100));
    }
}