using System;
using System.Collections.Generic;

namespace POOI_Module08_Heritage;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(new DateTime(2010, 10, 1), 161, 12000);
        lion.DepenserEnergie(1);
        lion.GagnerEnergie(1);
        lion.MangerGazelle(10000);
        lion.MangerZebre(53000);

        Poule poule = new Poule(new DateTime(2018, 3, 23), 3.3, 1600);
        poule.DepenserEnergie(1);
        poule.GagnerEnergie(1);
        poule.MangerGraines(350);

        Animal animal1 = lion;
        Animal animal2 = poule;

        List<Animal> listeAnimaux = new List<Animal>();
        listeAnimaux.Add(lion);
        listeAnimaux.Add(poule);

        // Erreurs :
        //animal1.MangerGazelle(1223);
        //animal2.MangerGraines(12);
    }
}
