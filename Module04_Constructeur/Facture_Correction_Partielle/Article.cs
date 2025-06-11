using System;

namespace Facture_Correction_Partielle;

public class Article
{
    private string m_identifiant;
    private string m_nom;
    private decimal m_prixUnitaire;
    private decimal m_tauxTaxes;

    public string Identifiant
    {
        get
        {
            return this.m_identifiant;
        }
    }

    public decimal PrixUnitaire
    {
        get
        { return this.m_prixUnitaire; }
    }

    public decimal TauxTaxes
    {
        get
        {
            return this.m_tauxTaxes;
        }
    }

    public Article(string p_identifiant, string p_nom, decimal p_prixUnitaire, decimal p_tauxTaxes)
    {
        if (string.IsNullOrWhiteSpace(p_identifiant))
        {
            throw new ArgumentException("L'identifiant ne doit pas être vide ou null", nameof(p_identifiant));
        }
        if (string.IsNullOrWhiteSpace(p_nom))
        {
            throw new ArgumentException("Le nom ne doit pas être vide ou null", nameof(p_nom));
        }
        if (p_prixUnitaire < 0m)
        {
            throw new ArgumentException("Le prix unitaire ne doit pas être négatif", nameof(p_prixUnitaire));
        }
        if (p_tauxTaxes < 0m || p_tauxTaxes > 1m)
        {
            throw new ArgumentException("Le taux de taxes doit être compris entre 0 et 1", nameof(p_tauxTaxes));
        }

        this.m_identifiant = p_identifiant;
        this.m_nom = p_nom;
        this.m_prixUnitaire = p_prixUnitaire;
        this.m_tauxTaxes = p_tauxTaxes;
    }

    public string RenvoyerChaine()
    {
        return $"Article(\"{this.m_identifiant}\"; \"{this.m_nom}\"; {this.PrixUnitaire.ToString("c")}; {(this.TauxTaxes * 100m).ToString("#.##")}%)";
    }
}
