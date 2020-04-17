using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Module09_PreparationCours.V3
{
    public class Carre : IFormeGeometrique
    {
        public Point2D PointDepart { get; set; }
        public double LongueurCote { get; set; }

        public void Dessiner()
        {
            Console.Out.WriteLine($"Carre(PointDepart: {this.PointDepart}, LongueurCote: {this.LongueurCote})");
        }

        public double CalculerAire()
        {
            return Math.Pow(this.LongueurCote, 2);
        }
    }
}
