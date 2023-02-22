using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{
    class Ouvrage
    {
        public int IdOuvrage = 0;
        public string Titre = "";
        public string Description = "";
        public string Auteur = "";
        public DateTime DatePublication;

        public Ouvrage() { }

        public Ouvrage(int _IdOuvrage, string _Titre, string _Description, string _Auteur, DateTime _DatePublication)
        {
            IdOuvrage = _IdOuvrage;
            Titre = _Titre;
            Description = _Description;
            Auteur = _Auteur;
            DatePublication = _DatePublication;
        }


    }
}
