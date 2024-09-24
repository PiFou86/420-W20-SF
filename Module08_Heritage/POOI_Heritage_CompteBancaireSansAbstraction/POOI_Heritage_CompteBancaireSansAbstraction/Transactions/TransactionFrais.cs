namespace POOI_Heritage_CompteBancaireSansAbstraction.Transactions;

public class TransactionFrais : Transaction
{
    public TransactionFrais(decimal p_montant) : base(TypeTransaction.DEBIT, p_montant, "Frais de transaction")
    {
        ;
    }
}
