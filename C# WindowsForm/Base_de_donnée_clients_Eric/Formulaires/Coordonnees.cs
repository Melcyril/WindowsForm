using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaires
{
    class Coordonnees
    {

        public void ExportCSV(List<Coordonnee> list)
        {
            string fichierCSV = "IdClient;Civilité;Nom;Prénom;DateNaissance;Téléphone;Email;Password\n\r";
            foreach(Coordonnee coordo in list)
            {
                string dtNaissance = "---";
                if (coordo.dateNaissance.ToShortDateString() != DateTime.Now.ToShortDateString())
                {
                    dtNaissance = coordo.dateNaissance.ToShortDateString();
                }

                fichierCSV += coordo.IdClient + ";"+coordo.NomClient+";"+coordo.PrenomClient+";"+dtNaissance+";"+coordo.telephone+";"+coordo.password+"\n\r";
            }
            string cheminExport = Directory.GetCurrentDirectory() + "/ExportClient.csv";
            File.WriteAllText(cheminExport, fichierCSV,Encoding.UTF8);
            Process.Start(cheminExport);
        }

    }
    public struct Coordonnee
    {
        public int IdClient;
        public bool Civilite;
        public string NomClient;
        public string PrenomClient;
        public DateTime dateNaissance;
        public string telephone;
        public string email;
        public string password;


    }
}
