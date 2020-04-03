namespace POOI_Heritage_CompteBancaireSansAbstraction.Transactions
{
    public class TransactionInteret : Transaction
    {
        public TransactionInteret(decimal p_montant) : base(TypeTransaction.DEBIT, p_montant, "Application d'un intérêt")
        {
            ;
        }
    }
}