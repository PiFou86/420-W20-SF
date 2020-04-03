using POOI_Heritage_CompteBancaireSansAbstraction.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Heritage_CompteBancaireSansAbstraction.Comptes
{
    public class CompteAvecMargeCredit : CompteBancaire
    {
        public override string Description { get; } = "Compte avec marge de crédit";

        public const decimal FRAIS_TRANSACTION = 0.25m;
        public const decimal TAUX_INTERET = 0.05m;
        private int m_nombreOperationNegatif;

        public CompteAvecMargeCredit()
        {
            ;
        }

        public CompteAvecMargeCredit(decimal p_solde) : base(p_solde)
        {
            this.m_nombreOperationNegatif = 0;
        }

        protected override List<Transaction> PreparerDepot(decimal p_montant)
        {
            List<Transaction> listeTx = base.PreparerDepot(p_montant);
            listeTx.Add(new TransactionFrais(FRAIS_TRANSACTION));

            return listeTx;
        }


        protected override List<Transaction> PreparerRetrait(decimal p_montant)
        {
            List<Transaction> listeTx = base.PreparerRetrait(p_montant);
            listeTx.Add(new TransactionFrais(FRAIS_TRANSACTION));

            return listeTx;
        }

        public override void Deposer(decimal p_montant)
        {
            base.Deposer(p_montant);

            this.AppliquerInteret();
        }

        public override void Retirer(decimal p_montant)
        {
            base.Retirer(p_montant);

            this.AppliquerInteret();
        }

        private void AppliquerInteret()
        {
            if (this.Solde >= 0)
            {
                this.m_nombreOperationNegatif = 0;
            }
            else
            {
                this.m_nombreOperationNegatif++;
            }

            if (this.m_nombreOperationNegatif == 10)
            {
                decimal interet = Math.Abs(this.Solde * TAUX_INTERET);
                this.AppliquerTransaction(new TransactionInteret(interet));

                this.m_nombreOperationNegatif = 0;
            }
        }

    }
}
