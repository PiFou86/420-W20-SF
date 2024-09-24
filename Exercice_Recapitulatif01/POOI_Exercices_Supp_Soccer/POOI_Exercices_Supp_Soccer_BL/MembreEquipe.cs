namespace POOI_Exercices_Supp_Soccer_BL;

public class MembreEquipe : Individu
{
    public string NumeroPasseport { get; }

    public MembreEquipe(string p_nom, string p_numeroPasseport) : base(p_nom)
    {
        this.NumeroPasseport = p_numeroPasseport;
    }

    public override string ToString()
    {
        return this.GetType().Name + "(\"" + this.Nom + "\", \"" + this.NumeroPasseport + "\")";
    }
}
