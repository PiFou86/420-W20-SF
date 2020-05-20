using POOI_Exercices_Supp_Soccer_BL;
using POOI_Exercices_Supp_Soccer_BL.partie;
using System;

namespace POOI_Exercices_Supp_Soccer
{
    class Program
    {
        static void Main(string[] args)
        {
            ExempleDeProgramme();
        }

        private static void ExempleDeProgramme()
        {
            Tournoi tournoi = new Tournoi();

            Equipe coreeDuSud = new Equipe(1, "Corée du Sud");
            Equipe france = new Equipe(2, "France");
            Equipe nigeria = new Equipe(3, "Nigeria");
            Equipe norvege = new Equipe(4, "Norvège");

            Partie frcs = tournoi.AjouterPartie(france, coreeDuSud, new DateTime(2019, 6, 7)); // 4 - 0
            Partie frno = tournoi.AjouterPartie(france, norvege, new DateTime(2019, 6, 12)); // 2 - 1

            Partie nifr = tournoi.AjouterPartie(nigeria, france, new DateTime(2019, 6, 8)); // 0 - 1
            Partie nics = tournoi.AjouterPartie(nigeria, coreeDuSud, new DateTime(2019, 6, 12)); // 2 - 0

            Partie noni = tournoi.AjouterPartie(norvege, nigeria, new DateTime(2019, 6, 8)); // 3 - 0

            Partie csno = tournoi.AjouterPartie(coreeDuSud, norvege, new DateTime(2019, 6, 17)); // 1 - 2

            try
            {
                tournoi.AffecterScorePartieEtMAJStatistiques(frcs, 4, 0);
                tournoi.AffecterScorePartieEtMAJStatistiques(frno, 2, 1);
                tournoi.AffecterScorePartieEtMAJStatistiques(nifr, 0, 1);
                tournoi.AffecterScorePartieEtMAJStatistiques(nics, 2, 0);
                tournoi.AffecterScorePartieEtMAJStatistiques(noni, 3, 0);
                tournoi.AffecterScorePartieEtMAJStatistiques(csno, 1, 2);
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                Console.Error.WriteLine(e.Message);
            }

            Console.Out.WriteLine(tournoi.ToString());

            //		Liste des équipes et pointage
            //		Équipe			Pts	PJ	PG	PN	PP	BP	BC
            //		France          9	3	3	0	0	7	1
            //		Norvège         6	3	2	0	1	6	3
            //		Nigeria         3	3	1	0	2	2	4
            //		Corée du Sud    0	3	0	0	3	1	8
        }
    }
}
