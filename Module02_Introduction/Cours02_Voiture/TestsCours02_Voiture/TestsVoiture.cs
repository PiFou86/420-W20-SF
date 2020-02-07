using System;
using Xunit;
using Cours02_Voiture;

namespace TestsCours02_Voiture
{
    public class TestsVoiture
    {
        [Fact]
        public void Initialiser_CasMarqueNulle_Exception()
        {
            // Arranger
            string marque = null;
            string modele = "modele1";

            // Agir && Auditer
            Voiture v = new Voiture();
            Assert.Throws<ArgumentException>(() =>
            {
                v.Initialiser(marque, modele);
            });
        }

        [Fact]
        public void Initialiser_CasModeleeNul_Exception()
        {
            // Arranger
            string marque = "marque1";
            string modele = null;

            // Agir && Auditer
            Voiture v = new Voiture();
            Assert.Throws<ArgumentException>(() =>
            {
                v.Initialiser(marque, modele);
            });
        }

        [Fact]
        public void Initialiser_CasNormal_ObjetInitialise()
        {
            // Arranger
            string marque = "marque1";
            string modele = "modele1";
            double vitesseAttendue = 0;

            // Agir 
            Voiture v = new Voiture();
            v.Initialiser(marque, modele);

            // Auditer
            Assert.Equal(marque, v.Marque);
            Assert.Equal(modele, v.Modele);
            Assert.False(v.EstDemarree);
            Assert.Equal(vitesseAttendue, v.Vitesse);

        }

        [Fact]
        public void Demarrer_CasArretee_VoitureDemarree()
        {
            // Arranger
            string marque = "marque1";
            string modele = "modele1";
            double vitesseAttendue = 0;
            Voiture v = new Voiture();
            v.Initialiser(marque, modele);

            // Agir 
            v.Demarrer();

            // Auditer
            Assert.Equal(marque, v.Marque);
            Assert.Equal(modele, v.Modele);
            Assert.True(v.EstDemarree);
            Assert.Equal(vitesseAttendue, v.Vitesse);
        }

        [Fact]
        public void Demarrer_CasDemarree_Exception()
        {
            // Arranger
            string marque = "marque1";
            string modele = "modele1";
            Voiture v = new Voiture();
            v.Initialiser(marque, modele);
            v.Demarrer();

            // Agir && Auditer
            Assert.Throws<InvalidOperationException>(()
             =>
           {
               v.Demarrer();
           });
        }

        [Fact]
        public void Arreter_CasDemarree_VoitureArretee()
        {
            // Arranger
            string marque = "marque1";
            string modele = "modele1";
            double vitesseAttendue = 0;
            Voiture v = new Voiture();
            v.Initialiser(marque, modele);
            v.Demarrer();

            // Agir 
            v.Arreter();

            // Auditer
            Assert.Equal(marque, v.Marque);
            Assert.Equal(modele, v.Modele);
            Assert.False(v.EstDemarree);
            Assert.Equal(vitesseAttendue, v.Vitesse);
        }

        [Fact]
        public void Arreter_CasArretee_Exception()
        {
            // Arranger
            string marque = "marque1";
            string modele = "modele1";
            Voiture v = new Voiture();
            v.Initialiser(marque, modele);

            // Agir && Auditer
            Assert.Throws<InvalidOperationException>(()
             =>
           {
               v.Arreter();
           });
        }

        // Tests Acceler
        // ...

        // Tests Freiner
        // ...

        // RenvoyerEtat
        // ...

    }
}
