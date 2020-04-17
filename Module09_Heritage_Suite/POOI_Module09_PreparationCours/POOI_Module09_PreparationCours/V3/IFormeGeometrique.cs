using System;

namespace POOI_Module09_PreparationCours.V3
{
    public interface IFormeGeometrique
    {
        public abstract void Dessiner();

        public double CalculerAire();
    }
}