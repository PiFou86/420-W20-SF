using POOI_Exercices_Supp_Soccer_BL.joueur;
using POOI_Exercices_Supp_Soccer_BL.personneldequipe;
using System;
using System.Collections.Generic;

namespace POOI_Exercices_Supp_Soccer_BL;

public class Equipe
{
    public int NumeroEquipe { get; private set; }
    public string NomEquipe { get; private set; }
    private List<Joueur> m_joueurs;
    private List<PersonnelDEquipe> m_personnelDEquipe;

    public Equipe(int p_numeroEquipe, string p_nomEquipe)
    {
        this.NumeroEquipe = p_numeroEquipe;
        this.NomEquipe = p_nomEquipe;
        this.m_joueurs = new List<Joueur>();
        this.m_personnelDEquipe = new List<PersonnelDEquipe>();
    }

    public void AjouterJoueurs(List<Joueur> p_joueurs)
    {
        if (p_joueurs != null)
        {
            p_joueurs.ForEach(p_joueur => this.AjouterJoueur(p_joueur));
        }
    }

    public void AjouterJoueur(Joueur p_joueur)
    {
        if (p_joueur == null)
        {
            throw new ArgumentNullException();
        }

        this.m_joueurs.Add(p_joueur);
    }

    public void AjouterPersonnelDEquipe(List<PersonnelDEquipe> p_personnesDEquipe)
    {
        if (p_personnesDEquipe != null)
        {
            p_personnesDEquipe.ForEach((p_personneDEquipe) => this.AjouterPersonnelDEquipe(p_personneDEquipe));
        }
    }

    public void AjouterPersonnelDEquipe(PersonnelDEquipe p_personneDEquipe)
    {
        if (p_personneDEquipe == null)
        {
            throw new ArgumentNullException();
        }

        this.m_personnelDEquipe.Add(p_personneDEquipe);
    }
}
