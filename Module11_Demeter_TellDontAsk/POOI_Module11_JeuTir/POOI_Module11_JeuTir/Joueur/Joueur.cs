using System.Collections.Generic;

using POOI_Module11_JeuTir.Armes;
using POOI_Module11_JeuTir.Geometrie;
using POOI_Module11_JeuTir.Physique;
using POOI_Module11_JeuTir.Sons;

namespace POOI_Module11_JeuTir.Joueur
{
    public class Joueur : ObjetMobile
    {
        private List<Arme> m_armes;
        public List<Arme> Armes
        {
            get
            {
                return new List<Arme>(this.m_armes);
            }
        }

        private Arme m_armeSelectionnee;
        private Vecteur3D m_directionRegard;
        private Point3D m_position;

        public MoteurSon MoteurSon { get; private set; }

        public Joueur()
        {
            this.m_armes = new List<Arme>();
            this.m_armes.Add(new Stylo());
            this.m_armeSelectionnee = this.Armes[0];
            this.m_position = new Point3D() { X = 0, Y = 0, Z = 0 };
            this.m_directionRegard = new Vecteur3D() { X = 1, Y = 0, Z = 0 };
        }

        public void RamasserArme(Arme p_arme)
        {
            this.m_armes.Add(p_arme);
        }

        public void Tirer()
        {
            if (this.m_armeSelectionnee.Temperature < 250)
            {
                CollisionTir col = this.m_armeSelectionnee.Tirer(this.m_position, this.m_directionRegard);
                if (col != null)
                {
                    col.ObjetTouche.AppliquerDomage(col.Degat);
                }
                this.MoteurSon.LireSon(this.m_armeSelectionnee.SonTir);
            }
            else
            {
                this.MoteurSon.LireSon(this.m_armeSelectionnee.SonTropChaud);
            }
        }

        public void SelectionnerArme(int p_numeroArme)
        {
            this.m_armeSelectionnee = this.m_armes[p_numeroArme];
        }
    }
}
