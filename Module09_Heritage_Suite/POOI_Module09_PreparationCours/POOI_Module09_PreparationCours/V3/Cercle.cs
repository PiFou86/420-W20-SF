using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Module09_PreparationCours.V3
{
    public class Cercle : IFormeGeometrique
    {
        public Point2D Centre { get; set; }
        public double Rayon { get; set; }

        public void Dessiner()
        {
            Console.Out.WriteLine($"Cercle(PointDepart: {this.Centre}, Rayon: {this.Rayon})");
        }

        public double CalculerAire()
        {
            return Math.PI * Math.Pow(this.Rayon, 2);
        }
    }
}
