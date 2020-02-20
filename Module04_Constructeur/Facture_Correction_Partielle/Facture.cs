using System;
using System.Collections.Generic;

namespace Facture_Correction_Partielle
{
public class Facture
    {
        private List<LigneFacture> m_lignesFacture;

        public int NombreArticles
        {
            get
            {
                int nombreArticles = 0;

                foreach (LigneFacture lf in this.m_lignesFacture)
                {
                    nombreArticles += lf.Quantite;
                }

                return nombreArticles;
            }
        }

        public decimal TotalHorsTaxes
        {
            get
            {
                decimal totalHorsTaxes = 0;

                foreach (LigneFacture lf in this.m_lignesFacture)
                {
                    totalHorsTaxes += lf.TotalHorsTaxes;
                }

                return totalHorsTaxes;
            }
        }

        public decimal MontantTaxes
        {
            get
            {
                decimal montantTaxes = 0;

                foreach (LigneFacture lf in this.m_lignesFacture)
                {
                    montantTaxes += lf.MontantTaxes;
                }

                return montantTaxes;
            }
        }

        public decimal TotalTaxesIncluses
        {
            get
            {
                return this.TotalHorsTaxes + this.MontantTaxes;
            }
        }

        public Facture()
        {
            this.m_lignesFacture = new List<LigneFacture>();
        }

        public void AjouterArticle(Article p_article, int p_quantite)
        {
            if (p_article == null)
            {
                throw new ArgumentNullException(nameof(p_article));
            }

            if (p_quantite < 0)
            {
                throw new ArgumentOutOfRangeException("La quantité ne doit pas être négative", nameof(p_quantite));
            }

            LigneFacture ligneFactureArticle = ChercherLigneFacture(p_article.Identifiant);

            if (ligneFactureArticle == null)
            {
                ligneFactureArticle = new LigneFacture(p_article, 0);
                this.m_lignesFacture.Add(ligneFactureArticle);
            }

            ligneFactureArticle.AjouterArticle(p_quantite);
        }

        public LigneFacture ChercherLigneFacture(string p_identifiantArticle)
        {
            if (p_identifiantArticle == null)
            {
                throw new ArgumentNullException(nameof(p_identifiantArticle));
            }

            LigneFacture ligneFacture = null;

            LigneFacture ligneFactureCourante = null;
            for (int numeroLigneFacture = 0; ligneFacture == null && numeroLigneFacture < this.m_lignesFacture.Count; numeroLigneFacture++)
            {
                ligneFactureCourante = this.m_lignesFacture[numeroLigneFacture];
                if (ligneFactureCourante.Article.Identifiant.Equals(p_identifiantArticle))
                {
                    ligneFacture = ligneFactureCourante;
                }
            }

            return ligneFacture;
        }

        public string RenvoyerChaine()
        {
            string res = "";
            foreach (LigneFacture ligneFacture in this.m_lignesFacture)
            {
                res += ligneFacture.RenvoyerChaine() + Environment.NewLine;
            }

            return res;
        }
    }
}