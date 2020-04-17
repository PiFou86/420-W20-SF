using System;

namespace POOI_Module08_Heritage
{
    public class Animal
    {
        private double m_energieAccumulee;
        public DateTime DateNaissance { get; private set; }
        public double Masse { get; private set; }

        public Animal(DateTime p_dateNaissance, double p_masse, double p_energie)
        {
            this.DateNaissance = p_dateNaissance;
            this.Masse = p_masse;
            this.m_energieAccumulee = p_energie;
        }

        public void GagnerEnergie(double p_energieGagneeKCalorie)
        {
            if (p_energieGagneeKCalorie <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_energieGagneeKCalorie));
            }

            this.m_energieAccumulee += p_energieGagneeKCalorie;
        }


        public void DepenserEnergie(double p_energieDepenseeKCalorie)
        {
            if (p_energieDepenseeKCalorie <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_energieDepenseeKCalorie));
            }

            this.m_energieAccumulee -= p_energieDepenseeKCalorie;
        }

        public virtual void EmettreUnSon()
        {
            // Nous verrons d'autres modifieurs pour éviter ce code
            ;
        }
    }
}
