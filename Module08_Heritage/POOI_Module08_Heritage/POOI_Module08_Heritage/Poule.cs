using System;

namespace POOI_Module08_Heritage;

public class Poule : Animal
{
    private const double KCALORIES_PAR_GRAMME_GRAINES = 5.23; // Mis au hazard !
    public Poule(DateTime p_dateNaissance, double p_masse, double p_energie) : base(p_dateNaissance, p_masse, p_energie)
    {
        ;
    }

    public void MangerGraines(double p_masseAbsorbeeGrammes)
    {
        if (p_masseAbsorbeeGrammes <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(p_masseAbsorbeeGrammes));
        }

        base.GagnerEnergie(KCALORIES_PAR_GRAMME_GRAINES * p_masseAbsorbeeGrammes);
    }

    public override void EmettreUnSon()
    {
        // si besoin vous pouvez appeler la méthode de
        // la classe mère avec : base.EmettreUnSon();
        Console.Out.WriteLine("Cot cot !");
    }
}
