using POOI_Module11_JeuTir.Sons;

namespace POOI_Module11_JeuTir.Armes
{
    public class Stylo : Arme
    {
        public Stylo() : base(new Son() { TexteDuSon = "Tuctuctuctuc" }, new Son() { TexteDuSon = "Crounch" })
        {
            ;
        }

        protected override double CalculerDegat()
        {
            return 1.0;
        }
    }
}
