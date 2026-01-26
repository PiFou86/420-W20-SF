using POOI_Heritage_CompteBancaireSansAbstraction.Transactions;
using POOI_Heritage_CompteBancaireSansAbstraction.Utils;

namespace POOI_Heritage_CompteBancaireSansAbstraction;

public class ExecutionTransaction
{
    public Transaction Transaction { get; private set; }
    public decimal Solde { get; private set; }

    public ExecutionTransaction(Transaction p_transaction, decimal p_solde)
    {
        this.Transaction = p_transaction;
        this.Solde = p_solde;
    }

    public const int LARGEUR_SOLDE = 20;

    public sealed override string ToString()
    {
        return this.Transaction.ToString() + this.Solde.ToString("C").PadLeft(LARGEUR_SOLDE).Substring(0, LARGEUR_SOLDE) + " | ";
    }

    public static string LigneIntersectionTransaction { get; } =
              Transaction.LigneIntersectionTransaction + "".PadLeft(LARGEUR_SOLDE + 1, '-') + "+";
    public static string EnteteTransaction { get; } =
              Transaction.EnteteTransaction + "Solde".PadBoth(LARGEUR_SOLDE).Substring(0, LARGEUR_SOLDE) + " |";

}
