public class SalutationInformelle : ISaluer
{
    public void DireBonjour(string p_nom)
    {
        Console.Out.WriteLine($"Bonjour, {p_nom}. Ravi de faire ta connaissance.");
    }
}