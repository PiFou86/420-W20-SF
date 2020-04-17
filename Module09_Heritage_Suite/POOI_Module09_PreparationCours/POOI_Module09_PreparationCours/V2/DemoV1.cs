using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Module09_PreparationCours.V2
{
    public class DemoV2
    {
        public static void Demo01()
        {
            // Erreur
            // FormeGeometrique formeGeometrique1 = new FormeGeometrique();

            FormeGeometrique fg1 = new Carre()
            {
                PointDepart = new Point2D { X = 1, Y = 2 },
                LongueurCote = 3.5
            };
            FormeGeometrique fg2 = new Cercle()
            {
                Centre = new Point2D { X = 13, Y = 42 },
                Rayon = 1
            };
            FormeGeometrique fg3 = new Rectangle()
            {
                PointDepart = new Point2D() { X = 23, Y = 7 },
                Hauteur = 3,
                Largueur = 4
            };
            List<FormeGeometrique> fgs = new List<FormeGeometrique>() {
                fg1,
                fg2,
                fg3
            };
            foreach (FormeGeometrique formeGeometrique in fgs)
            {
                formeGeometrique.Dessiner();
                Console.Out.WriteLine($"\tAire : {formeGeometrique.CalculerAire()}");
            }
        }
    }
}
