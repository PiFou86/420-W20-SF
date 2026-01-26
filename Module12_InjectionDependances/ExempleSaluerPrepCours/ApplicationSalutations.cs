
public class ApplicationSalutations
{
    private readonly ISaluer m_saluer;

    public ApplicationSalutations(ISaluer p_strategieSalutation)
    {
        m_saluer = p_strategieSalutation;
    }

    public void Saluer(string p_nom)
    {
        m_saluer.DireBonjour(p_nom);
    }
}

