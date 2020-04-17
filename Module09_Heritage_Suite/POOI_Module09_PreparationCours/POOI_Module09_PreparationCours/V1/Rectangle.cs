using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Module09_PreparationCours.V1
{
    public class Rectangle : FormeGeometrique
    {
        public Point2D PointDepart { get; set; }
        public double Hauteur { get; set; }
        public double Largueur { get; set; }

        public override void Dessiner()
        {
            Console.Out.WriteLine($"Rectangle(PointDepart: {this.PointDepart}, Hauteur: {this.Hauteur}, Largeur: {this.Largueur})");
        }

        public override double CalculerAire()
        {
            return this.Hauteur * this.Largueur;
        }
    }
}
