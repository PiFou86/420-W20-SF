using System;

namespace POOI_Module09_PreparationCours.V1;

public class Carre : FormeGeometrique
{
    public Point2D PointDepart { get; set; }
    public double LongueurCote { get; set; }

    public override void Dessiner()
    {
        Console.Out.WriteLine($"Carre(PointDepart: {this.PointDepart}, LongueurCote: {this.LongueurCote})");
    }

    public override double CalculerAire()
    {
        return Math.Pow(this.LongueurCote, 2);
    }


}
