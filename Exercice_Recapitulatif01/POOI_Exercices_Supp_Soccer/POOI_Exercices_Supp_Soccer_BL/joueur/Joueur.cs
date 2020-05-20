using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Exercices_Supp_Soccer_BL.joueur
{
    public class Joueur : MembreEquipe
    {
		public Joueur(string p_nom, string p_numeroPassport) : base(p_nom, p_numeroPassport)
		{
			;
		}

		public string SuivreEntrainement()
		{
			return this.ToString() + " : s'entraine à faire de la conduite de balles, des feintes, des amortis, des passes et des tirs.";
		}
	}
}
