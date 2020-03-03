using System;
using System.Collections.Generic;
using System.Text;

namespace Module05_Redefinition_Surcharge
{
    public class UneClasse
    {
        public void VariationNbParametres()
        {
            Console.Out.WriteLine("VariationNbParametres()");
        }

        public void VariationNbParametres(int p_entier1)
        {
            Console.Out.WriteLine("VariationNbParametres(int p_entier1)");
        }

        public void VariationNbParametres(int p_entier1, int p_entier2)
        {
            Console.Out.WriteLine("VariationNbParametres(int p_entier1, int p_entier2)");
        }


        //        Console.Out.WriteLine("");

        public void VariationTypeParametres(int p_entier1)
        {
            Console.Out.WriteLine("VariationTypeParametres(int p_entier1)");
        }

        public void VariationTypeParametres(double p_reel1)
        {
            Console.Out.WriteLine("VariationTypeParametres(double p_reel1)");
        }

        public void VariationTypeParametres2(long p_entier1)
        {
            Console.Out.WriteLine("VariationTypeParametres2(long p_entier1)");
        }

        public void VariationTypeParametres2(double p_reel1)
        {
            Console.Out.WriteLine("VariationTypeParametres2(double p_reel1)");
        }

        public void VariationTypeParametres3(int p_entier1, double p_reel2)
        {
            Console.Out.WriteLine("VariationTypeParametres3(int p_entier1, double p_reel2)");
        }
        public void VariationTypeParametres3(double p_reel1, int p_entier2)
        {
            Console.Out.WriteLine("VariationTypeParametres3(double p_reel1, int p_entier2)");
        }

        public void VariationTypeParametres3(double p_reel1, double p_reel2)
        {
            Console.Out.WriteLine("VariationTypeParametres3(double p_reel1, double p_reel2)");
        }


        public void ParametresValeursDefaut(int p_entier1)
        {
            Console.Out.WriteLine("ParametresValeursDefaut(int p_entier1)");
        }

        public void ParametresValeursDefaut(int p_entierA = 0, int p_entierB = 0)
        {
            Console.Out.WriteLine("ParametresValeursDefaut(int p_entierA = 0, int p_entierB = 0)");
        }

        public void Mixe(int p_entier1, double p_reel2)
        {
            Console.Out.WriteLine("Mixe(int p_entier1, double p_reel2)");
        }
        public void Mixe(double p_reel1, int p_entier2)
        {
            Console.Out.WriteLine("Mixe(double p_reel1, int p_entier2)");
        }
        public void Mixe(double p_reel1 = 0.0, double p_reel2 = 0.0)
        {
            Console.Out.WriteLine("Mixe(double p_reel1 = 0.0, double p_reel2 = 0.0)");
        }
        //public int VariationTypeRetour()
        //{
        //    return 0;
        //}
        //public double VariationTypeRetour()
        //{
        //    return 0.0;
        //}


    }
}
