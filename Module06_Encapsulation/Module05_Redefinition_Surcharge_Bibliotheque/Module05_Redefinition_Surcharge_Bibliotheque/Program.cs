using System;
using System.Collections.Generic;

namespace Module05_Redefinition_Surcharge_Bibliotheque;

public class Program
{
    // Correction partielle avec la modélisation retenue en cours

    static void Main(string[] p_args)
    {
        List<Livre> livres = GenererListeLivres();
        List<Abonne> abonnes = GenererAbonnes();
        ServicesBibliotheque sb = new ServicesBibliotheque(livres, abonnes);

        Livre l1 = sb.RechercheLivreParIdentifiantInterne("SFWB001-E2");
        Livre l2 = sb.RechercheLivreParIdentifiantInterne("SFWB001-E5");

        List<Livre> ll1 = sb.RechercheLivreParISBN("2-226-06758-2");
        List<Livre> ll2 = sb.RechercheLivreParISBN("2-226-04758-2");

        List<Livre> ll3 = sb.RechercherLivreParAuteur("werber");
        List<Livre> ll4 = sb.RechercherLivreParAuteur("sdf");

        sb.EmprunterLivre(livres[0], abonnes[0]);
        sb.EmprunterLivre(livres[1], abonnes[0]);
        sb.EmprunterLivre(livres[2], abonnes[0]);
        sb.EmprunterLivre(livres[3], abonnes[0]);
        sb.EmprunterLivre(livres[4], abonnes[0]);
        sb.EmprunterLivre(livres[5], abonnes[0]);
        sb.EmprunterLivre(livres[6], abonnes[0]);
        sb.EmprunterLivre(livres[7], abonnes[0]);
        sb.EmprunterLivre(livres[8], abonnes[0]);

        DateProduction.AvancerDateProduction(ParametresBibliotheque.NOMBRE_JOURS_EMPRUNT);
        decimal detteALaJourneeMax = abonnes[0].Dette;

        livres[0].Renouveller();
        // livres[0].Renouveller();
        DateProduction.AvancerDateProduction(ParametresBibliotheque.NOMBRE_JOURS_EMPRUNT);
        decimal detteAvecPeriodeHorsDates = abonnes[0].Dette;

        sb.EmprunterLivre(livres[9], abonnes[0]);
        //  sb.EmprunterLivre(livres[10], abonnes[0]);
        //  sb.EmprunterLivre(livres[5], abonnes[0]);
        sb.EmprunterLivre(livres[5], abonnes[1]);
    }

    static List<Livre> GenererListeLivres()
    {
        return new List<Livre>() {
            new Livre("2-226-05257-7", "Les Fourmis", new List<string>() { "Bernard Werber" }, "SFWB001-E1"),
            new Livre("2-226-05257-7", "Les Fourmis", new List<string>() { "Bernard Werber" }, "SFWB001-E2"),
            new Livre("2-226-06118-5", "Le Jour des fourmis", new List<string>() { "Bernard Werber" }, "SFWB002-E1"),
            new Livre("2-226-06118-5", "Le Jour des fourmis", new List<string>() { "Bernard Werber" }, "SFWB002-E2"),
            new Livre("2-226-08636-6", "La Révolution des fourmis", new List<string>() { "Bernard Werber" }, "SFWB003-E1"),
            new Livre("2-226-08636-6", "La Révolution des fourmis", new List<string>() { "Bernard Werber" }, "SFWB003-E2"),
            new Livre("2-226-06758-2", "Les Thanatonautes", new List<string>() { "Bernard Werber" }, "SFWB004-E1"),
            new Livre("2-226-06758-2", "Les Thanatonautes", new List<string>() { "Bernard Werber" }, "SFWB004-E2"),
            new Livre("2-226-06758-2", "Les Thanatonautes", new List<string>() { "Bernard Werber" }, "SFWB004-E3"),
            new Livre("2-226-11526-9", "L'Empire des anges", new List<string>() { "Bernard Werber" }, "SFWB005-E1"),
            new Livre("2-226-15498-1", "Nous les dieux", new List<string>() { "Bernard Werber" }, "SFWB006-E1"),
            new Livre("2-226-16807-9", "Le Souffle des dieux", new List<string>() { "Bernard Werber" }, "SFWB007-E1"),
            new Livre("2-226-17979-8", "Le Mystère des dieux", new List<string>() { "Bernard Werber" }, "SFWB008-E1"),

            new Livre("0-307-88789-8", "The Lean Startup", new List<string>() { "Eric Ries" }, "BER0001-E1" ),
        };
    }

    static List<Abonne> GenererAbonnes()
    {
        return new List<Abonne>()
        {
            new Abonne("090313-F-QC-9214", "Vière", "Marie", new DateTime(2009, 3, 13)),
            new Abonne("130310-F-QC-9214", "Terrieur", "Alain", new DateTime(2013, 3, 10)),
        };
    }
}
