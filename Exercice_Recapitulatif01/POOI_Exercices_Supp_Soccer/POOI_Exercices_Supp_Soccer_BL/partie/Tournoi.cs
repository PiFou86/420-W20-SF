using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOI_Exercices_Supp_Soccer_BL.partie;

public class Tournoi
{
    private List<Partie> m_parties;
    private List<StatistiquesEquipePhaseDeGroupe> m_statistiquesPhaseDeGroupe;

    public Tournoi()
    {
        this.m_parties = new List<Partie>();
        this.m_statistiquesPhaseDeGroupe = new List<StatistiquesEquipePhaseDeGroupe>();
    }

    /**
		 * Ajouter une partie au tournoi et ajoute les statistiques de l'équipe si elles n'existent pas
		 * @param p_receveur
		 * @param p_invite
		 * @param p_dateDebutPartie
		 * @return
		 */
    public Partie AjouterPartie(Equipe p_receveur, Equipe p_invite, DateTime p_dateDebutPartie)
    {
        if (p_receveur == null || p_invite == null)
        {
            throw new InvalidOperationException();
        }

        Partie partie = new Partie(p_receveur, p_invite, p_dateDebutPartie);
        this.m_parties.Add(partie);

        this.AjouterStatistiquesEquipeSiNonExistantes(p_receveur);
        this.AjouterStatistiquesEquipeSiNonExistantes(p_invite);

        return partie;
    }

    private void AjouterStatistiquesEquipeSiNonExistantes(Equipe p_equipe)
    {
        StatistiquesEquipePhaseDeGroupe sepdg = RechercherStatistiquesEquipe(p_equipe);

        if (sepdg == null)
        {
            sepdg = new StatistiquesEquipePhaseDeGroupe(p_equipe.NumeroEquipe, p_equipe.NomEquipe);

            this.m_statistiquesPhaseDeGroupe.Add(sepdg);
        }
    }

    /**
		 * Permet de rechercher la ligne de statistiques associée à une équipe
		 *
		 * @param p_equipe
		 * @return La ligne de statistiques
		 */
    public StatistiquesEquipePhaseDeGroupe RechercherStatistiquesEquipe(Equipe p_equipe)
    {
        return this.m_statistiquesPhaseDeGroupe
            .Where(stat => stat.NumeroEquipe == p_equipe.NumeroEquipe)
            .SingleOrDefault();
    }

    /**
		 * Permet d'affecter le score à une partie et à mettre à jour les statistiques
		 *
		 * @param p_partie
		 * @param p_scoreReceveur
		 * @param p_scoreInvite
		 * @throws ScoreDejaDefiniException
		 */
    public void AffecterScorePartieEtMAJStatistiques(Partie p_partie, int p_scoreReceveur, int p_scoreInvite)
    {
        if (p_scoreReceveur < 0 || p_scoreInvite < 0)
        {
            throw new InvalidOperationException();
        }

        p_partie.DefinirScore(p_scoreReceveur, p_scoreInvite);

        this.ModifierStatistiques(p_partie.Receveur, p_scoreReceveur, p_scoreInvite);
        this.ModifierStatistiques(p_partie.Invite, p_scoreInvite, p_scoreReceveur);
    }

    // Victoire 3 points
    // Nulle 1 points
    // Défaite 0 point
    private void ModifierStatistiques(Equipe p_equipe, int p_scoreEquipe, int p_scoreAutreEquipe)
    {
        AjouterStatistiquesEquipeSiNonExistantes(p_equipe);

        StatistiquesEquipePhaseDeGroupe statistiquesEquipePhaseDeGroupe = RechercherStatistiquesEquipe(p_equipe);
        // À coder


    }

    /**
     * Stats
     * Pts : points
     * PJ : parties jouées
     * PG : parties gagnées
     * PN : parties nulles
     * PP : parties perdues
     * BP : buts pour
     * BC : buts contre
     */
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Liste des équipes et pointage");
        sb.Append('\n');
        sb.Append("Équipe\t\tPts\tPJ\tPG\tPN\tPP\tBP\tBC");
        sb.Append('\n');

        this.m_statistiquesPhaseDeGroupe
            .OrderByDescending(stats => stats.Points)
            .ToList()
            .ForEach((stats) =>
            {
                sb.Append(stats.NomEqupe.PadRight(15));
                sb.Append(stats.ToString());
                sb.Append('\n');
            });

        return sb.ToString();
    }
}
