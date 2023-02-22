using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{
    class Auteur:Personne
    {
        Personne _personne;
        public List<Ouvrage> list_ouvrages;


        public Auteur() {}

        public Auteur(Personne personne)
        {
            _personne = personne;
        }
               


        public void AjouterOuvrage(Ouvrage ouvrage)
        {
            list_ouvrages.Add(ouvrage);
        }
        public List<Ouvrage> getBibliographie()
        {
            return list_ouvrages;
        }

        public new string getNomPrenom()
        {
            return "bienvenue auteur:" + _personne.getNom() + " " + _personne.getPrenom();
        }
    }
}
