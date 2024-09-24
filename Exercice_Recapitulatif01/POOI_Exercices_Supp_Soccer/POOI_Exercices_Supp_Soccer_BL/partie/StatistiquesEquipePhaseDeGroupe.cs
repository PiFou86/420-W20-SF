using System.Text;

namespace POOI_Exercices_Supp_Soccer_BL.partie;

public class StatistiquesEquipePhaseDeGroupe
{
    public int NumeroEquipe { get; set; }
    public int PartiesJouees { get; set; }
    public int PartiesGagnees { get; set; }
    public int PartiesNulles { get; set; }
    public int PartiesPerdues { get; set; }
    public int ButsPour { get; set; }
    public int ButsContre { get; set; }
    public int Points { get; set; }
    public string NomEqupe { get; set; }

    public StatistiquesEquipePhaseDeGroupe(int p_numeroEquipe, string p_nomEquipe)
    {
        this.NumeroEquipe = p_numeroEquipe;
        this.NomEqupe = p_nomEquipe;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(this.Points);
        sb.Append('\t');
        sb.Append(this.PartiesJouees);
        sb.Append('\t');
        sb.Append(this.PartiesGagnees);
        sb.Append('\t');
        sb.Append(this.PartiesNulles);
        sb.Append('\t');
        sb.Append(this.PartiesPerdues);
        sb.Append('\t');
        sb.Append(this.ButsPour);
        sb.Append('\t');
        sb.Append(this.ButsContre);

        return sb.ToString();
    }
}
