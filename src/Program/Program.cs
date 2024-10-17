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
        Battlefield batalla = new Battlefield();
        batalla.AddEnemy(caballeroMalo);
        batalla.AddEnemy(dwarfMalandro);
        batalla.AddHero(caballeroBueno);
        batalla.DoEncounter();
        
        
        Dwarf dwarfbueno = new Dwarf("Dwarf Bueno");
        Battlefield batalla2 = new Battlefield();
        batalla2.AddEnemy(caballeroMalo);
        //batalla2.AddEnemy(dwarfMalandro);
        batalla2.AddHero(caballeroBueno);
        batalla2.AddHero(dwarfbueno);
        batalla2.DoEncounter();
    }
}
