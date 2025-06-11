using System;

namespace Facture_Correction_Partielle;

public class LigneFacture
{
    private int m_quantite;
    private Article m_article;
    public decimal TotalHorsTaxes
    {
        get
        {
            return this.m_quantite * this.m_article.PrixUnitaire;
        }
    }

    public int Quantite
    {
        get
        {
            return this.m_quantite;
        }
    }

    public decimal MontantTaxes
    {
        get
        {
            return this.TotalHorsTaxes * this.m_article.TauxTaxes;
        }
    }

    public Article Article
    {
        get
        {
            return this.m_article;
        }
    }

    public LigneFacture(Article p_article, int p_quantite)
    {
        if (p_article == null)
        {
            throw new ArgumentNullException(nameof(p_article));
        }

        if (p_quantite < 0)
        {
            throw new ArgumentOutOfRangeException("La quantité ne doit pas être négative", nameof(p_quantite));
        }

        this.m_article = p_article;
        this.m_quantite = p_quantite;
    }

    public void AjouterArticle(int p_quantite)
    {
        if (p_quantite <= 0)
        {
            throw new ArgumentOutOfRangeException("La quantité doit être positif et non nulle", nameof(p_quantite));
        }
        this.m_quantite += p_quantite;
    }

    public string RenvoyerChaine()
    {
        return $"LigneFacture({this.Article.RenvoyerChaine()}, {this.m_quantite})";
    }
}
