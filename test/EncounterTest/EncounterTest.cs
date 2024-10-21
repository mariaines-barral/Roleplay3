using System.Diagnostics;
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
    private Knight caballeroBueno;
    private Dwarf enanoBueno;
    private DespicableKnight caballeroMalandro;
    private Encounter batalla;
    
    [SetUp]
    public void SetUp()
    {
        magoBueno = new Wizard("Gandalf");
        enanoMalo = new MalignantDwarf("Enano Malo", 6);
        arqueroBueno = new Archer("Arquero Malo");
        magoMalo = new RuffianWizard("Mago malo", 5);
        caballeroBueno = new Knight("Raul");
        enanoBueno = new Dwarf("Dobby");
        
        caballeroMalandro = new DespicableKnight("caballero Malandro", 5);
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

    [Test]
    public void Test2V2()
    {
        batalla.AddToEncounter(magoMalo);
        batalla.AddToEncounter(enanoMalo);
        batalla.AddToEncounter(caballeroBueno);
        batalla.AddToEncounter(enanoBueno);
        batalla.DoEncounter();
        Assert.That(enanoBueno.VP, Is.EqualTo(0));
        Assert.That(caballeroBueno.VP, Is.EqualTo(0));
        Assert.That(enanoBueno.Health, Is.EqualTo(0));
        Assert.That(caballeroBueno.Health, Is.EqualTo(0));
        Assert.That(batalla.Heroes.Count, Is.EqualTo(0));
        Assert.That(magoMalo.Health, Is.EqualTo(100));
        Assert.That(enanoMalo.Health, Is.EqualTo(100));
        
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