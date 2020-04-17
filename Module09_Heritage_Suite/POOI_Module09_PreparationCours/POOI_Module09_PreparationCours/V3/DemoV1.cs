using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Module09_PreparationCours.V3
{
    public class DemoV2
    {
        public static void Demo01()
        {
            // Erreur
            // FormeGeometrique formeGeometrique1 = new FormeGeometrique();

            IFormeGeometrique fg1 = new Carre()
            {
                PointDepart = new Point2D { X = 1, Y = 2 },
                LongueurCote = 3.5
            };
            IFormeGeometrique fg2 = new Cercle()
            {
                Centre = new Point2D { X = 13, Y = 42 },
                Rayon = 1
            };
            IFormeGeometrique fg3 = new Rectangle()
            {
                PointDepart = new Point2D() { X = 23, Y = 7 },
                Hauteur = 3,
                Largueur = 4
            };
            List<IFormeGeometrique> fgs = new List<IFormeGeometrique>() {
                fg1,
                fg2,
                fg3
            };
            foreach (IFormeGeometrique formeGeometrique in fgs)
            {
                formeGeometrique.Dessiner();
                Console.Out.WriteLine($"\tAire : {formeGeometrique.CalculerAire()}");
            }
        }
    }
}
