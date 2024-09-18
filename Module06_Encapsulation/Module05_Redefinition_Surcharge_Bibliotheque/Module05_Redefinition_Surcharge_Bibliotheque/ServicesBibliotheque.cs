using System;
using System.Collections.Generic;

namespace Module05_Redefinition_Surcharge_Bibliotheque;

public class ServicesBibliotheque
{
    private List<Livre> m_livres;
    private List<Abonne> m_abonnes;

    public ServicesBibliotheque(List<Livre> p_livres, List<Abonne> p_abonnes)
    {
        this.m_livres = p_livres;
        this.m_abonnes = p_abonnes;
    }

    public List<Livre> RechercheLivreParISBN(string p_isbn)
    {
        List<Livre> livresTrouves = new List<Livre>();

        foreach (Livre livre in this.m_livres)
        {
            if (livre.ISBN == p_isbn)
            {
                livresTrouves.Add(livre);
            }
        }

        return livresTrouves;
    }

    public List<Livre> RechercherLivreParAuteur(string p_nomAuteur)
    {
        List<Livre> livresTrouves = new List<Livre>();

        foreach (Livre livre in this.m_livres)
        {
            foreach (string auteur in livre.Auteurs)
            {
                if (auteur.Contains(p_nomAuteur, StringComparison.InvariantCultureIgnoreCase))
                {
                    livresTrouves.Add(livre);
                }
            }
        }

        return livresTrouves;
    }

    public Livre RechercheLivreParIdentifiantInterne(string p_identifiantInterne)
    {
        Livre livreTrouve = null;

        for (int indiceLivre = 0;
             livreTrouve == null && indiceLivre < this.m_livres.Count;
             ++indiceLivre)
        {
            Livre livre = this.m_livres[indiceLivre];
            if (livre.IdentifiantInterne == p_identifiantInterne)
            {
                livreTrouve = livre;
            }
        }

        return livreTrouve;
    }

    public void EmprunterLivre(Livre p_livre, Abonne p_abonne)
    {
        if (p_livre == null)
        {
            throw new ArgumentNullException(nameof(p_livre));
        }
        if (p_abonne == null)
        {
            throw new ArgumentNullException(nameof(p_abonne));
        }
        if (!this.m_livres.Contains(p_livre))
        {
            throw new InvalidOperationException("Le livre n'existe pas !");
        }
        if (!this.m_abonnes.Contains(p_abonne))
        {
            throw new InvalidOperationException("L'abonné n'existe pas !");
        }
        if (!p_abonne.PeutEmprunter)
        {
            throw new InvalidOperationException("L'abonné ne peut pas emprunter de livres.");
        }
        if (!p_livre.EstDisponible)
        {
            throw new InvalidOperationException("Le livre n'est pas disponible.");
        }

        // Solution temporaire avant de voir comment inverser ou de compenser les actions en cas d'erreurs
        p_livre.Emprunter(p_abonne);
    }

    public void RendreLivre(Livre p_livre)
    {
        if (p_livre == null)
        {
            throw new ArgumentNullException(nameof(p_livre));
        }
        if (!this.m_livres.Contains(p_livre))
        {
            throw new InvalidOperationException("Le livre n'existe pas !");
        }
        if (p_livre.EstDisponible)
        {
            throw new InvalidOperationException("Le livre n'est pas emprunté.");
        }

        p_livre.Rendre();
    }
}
