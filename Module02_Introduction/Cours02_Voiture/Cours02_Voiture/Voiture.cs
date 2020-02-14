using System;

namespace Cours02_Voiture
{
    public class Voiture
    {
        private string m_marque;
        public string Marque
        {
            get { return m_marque; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marque ne doit pas être vide ou nulle", "value");
                }
                this.m_marque = value;
            }
        }

        private string m_modele;
        public string Modele
        {
            get { return m_modele; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le modèle ne doit pas être vide ou nul", "value");
                }
                m_modele = value;
            }
        }

        private double m_vitesse;
        public double Vitesse
        {
            get { return m_vitesse; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La vitesse ne doit pas être négative", "value");
                }

                if (value > 230)
                {
                    throw new ArgumentException("La vitesse ne peut pas dépasser 230 km / h !", "value");
                }

                m_vitesse = value;
            }
        }

        private bool m_estDemarree;
        public bool EstDemarree
        {
            get { return m_estDemarree; }
            set
            {
                if (EstDemarree && value)
                {
                    throw new ArgumentException("La voiture est déjà démarrée !", "value");
                }
                if (!value && this.Vitesse >= 5)
                {
                    throw new ArgumentException("La voiture ne peut pas s'arrêter car la vitesse est trop grande !", "value");
                }
                m_estDemarree = value;
            }
        }

        public void Initialiser(string p_marque, string p_modele)
        {
            this.Marque = p_marque;
            this.Modele = p_modele;
            this.Vitesse = 0;
            this.EstDemarree = false;
        }

        public void Demarrer()
        {
            if (this.EstDemarree)
            {
                throw new InvalidOperationException("La voiture est déjà démarrée !");
            }

            this.EstDemarree = true;
        }

        public void Arreter()
        {
            if (!this.EstDemarree)
            {
                throw new InvalidOperationException("La voiture est déjà à l'arrêt !");
            }

            if (this.Vitesse >= 5)
            {
                throw new InvalidOperationException("La voiture roule à une vitesse trop élevée pour être éteinte !");
            }

            this.EstDemarree = false;
            this.Vitesse = 0;
        }

        public void Accelerer(double p_vitesseGagnee)
        {
            if (!this.EstDemarree)
            {
                throw new InvalidOperationException("La voiture doit être démarrer pour pouvoir l'arrêter !");
            }
            if (p_vitesseGagnee < 0)
            {
                throw new ArgumentException("La vitesse gagnée doit être positive !", "p_vitesseGagnee");
            }

            double futureVitesse = this.Vitesse + p_vitesseGagnee;

            if (futureVitesse > 230)
            {
                throw new InvalidOperationException("La vitesse ne peut pas dépasser 230 km / h !");
            }

            this.Vitesse = futureVitesse;
        }

        public void Freiner(double p_vitessePerdue)
        {
            if (!this.EstDemarree)
            {
                throw new InvalidOperationException("La voiture doit être démarrer pour pouvoir l'arrêter !");
            }
            if (p_vitessePerdue < 0)
            {
                throw new ArgumentException("La vitesse gagnée doit être positive !", "p_vitessePerdue");
            }

            double futureVitesse = this.Vitesse - p_vitessePerdue;

            if (futureVitesse < 0)
            {
                throw new InvalidOperationException("La vitesse ne peut pas dépasser 230 km / h !");
            }

            this.Vitesse = futureVitesse;
        }

        public string RenvoyerEtat()
        {
            string etat = "arrêtée";
            if (this.EstDemarree)
            {
                etat = "démarrée";
            }
            return $"Je suis la voiture de marque {this.Marque}, de modèle {this.Modele}, de vitesse {this.Vitesse} et je suis {etat}.";
        }
    }
}
