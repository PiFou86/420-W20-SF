using POOI_Heritage_CompteBancaireSansAbstraction.Transactions;
using System;
using System.Collections.Generic;

namespace POOI_Heritage_CompteBancaireSansAbstraction.Comptes;

public class CompteAInteret : CompteBancaire
{
    public const decimal FRAIS_TRANSACTION = 0.25m;
    public override string Description { get; } = "Compte à intérêt";

    public CompteAInteret()
    {

    }

    public CompteAInteret(decimal p_solde) : base(p_solde)
    {
        ;
    }

    protected override List<Transaction> PreparerDepot(decimal p_montant)
    {
        List<Transaction> listeTx = base.PreparerDepot(p_montant);
        listeTx.Add(new TransactionFrais(FRAIS_TRANSACTION));

        this.ValiderTransactions(listeTx);

        return listeTx;
    }

    protected override List<Transaction> PreparerRetrait(decimal p_montant)
    {
        List<Transaction> listeTx = base.PreparerRetrait(p_montant);
        listeTx.Add(new TransactionFrais(FRAIS_TRANSACTION));

        this.ValiderTransactions(listeTx);

        return listeTx;
    }

    private void ValiderTransactions(List<Transaction> p_listeTx)
    {
        decimal soldeSimule = this.SimulerTransaction(p_listeTx);

        if (soldeSimule < 0)
        {
            throw new InvalidOperationException("Impossible d'effectuer cette transaction car le montant ne peut être négatif");
        }
    }
}
