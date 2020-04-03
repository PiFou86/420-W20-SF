using POOI_Heritage_CompteBancaireSansAbstraction.Comptes;
using System;

namespace POOI_Heritage_CompteBancaireSansAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoUtilisation();
        }

        private static void DemoUtilisation()
        {
			CompteBancaire cbai = new CompteAInteret(1000);

			cbai.Retirer(100);
			cbai.Deposer(100);

			try
			{
				cbai.Retirer(1000);
			}
			catch (InvalidOperationException invalidOperationEx)
			{
				Console.Error.WriteLine(invalidOperationEx.Message);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Erreur non prévue");
				Console.Error.WriteLine(ex.Message);
			}
			cbai.AfficherHistoriqueCompte();

			Console.Out.WriteLine();

			CompteBancaire cbmc = new CompteAvecMargeCredit(1000);

			cbmc.Retirer(100);
			cbmc.Deposer(100);

			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);
			cbmc.Retirer(1000);

			cbmc.AfficherHistoriqueCompte();
		}
    }
}
