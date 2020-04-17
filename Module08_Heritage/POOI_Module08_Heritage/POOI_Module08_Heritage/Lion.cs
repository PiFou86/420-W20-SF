using System;

namespace POOI_Module08_Heritage
{
    public class Lion : Animal
    {
        public const double KCALORIES_PAR_GRAMME_GAZELLE = 2.5; // Mis au hazard !
        public const double KCALORIES_PAR_GRAMME_ZEBRE = 2.07; // Mis au hazard !
        public Lion(DateTime p_dateNaissance, double p_masse, double p_energie) : base(p_dateNaissance, p_masse, p_energie)
        {
            ;
        }

        public void MangerGazelle(double p_masseAbsorbeeGrammes)
        {
            if (p_masseAbsorbeeGrammes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_masseAbsorbeeGrammes));
            }

            base.GagnerEnergie(KCALORIES_PAR_GRAMME_GAZELLE * p_masseAbsorbeeGrammes);
        }

        public void MangerZebre(double p_masseAbsorbeeGrammes)
        {
            if (p_masseAbsorbeeGrammes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_masseAbsorbeeGrammes));
            }

            base.GagnerEnergie(KCALORIES_PAR_GRAMME_ZEBRE * p_masseAbsorbeeGrammes);
        }

        public override void EmettreUnSon()
        {
            // si besoin vous pouvez appeler la méthode de 
            // la classe mère avec : base.EmettreUnSon();
            Console.Out.WriteLine("Grrrrrr !");
        }
    }
}
