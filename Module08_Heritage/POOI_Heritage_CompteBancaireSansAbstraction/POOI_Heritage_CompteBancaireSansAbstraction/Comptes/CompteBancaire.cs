using System;
using System.Collections.Generic;
using System.Text;

using POOI_Heritage_CompteBancaireSansAbstraction.Transactions;
using POOI_Heritage_CompteBancaireSansAbstraction.Utils;

namespace POOI_Heritage_CompteBancaireSansAbstraction.Comptes;

public class CompteBancaire
{
    public decimal Solde { get; private set; }
    public virtual string Description { get; } = "Compte général";

    private readonly List<ExecutionTransaction> m_historiqueTransactions;

    public CompteBancaire() : this(0)
    {
        ;
    }

    public CompteBancaire(decimal p_solde)
    {
        this.m_historiqueTransactions = new List<ExecutionTransaction>();
        if (p_solde != 0)
        {
            this.AppliquerTransaction(new TransactionDepot(p_solde));
        }
    }

    public virtual void Retirer(decimal p_montant)
    {
        List<Transaction> listeTransactions = this.PreparerRetrait(p_montant);

        this.AppliquerTransaction(listeTransactions);
    }

    public virtual void Deposer(decimal p_montant)
    {
        List<Transaction> listeTransactions = this.PreparerDepot(p_montant);

        this.AppliquerTransaction(listeTransactions);
    }

    protected virtual List<Transaction> PreparerRetrait(decimal p_montant)
    {
        List<Transaction> listeTransactions = new List<Transaction>();
        listeTransactions.Add(new TransactionRetrait(p_montant));

        return listeTransactions;
    }

    protected virtual List<Transaction> PreparerDepot(decimal p_montant)
    {
        List<Transaction> listeTransactions = new List<Transaction>();
        listeTransactions.Add(new TransactionDepot(p_montant));

        return listeTransactions;
    }

    protected decimal SimulerTransaction(Transaction p_tx, decimal p_solde)
    {
        decimal nouveauSolde = p_solde;
        switch (p_tx.Type)
        {
            case TypeTransaction.DEBIT:
                nouveauSolde -= p_tx.Montant;
                break;
            case TypeTransaction.CREDIT:
                nouveauSolde += p_tx.Montant;
                break;
        }

        return nouveauSolde;
    }

    protected decimal SimulerTransaction(List<Transaction> p_listeTx)
    {
        decimal solde = this.Solde;

        foreach (Transaction tx in p_listeTx)
        {
            solde = this.SimulerTransaction(tx, solde);
        }

        return solde;
    }

    protected void AppliquerTransaction(Transaction p_tx)
    {
        this.Solde = this.SimulerTransaction(p_tx, this.Solde);
        this.m_historiqueTransactions.Add(new ExecutionTransaction(p_tx, this.Solde));
    }

    protected void AppliquerTransaction(List<Transaction> p_listeTx)
    {
        foreach (Transaction tx in p_listeTx)
        {
            this.AppliquerTransaction(tx);
        }
    }

    public void AfficherHistoriqueCompte()
    {
        Console.Out.WriteLine(this.ToString());
    }

    public const int LARGEUR_NUMERO_LIGNE = 5;
    public static string LigneIntersectionTransaction { get; } =
"+-" + "".PadLeft(LARGEUR_NUMERO_LIGNE + 1, '-') + ExecutionTransaction.LigneIntersectionTransaction;
    public static string EnteteTransaction { get; } =
"| " + "Ligne".PadBoth(LARGEUR_NUMERO_LIGNE).Substring(0, LARGEUR_NUMERO_LIGNE) + " " + ExecutionTransaction.EnteteTransaction;

    public sealed override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(this.Description);
        sb.AppendLine();

        sb.AppendLine(LigneIntersectionTransaction);
        sb.AppendLine(EnteteTransaction);
        sb.AppendLine(LigneIntersectionTransaction);

        int line = 1;
        foreach (ExecutionTransaction et in this.m_historiqueTransactions)
        {
            sb.Append("| " + line.ToString().PadLeft(LARGEUR_NUMERO_LIGNE).Substring(0, LARGEUR_NUMERO_LIGNE) + " ");
            sb.AppendLine(et.ToString());

            ++line;
        }
        sb.AppendLine(LigneIntersectionTransaction);

        return sb.ToString();
    }
}
