using System;

namespace POOI_Exercices_Supp_Soccer_BL
{
    public class Individu
    {
        public string Nom { get; private set; }

        public Individu(string p_nom)
        {
            this.Nom = p_nom;
        }

        public override string ToString()
        {
            return this.GetType().Name + "(\"" + this.Nom + "\")";
        }
    }
}
