using POOI_Heritage_CompteBancaireSansAbstraction.Utils;
using System;

namespace POOI_Heritage_CompteBancaireSansAbstraction.Transactions;

public class Transaction
{

    public Transaction(TypeTransaction p_typeTransaction, decimal p_montant, string p_description)
    {
        if (p_montant < 0)
        {
            throw new ArgumentOutOfRangeException("Le montant doit être positif", nameof(p_montant));
        }

        if (string.IsNullOrWhiteSpace(p_description))
        {
            throw new ArgumentException("La transaction doit avoir une description", nameof(p_description));
        }

        this.Montant = p_montant;
        this.Type = p_typeTransaction;
        this.Description = p_description;
    }

    public TypeTransaction Type { get; }
    public string Description { get; }
    public decimal Montant { get; }

    public sealed override string ToString()
    {
        return "| " + this.Description.PadRight(LARGEUR_DESCRIPTION).Substring(0, LARGEUR_DESCRIPTION)
             + " | " + this.Type.ToString().PadRight(LARGEUR_TYPE).Substring(0, LARGEUR_TYPE)
             + " | " + (this.Type == TypeTransaction.CREDIT ? this.Montant : -this.Montant).ToString("C").PadLeft(LARGEUR_MONTANT).Substring(0, LARGEUR_MONTANT)
             + " |";
    }

    public const int LARGEUR_DESCRIPTION = 40;
    public const int LARGEUR_TYPE = 6;
    public const int LARGEUR_MONTANT = 15;

    public static string LigneIntersectionTransaction { get; } =
          "+" + "".PadLeft(LARGEUR_DESCRIPTION + 2, '-') + "+" + "".PadLeft(LARGEUR_TYPE + 2, '-') + "+" + "".PadLeft(LARGEUR_MONTANT + 2, '-') + "+";
    public static string EnteteTransaction { get; } =
         "| " + "Description de la transaction".PadBoth(LARGEUR_DESCRIPTION).Substring(0, LARGEUR_DESCRIPTION) + " | " + "Type".PadBoth(LARGEUR_TYPE).Substring(0, LARGEUR_TYPE) + " | " + "Montant".PadBoth(LARGEUR_MONTANT).Substring(0, LARGEUR_MONTANT) + " |";
}
