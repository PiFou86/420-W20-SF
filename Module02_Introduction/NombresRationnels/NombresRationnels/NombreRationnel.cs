using System;

namespace NombresRationnels
{
    public class NombreRationnel
    {
        public int Numerateur { get; set; }
        public int Denominateur { get; set; }

        public NombreRationnel(int p_numerateur, int p_denominateur)
        {
            if (p_denominateur == 0)
            {
                throw new ArgumentException("Le dénominateur ne peut pas être égal à 0", "p_denominateur");
            }

            if (p_denominateur < 0)
            {
                p_numerateur *= -1;
                p_denominateur *= -1;
            }
            this.Numerateur = p_numerateur;
            this.Denominateur = p_denominateur;
        }

        public static NombreRationnel operator +(NombreRationnel p_valeur1, NombreRationnel p_valeur2)
        {
            return Simplifier(new NombreRationnel(
                p_valeur1.Numerateur * p_valeur2.Denominateur + p_valeur2.Numerateur * p_valeur1.Denominateur,
                p_valeur1.Denominateur * p_valeur2.Denominateur
            ));
        }

        public static bool operator <(NombreRationnel p_operande1, NombreRationnel p_operande2)
        {
            int numerateur1 = p_operande1.Numerateur * p_operande2.Denominateur;
            int numerateur2 = p_operande2.Numerateur * p_operande1.Denominateur;

            return numerateur1 < numerateur2;
        }
        
        public static bool operator <=(NombreRationnel p_operande1, NombreRationnel p_operande2)
        {
            int numerateur1 = p_operande1.Numerateur * p_operande2.Denominateur;
            int numerateur2 = p_operande2.Numerateur * p_operande1.Denominateur;

            return p_operande1.Equals(p_operande2) || numerateur1 < numerateur2;
        }

        public static bool operator >(NombreRationnel p_operande1, NombreRationnel p_operande2)
        {
            int numerateur1 = p_operande1.Numerateur * p_operande2.Denominateur;
            int numerateur2 = p_operande2.Numerateur * p_operande1.Denominateur;

            return numerateur1 > numerateur2;
        }

        public static bool operator >=(NombreRationnel p_operande1, NombreRationnel p_operande2)
        {
            int numerateur1 = p_operande1.Numerateur * p_operande2.Denominateur;
            int numerateur2 = p_operande2.Numerateur * p_operande1.Denominateur;

            return p_operande1.Equals(p_operande2) || numerateur1 > numerateur2;
        }

        public static NombreRationnel operator -(NombreRationnel p_valeur1)
        {
            return Simplifier(new NombreRationnel(
                -p_valeur1.Numerateur,
                p_valeur1.Denominateur
            ));
        }

        public static NombreRationnel operator -(NombreRationnel p_valeur1, NombreRationnel p_valeur2)
        {
            return p_valeur1 + -p_valeur2;
        }

        public static NombreRationnel operator *(NombreRationnel p_valeur1, NombreRationnel p_valeur2)
        {
            return Simplifier(new NombreRationnel(
                p_valeur1.Numerateur * p_valeur2.Numerateur,
                p_valeur1.Denominateur * p_valeur2.Denominateur
            ));
        }
        public static NombreRationnel operator /(NombreRationnel p_valeur1, NombreRationnel p_valeur2)
        {
            return Simplifier(new NombreRationnel(
                p_valeur1.Numerateur * p_valeur2.Denominateur,
                p_valeur1.Denominateur * p_valeur2.Numerateur
            ));
        }

        public static NombreRationnel Simplifier(NombreRationnel p_valeur)
        {
            NombreRationnel resultat = null;
            if (p_valeur.Numerateur == 0)
            {
                resultat = new NombreRationnel(0, 1);
            }
            else
            {
                int pgcd = PGCD(Math.Abs(p_valeur.Numerateur), Math.Abs(p_valeur.Denominateur));
                resultat = new NombreRationnel(p_valeur.Numerateur / pgcd, p_valeur.Denominateur / pgcd);
            }

            return resultat;
        }

        public override string ToString()
        {
            string resultat = null;

            if (this.Denominateur == 1)
            {
                resultat = $"{this.Numerateur}";
            }
            else
            {
                resultat = $"{this.Numerateur} / {this.Denominateur}";
            }

            return resultat;
        }

        public override bool Equals(object p_obj)
        {
            bool resultat = false;
            NombreRationnel nr = p_obj as NombreRationnel;

            if (nr != null)
            {
                resultat = this.Numerateur == nr.Numerateur && this.Denominateur == nr.Denominateur;
            }

            return resultat;
        }

        public static int PGCD(int p_valeur1, int p_valeur2)
        {
            if (p_valeur1 < 0)
            {
                throw new ArgumentException("La valeur doit être positive !", "p_valeur1");
            }
            if (p_valeur2 < 0)
            {
                throw new ArgumentException("La valeur doit être positive !", "p_valeur2");
            }

            while (p_valeur1 != p_valeur2)
            {
                if (p_valeur1 > p_valeur2)
                {
                    p_valeur1 -= p_valeur2;
                }
                else
                {
                    p_valeur2 -= p_valeur1;
                }
            }

            return p_valeur1;
        }
    }
}
