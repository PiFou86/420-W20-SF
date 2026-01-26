public class SalutationAmicale : ISaluer
{
    public void DireBonjour(string p_nom)
    {
        Console.Out.WriteLine($"Salut, {p_nom}! Content de te voir! Viens-tu prendre une bonne chocolatine avec moi ?");
    }
}