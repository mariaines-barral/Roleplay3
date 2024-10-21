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
        
        batalla = new Encounter();
        arqueroBueno.AddItem(new Sword());
    }

    [Test]
    public void AddToEnocunter()
    {
        
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
}