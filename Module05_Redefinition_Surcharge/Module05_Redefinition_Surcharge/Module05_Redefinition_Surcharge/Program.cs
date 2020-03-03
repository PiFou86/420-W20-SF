using System;
using System.Diagnostics;
using System.Threading;

namespace Module05_Redefinition_Surcharge
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestsParametres();

            // TestsPerformanceToString();

            TestsEqualsEtOp();
        }

        public static void TestsParametres()
        {
            UneClasse uneClasse = new UneClasse();
            uneClasse.VariationNbParametres();
            uneClasse.VariationNbParametres(1);
            uneClasse.VariationNbParametres(1, 2);
            Console.Out.WriteLine();

            uneClasse.VariationTypeParametres(1);
            uneClasse.VariationTypeParametres(1.0);
            uneClasse.VariationTypeParametres(1.0f);
            uneClasse.VariationTypeParametres(1L);
            Console.Out.WriteLine();

            uneClasse.VariationTypeParametres2(1);
            uneClasse.VariationTypeParametres2(1.0);
            uneClasse.VariationTypeParametres2(1.0f);
            uneClasse.VariationTypeParametres2(1L);
            Console.Out.WriteLine();

            uneClasse.VariationTypeParametres3(1, 1.0);
            uneClasse.VariationTypeParametres3(1.0, 1.0);
            //uneClasse.VariationTypeParametres3(1, 1);
            Console.Out.WriteLine();

            uneClasse.ParametresValeursDefaut();
            uneClasse.ParametresValeursDefaut(1);
            uneClasse.ParametresValeursDefaut(1, 2);
            uneClasse.ParametresValeursDefaut(p_entierA: 2);
            uneClasse.ParametresValeursDefaut(p_entierB: 2);
            Console.Out.WriteLine();

            uneClasse.Mixe();
            uneClasse.Mixe(1, 1.0);
            uneClasse.Mixe(1.0, 1);
            uneClasse.Mixe(1.0, 1.0);
            uneClasse.Mixe(1L, 1);
            //uneClasse.Mixe(1, 1);
            Console.Out.WriteLine();
        }

        public static void TestsEqualsEtOp()
        {
            Voiture voiture = new Voiture() { Couleur = "Rouge", NombrePortes = 2, Vitesse = 0.0 };
            Voiture voitureCopyRef = voiture;
            Voiture voitureCopy = new Voiture() { Couleur = "Rouge", NombrePortes = 2, Vitesse = 0.0 };
            Voiture v2 = new Voiture();

            Console.Out.WriteLine($"Test voiture.Equals(v2) : {voiture.Equals(v2)}");
            Console.Out.WriteLine($"Test voiture == v2 : {voiture == v2}");
            Console.Out.WriteLine($"Test voiture != v2 : {voiture != v2}");
            Console.Out.WriteLine();

            Console.Out.WriteLine($"Test voiture.Equals(voitureCopyRef) : {voiture.Equals(voitureCopyRef)}");
            Console.Out.WriteLine($"Test voiture == voitureCopyRef : {voiture == voitureCopyRef}");
            Console.Out.WriteLine($"Test voiture != voitureCopyRef : {voiture != voitureCopyRef}");
            Console.Out.WriteLine();

            Console.Out.WriteLine($"Test voiture.Equals(voitureCopy) : {voiture.Equals(voitureCopy)}");
            Console.Out.WriteLine($"Test voiture == voitureCopy : {voiture == voitureCopy}");
            Console.Out.WriteLine($"Test voiture != voitureCopy : {voiture != voitureCopy}");
            Console.Out.WriteLine();
        }

        public static void TestsPerformanceToString()
        {
            VoitureTestsToString voiture = new VoitureTestsToString() { Couleur = "Rouge", NombrePortes = 2, Vitesse = 0.0 };

            Stopwatch sw = null;
            int nbEssais = 10_000_000;
            sw = Stopwatch.StartNew();
            for (int i = 0; i < nbEssais; i++)
            {
                string a = voiture.ToString();
            }
            sw.Stop();
            Console.Out.WriteLine($"ToString  : {sw.ElapsedTicks}");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < nbEssais; i++)
            {
                string a = voiture.ToString2();
            }
            sw.Stop();
            Console.Out.WriteLine($"ToString2 : {sw.ElapsedTicks}");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < nbEssais; i++)
            {
                string a = voiture.ToString3();
            }
            sw.Stop();
            Console.Out.WriteLine($"ToString3 : {sw.ElapsedTicks}");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < nbEssais; i++)
            {
                string a = voiture.ToString4();
            }
            sw.Stop();
            Console.Out.WriteLine($"ToString4 : {sw.ElapsedTicks}");
        }
    }
}
