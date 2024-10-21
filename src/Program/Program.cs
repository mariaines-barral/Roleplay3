using System;
using Library;

namespace Ucu.Poo.RoleplayGame.Program;

class Program
{
    static void Main(string[] args)
    {
        Knight caballeroBueno = new Knight("Caballero Bueno");
        DespicableKnight caballeroMalo = new DespicableKnight("Caballero Malo", 1);
        MalignantDwarf dwarfMalandro = new MalignantDwarf("Dwarf Malandro", 1);
        Encounter batalla = new Encounter();
        batalla.AddToEncounter(caballeroMalo);
        batalla.AddToEncounter(dwarfMalandro);
        batalla.AddToEncounter(caballeroBueno);
        batalla.DoEncounter();
        
        
        Dwarf dwarfbueno = new Dwarf("Dwarf Bueno");
        Encounter batalla2 = new Encounter();
        batalla2.AddToEncounter(caballeroMalo);
        //batalla2.AddEnemy(dwarfMalandro);
        batalla2.AddToEncounter(caballeroBueno);
        batalla2.AddToEncounter(dwarfbueno);
        batalla2.DoEncounter();
    }
}
