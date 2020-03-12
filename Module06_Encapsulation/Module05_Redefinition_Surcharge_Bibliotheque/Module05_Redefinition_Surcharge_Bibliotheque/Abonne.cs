using System;
using System.Collections.Generic;

namespace Module05_Redefinition_Surcharge_Bibliotheque
{
    public class Abonne
    {
        public string NumeroMembre { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateDebutAbonnement { get; private set; }
        public List<Livre> LivresEmpruntes { get; } = new List<Livre>();

        public bool PeutEmprunter
        {
            get
            {
                return this.LivresEmpruntes.Count < ParametresBibliotheque.NOMBRE_LIVRES_EMPRUNTABLES
                    && this.Dette <= ParametresBibliotheque.DETTE_MAXIMUM_AUTORISEE;
            }
        }

        public decimal Dette
        {
            get
            {
                decimal dette = 0m;
                foreach (Livre livre in this.LivresEmpruntes)
                {
                    dette += livre.NombreJoursRetard * ParametresBibliotheque.PRIX_PENALITE_PAR_JOUR;
                }

                return dette;
            }
        }

        public Abonne(string p_numeroMembre, string p_nom, string p_prenom, DateTime p_dateDebutAbonnement)
        {
            if (string.IsNullOrWhiteSpace(p_numeroMembre))
            {
                throw new ArgumentException("Le numéro de membre ne peut être vide ou nul", nameof(p_numeroMembre));
            }
            if (string.IsNullOrWhiteSpace(p_nom))
            {
                throw new ArgumentException("Le nom ne peut être vide ou nul", nameof(p_nom));
            }
            if (string.IsNullOrWhiteSpace(p_prenom))
            {
                throw new ArgumentException("Le prénom ne peut être vide ou nul", nameof(p_prenom));
            }

            this.NumeroMembre = p_numeroMembre;
            this.Nom = p_nom;
            this.Prenom = p_prenom;
            this.DateDebutAbonnement = p_dateDebutAbonnement;
        }

        public void RendreLivre(Livre p_livreEmprunte)
        {
            if (p_livreEmprunte == null)
            {
                throw new ArgumentNullException("Le livre doit être passé en paramètres", nameof(p_livreEmprunte));
            }

            if (!this.LivresEmpruntes.Contains(p_livreEmprunte))
            {
                throw new ArgumentException("Le livre passé en paramètres n'était pas emprunté par cet abonné", nameof(p_livreEmprunte));
            }

            this.LivresEmpruntes.Remove(p_livreEmprunte);
        }

        public void EmprunterLivre(Livre p_livreAEmprunter)
        {
            if (p_livreAEmprunter == null)
            {
                throw new ArgumentNullException("Le livre doit être passé en paramètres", nameof(p_livreAEmprunter));
            }

            if (!p_livreAEmprunter.EstDisponible)
            {
                throw new InvalidOperationException("Le livre doit être disponible");
            }

            if (!this.PeutEmprunter)
            {
                throw new InvalidOperationException("L'abonné ne peut pas emprunter de livres.");
            }

            this.LivresEmpruntes.Add(p_livreAEmprunter);
        }

    }
}