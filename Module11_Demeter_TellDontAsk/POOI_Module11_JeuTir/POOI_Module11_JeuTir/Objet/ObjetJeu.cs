using POOI_Module11_JeuTir.Geometrie;
using System;

namespace POOI_Module11_JeuTir.Objet;

public class ObjetJeu
{
    // ...
    public Point3D Position { get; set; }
    public Vecteur3D Direction { get; set; }

    public virtual void AppliquerDomage(double p_degat)
    {
        throw new NotImplementedException();
    }
}
