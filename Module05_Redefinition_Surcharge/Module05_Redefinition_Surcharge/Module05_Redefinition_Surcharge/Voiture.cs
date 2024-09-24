using System;

namespace Module05_Redefinition_Surcharge;

public class Voiture
{
    public string Couleur { get; set; }
    public int NombrePortes { get; set; }
    public double Vitesse { get; set; }

    public override bool Equals(object p_obj)
    {
        bool egaux = false;
        Voiture conversionVoiture = p_obj as Voiture;
        if (conversionVoiture != null)
        {
            egaux =
                    this.Couleur.CompareTo(conversionVoiture.Couleur) == 0
                && this.NombrePortes == conversionVoiture.NombrePortes
                && this.Vitesse == conversionVoiture.Vitesse;
        }
        return egaux;
    }

    public override string ToString()
    {
        return $"Voiture(couleur: {this.Couleur}, nombrePortes: {this.NombrePortes}, vitesse: {this.Vitesse}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Couleur, NombrePortes, Vitesse);
    }

    public static bool operator ==(Voiture p_gauche, Voiture p_droit)
    {
        return object.ReferenceEquals(p_gauche, p_droit)
            || (
                    !object.ReferenceEquals(p_gauche, null)
                && !object.ReferenceEquals(p_droit, null)
                && p_gauche.Equals(p_droit)
                );
    }

    public static bool operator !=(Voiture p_gauche, Voiture p_droit)
    {
        return !(p_gauche == p_droit);
    }
}
