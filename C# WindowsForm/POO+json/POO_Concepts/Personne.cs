using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{

    class Personne
    {
        int  IdPersonne = 0;
        string NomPersonne="";
        string PrenomPersonne="";

        public Personne() { }

        //constructeurs
        public Personne(int IdPersonne, string Nom)
        {
            IdPersonne = 1;
            NomPersonne = "Robert";
            PrenomPersonne = "George";
        }
        public Personne(int idPersonne, String nom, String prenom)
        {
            IdPersonne = idPersonne;
            NomPersonne = nom;
            PrenomPersonne = prenom;
        }
      
        
        //accesseurs      
        public string getNom()
        {
            return NomPersonne;
        }

        public void setNomPersonne(string nomPersonne)
        {
            NomPersonne = nomPersonne;
        }

        public void setPrenomPersonne(string prenom)
        {
            PrenomPersonne = prenom;
        }

        public string getPrenom()
        {
            return PrenomPersonne;
        }

        public string getNomPrenom()
        {
            return "bienvenue utilisateur:" + getNom() + " " + getPrenom();
        }

    }
    
    // struct "pour récupérer les meme propriétés"
    struct Utilisateur
    {
        public int IdPersonne;
        public string NomPersonne;
        public string PrenomPersonne;
    }
       
}
