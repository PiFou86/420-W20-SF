using POOI_Module11_JeuTir.Sons;
using System;

namespace POOI_Module11_JeuTir.Armes
{
    public class PulverisateurCarottes : Arme
    {
        public PulverisateurCarottes() : base(new Son() { TexteDuSon = "GloupGloup" }, new Son() { TexteDuSon = "Gloupeufpeufpeuf" })
        {
            ;
        }

        protected override double CalculerDegat()
        {
            return (new Random(DateTime.Now.Millisecond)).NextDouble() * 100;
        }
    }
}
