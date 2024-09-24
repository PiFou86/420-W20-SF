using System.Text;

namespace Module05_Redefinition_Surcharge;

public class VoitureTestsToString
{
    public string Couleur { get; set; }
    public int NombrePortes { get; set; }
    public double Vitesse { get; set; }

    public string ToString2()
    {
        return $"Voiture(couleur: {this.Couleur}, nombrePortes: {this.NombrePortes}, vitesse: {this.Vitesse}";
    }

    public string ToString3()
    {
        return "Voiture(couleur: " + this.Couleur.ToString()
            + ", nombrePortes: " + this.NombrePortes.ToString()
            + ", vitesse: " + this.Vitesse.ToString();
    }

    public string ToString4()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Voiture(couleur: ");
        sb.Append(this.Couleur);
        sb.Append(", nombrePortes: ");
        sb.Append(this.NombrePortes);
        sb.Append(", vitesse: ");
        sb.Append(this.Vitesse);
        sb.Append(")");

        string tmp = sb.ToString();
        sb.Clear();

        return tmp;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Voiture(couleur: ");
        sb.Append(this.Couleur);
        sb.Append(", nombrePortes: ");
        sb.Append(this.NombrePortes);
        sb.Append(", vitesse: ");
        sb.Append(this.Vitesse);
        sb.Append(")");

        string tmp = sb.ToString();
        sb.Clear();

        return tmp;
    }
}
