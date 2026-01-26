using System;

namespace POOI_Module09_PreparationCours.V3;

public class Rectangle : IFormeGeometrique
{
    public Point2D PointDepart { get; set; }
    public double Hauteur { get; set; }
    public double Largueur { get; set; }

    public void Dessiner()
    {
        Console.Out.WriteLine($"Rectangle(PointDepart: {this.PointDepart}, Hauteur: {this.Hauteur}, Largeur: {this.Largueur})");
    }

    public double CalculerAire()
    {
        return this.Hauteur * this.Largueur;
    }
}
