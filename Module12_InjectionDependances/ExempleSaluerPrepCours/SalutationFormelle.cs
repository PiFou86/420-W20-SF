public class SalutationFormelle : ISaluer
{
    public void DireBonjour(string p_nom)
    {
        Console.Out.WriteLine($"Bonjour, Monsieur/Madame {p_nom}. Ravi de faire votre connaissance.");
    }
}