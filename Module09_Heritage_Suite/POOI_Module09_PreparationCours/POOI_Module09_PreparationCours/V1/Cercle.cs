using System;

namespace POOI_Module09_PreparationCours.V1;

public class Cercle : FormeGeometrique
{
    public Point2D Centre { get; set; }
    public double Rayon { get; set; }

    public override void Dessiner()
    {
        Console.Out.WriteLine($"Cercle(PointDepart: {this.Centre}, Rayon: {this.Rayon})");
    }

    public override double CalculerAire()
    {
        return Math.PI * Math.Pow(this.Rayon, 2);
    }
}
