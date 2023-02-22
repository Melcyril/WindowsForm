using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{
    class Repertoire
    { //propriété du repertoire
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
                File.AppendAllText(chemin +"/"+ nomFichier, contenu);
                return "ok";

            }
            catch (Exception ex)
            {
                contenu = ex.Message;
                return ex.Message;
            }
        }
    }
}
