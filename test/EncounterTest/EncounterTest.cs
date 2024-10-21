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
    private DespicableKnight caballeroMalandro;
    private Encounter batalla;
    
    [SetUp]
    public void SetUp()
    {
        magoBueno = new Wizard("Gandalf");
        enanoMalo = new MalignantDwarf("Enano Malo", 6);
        arqueroBueno = new Archer("Arquero Malo");
        magoMalo = new RuffianWizard("Mago malo", 5);
        caballeroMalandro = new DespicableKnight("caballero Malandro", 5);
        batalla = new Encounter();
        arqueroBueno.AddItem(new Sword());
    }

    [Test]
    public void AddToEnocunter()
    {
        
    }

    [Test]
    public void Test1V1Enocunter()
    {
        batalla.AddToEncounter(magoBueno);
        batalla.AddToEncounter(enanoMalo);
        batalla.DoEncounter();
        Assert.That(batalla.Enemies.Count, Is.EqualTo(0));
        Assert.That(magoBueno.Health, Is.EqualTo(100));

    }

    [Test]
    public void Test2v1Encounter()
    {
        batalla.AddToEncounter(magoBueno);
        batalla.AddToEncounter(enanoMalo);
        batalla.AddToEncounter(caballeroMalandro);
        batalla.DoEncounter();
        Assert.That(batalla.Enemies.Count, Is.EqualTo(0));
        Assert.That(magoBueno.Health, Is.EqualTo(100));

    }
}