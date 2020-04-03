namespace POOI_Heritage_CompteBancaireSansAbstraction.Transactions
{
    public class TransactionDepot : Transaction
    {
        public TransactionDepot(decimal p_montant) : base(TypeTransaction.CREDIT, p_montant, "Dépot d'un montant sur le compte")
        {
            ;
        }
    }
}