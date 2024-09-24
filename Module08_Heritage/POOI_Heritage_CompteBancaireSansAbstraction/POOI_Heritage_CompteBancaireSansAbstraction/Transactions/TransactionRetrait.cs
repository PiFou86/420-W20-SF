namespace POOI_Heritage_CompteBancaireSansAbstraction.Transactions;

internal class TransactionRetrait : Transaction
{
    public TransactionRetrait(decimal p_montant) : base(TypeTransaction.DEBIT, p_montant, "Retrait d'un montant sur le compte")
    {
        ;
    }
}
