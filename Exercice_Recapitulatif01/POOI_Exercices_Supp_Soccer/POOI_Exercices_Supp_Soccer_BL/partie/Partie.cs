using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Exercices_Supp_Soccer_BL.partie
{
    public class Partie
    {
        public Equipe Receveur { get; }
        public Equipe Invite { get; }
        public bool EstPartieJouee { get; private set; }
        public int ScoreReceveur { get; private set; }
        public int ScoreInvite { get; private set; }
        public DateTime DateDebutPartie { get; }

        public Partie(Equipe p_receveur, Equipe p_invite, DateTime p_dateDebutPartie)
        {
            if (p_receveur == null || p_invite == null || p_dateDebutPartie == null)
            {
                throw new ArgumentNullException();
            }

            this.Receveur = p_receveur;
            this.Invite = p_invite;
            this.DateDebutPartie = p_dateDebutPartie;

            this.EstPartieJouee = false;
        }

        public void DefinirScore(int p_scoreReceveur, int p_scoreInvite)
        {
            if (this.EstPartieJouee)
            {
                throw new InvalidOperationException();
            }

            this.ScoreReceveur = p_scoreReceveur;
            this.ScoreInvite = p_scoreInvite;

            this.EstPartieJouee = true;
        }
    }
}
