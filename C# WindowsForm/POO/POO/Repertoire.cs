using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Repertoire
    {    
        string chemin = "";
        string nomFichier = "";
        string contenu = "";


        public string creerFichier(string nom, string texte)
        {
            try
            {
                chemin = Directory.GetCurrentDirectory();
                contenu = texte;
                nomFichier = nom;
                File.AppendAllText(chemin + "/" + nomFichier, contenu);
                return "Création du fichier OK";

            }
            catch (Exception ex)
            {
                contenu = ex.Message;
                return ex.Message;
            }
        }
    }
}
