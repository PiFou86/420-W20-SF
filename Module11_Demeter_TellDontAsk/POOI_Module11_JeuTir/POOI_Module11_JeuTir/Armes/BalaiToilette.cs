using System;

namespace POOI_Module11_JeuTir.Armes
{
    public class BalaiToilette : Arme
    {
        protected override double CalculerDegat()
        {
            return (new Random(DateTime.Now.Millisecond)).NextDouble() * 40 + 10;
        }
    }
}
