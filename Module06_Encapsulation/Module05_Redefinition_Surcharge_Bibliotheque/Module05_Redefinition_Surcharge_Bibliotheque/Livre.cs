using System;
using System.Collections.Generic;

namespace Module05_Redefinition_Surcharge_Bibliotheque;

public class Livre
{
    public string ISBN { get; private set; }
    public string Titre { get; private set; }
    public List<string> Auteurs { get; private set; }
    public string IdentifiantInterne { get; private set; }

    public Abonne Emprunteur { get; private set; }
    private int m_nombreRenouvellements;

    public DateTime? DateEmprunt { get; private set; }
    public DateTime? DateRetourSansPenalite
    {
        get
        {
            return this.DateEmprunt?.AddDays(ParametresBibliotheque.NOMBRE_JOURS_EMPRUNT * (this.m_nombreRenouvellements + 1));
        }
    }

    public int NombreJoursRetard
    {
        get
        {
            int nbJoursRetard = 0;
            DateTime? dateRetourSansPenalite = this.DateRetourSansPenalite;
            if (dateRetourSansPenalite.HasValue && dateRetourSansPenalite.Value < DateProduction.Now)
            {
                nbJoursRetard = (DateProduction.Now - dateRetourSansPenalite.Value).Days;
            }

            return nbJoursRetard;
        }
    }

    public bool EstDisponible
    {
        get
        {
            return this.Emprunteur == null;
        }
    }

    public Livre(string p_ISBN, string p_titre, List<string> p_auteurs, string p_identifiantInterne)
    {
        this.ISBN = p_ISBN;
        this.Titre = p_titre;
        this.Auteurs = p_auteurs;
        this.IdentifiantInterne = p_identifiantInterne;
        this.DateEmprunt = null;

        this.m_nombreRenouvellements = 0;
        this.Emprunteur = null;
    }

    public void Emprunter(Abonne p_abonne)
    {
        if (!this.EstDisponible)
        {
            throw new InvalidOperationException();
        }

        p_abonne.EmprunterLivre(this);

        this.Emprunteur = p_abonne;
        this.DateEmprunt = DateProduction.Now;
        this.m_nombreRenouvellements = 0;
    }

    public void Renouveller()
    {
        if (this.m_nombreRenouvellements >= ParametresBibliotheque.NOMBRE_MAXIMUM_RENOUVELLEMENT)
        {
            throw new InvalidOperationException();
        }
        if (this.EstDisponible)
        {
            throw new InvalidOperationException();
        }

        this.m_nombreRenouvellements += 1;
    }

    public void Rendre()
    {
        if (this.EstDisponible)
        {
            throw new InvalidOperationException();
        }

        this.Emprunteur.RendreLivre(this);
        this.Emprunteur = null;
        this.DateEmprunt = null;
        this.m_nombreRenouvellements = 0;
    }

}
