using System;

using POOI_Module11_JeuTir.Geometrie;
using POOI_Module11_JeuTir.Objet;
using POOI_Module11_JeuTir.Physique;
using POOI_Module11_JeuTir.Sons;

namespace POOI_Module11_JeuTir.Armes
{
    public class Arme
    {
        public int Temperature { get; private set; }
        public Son SonTir { get; private set; }
        public Son SonTropChaud { get; private set; }

        public Arme(Son p_sonTir, Son p_sonTropChaud)
        {
            this.SonTir = p_sonTir;
            this.SonTropChaud = p_sonTropChaud;
            this.Temperature = 20;
        }


        public virtual CollisionTir Tirer(Point3D p_positionArme, Vecteur3D p_direction)
        {
            CollisionTir collisionTir = new CollisionTir();
            collisionTir.ObjetTouche = this.ObtenirCollision(p_positionArme, p_direction);
            collisionTir.Degat = this.CalculerDegat();

            return collisionTir;
        }

        protected virtual double CalculerDegat()
        {
            throw new NotImplementedException();
        }

        private ObjetJeu ObtenirCollision(Point3D p_positionArme, Vecteur3D p_direction)
        {
            return new ObjetJeu(); // Normalement un calcul ici
        }
    }
}
