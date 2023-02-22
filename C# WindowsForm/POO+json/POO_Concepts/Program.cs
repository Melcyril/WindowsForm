using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bibliothèque");


            Ouvrage ouvrage = new Ouvrage();
            ouvrage.IdOuvrage = 1;
            ouvrage.Titre = "Le tour du monde en 80 jours";
            ouvrage.Auteur = "Alexis";
            ouvrage.Description = "meilleur livre";
            ouvrage.DatePublication = new DateTime (1886,10,04);
            Console.WriteLine(ouvrage.Titre+" publié le "+ouvrage.DatePublication.ToShortDateString());


            Ouvrage ouvrage2 = new Ouvrage();
            ouvrage2.IdOuvrage = 2;
            ouvrage2.Titre = "Le tour de France en 14 jours";
            ouvrage2.Auteur = "Dimitri";
            ouvrage2.Description = "bon livre";
            ouvrage2.DatePublication = new DateTime(1930, 09, 02);
            Console.WriteLine(ouvrage2.Titre + " publié le " + ouvrage2.DatePublication.ToShortDateString());


            //Exemplaire exemplaire1 = new Exemplaire();
            //exemplaire1.Titre = "Le petit Nicolas";
            //exemplaire1.Description = "bon livre";
            //exemplaire1.Auteur = "Nadine";
            //exemplaire1.DatePublication = new DateTime(1946,01,05);
            //exemplaire1.code_bare = 123456;
            //Console.WriteLine("ouvrage associé à exemplaire : " + exemplaire1.getTitreOuvrage(1));


            ////liste des ouvrages
            List<Ouvrage> liste_ouvrages = new List<Ouvrage>();
            liste_ouvrages.Add(ouvrage);
            liste_ouvrages.Add(ouvrage2);

            Ouvrage ouvrage3 = new Ouvrage (3, "le livre de la jungle","vieux livre","Rudyard",new DateTime(1990,02,02));
            liste_ouvrages.Add(ouvrage3);

            Ouvrage ouvrage4 = new Ouvrage(4, "le livre des motos", "nouveau livre", "Rudyard", new DateTime(2018, 02, 02));
            liste_ouvrages.Add(ouvrage4);
            

            Auteur auteur1 = new Auteur();
            auteur1.list_ouvrages = liste_ouvrages;

            Console.WriteLine("Liste et Nombres d'ouvrage enregistrés : " + liste_ouvrages.Count());

            foreach (Ouvrage item in liste_ouvrages)
            {
                Console.WriteLine("Auteur : " + item.Auteur);
            }


            List<Ouvrage> listeOuvrages = auteur1.getBibliographie();


            //créer fichier json
            string chemin = Directory.GetCurrentDirectory() + "/ListeOuvrages.json";
            File.WriteAllText(chemin, "");
            string texteOuvrage = "{\"Ouvrage\":[";

            for (int i = 0; i < liste_ouvrages.Count(); i++)
            {
                texteOuvrage += "{";
                texteOuvrage += "\"IdOuvrage\" :\"" + listeOuvrages[i].IdOuvrage.ToString() + "\",";
                texteOuvrage += "\"Titre\" :\"" + listeOuvrages[i].Titre.ToString() + "\",";
                texteOuvrage += "\"Description\" :\"" + listeOuvrages[i].Description.ToString() + "\",";
                texteOuvrage += "\"Auteur\" :\"" + listeOuvrages[i].Auteur.ToString() + "\",";
                texteOuvrage += "\"DatePublication\" :\"" + listeOuvrages[i].DatePublication.ToString() + "\"";
                texteOuvrage += "},";            
            }
            //ne pas récupérer la derniere virgule de l'ouvrage
            texteOuvrage = texteOuvrage.Substring(0, texteOuvrage.Length - 1);
            texteOuvrage += "]}";
            
            File.AppendAllText(chemin, texteOuvrage);

            Console.WriteLine(chemin);

                                                    

            //class personne
            //Personne personne = new Personne();
            //personne.setNomPersonne("Stradivarius");
            //personne.setPrenomPersonne("Anton");


            //Utilisateur utilisateur = new Utilisateur();
            //utilisateur.NomPersonne = personne.getNom();
            //Console.WriteLine("Personne : " + utilisateur.NomPersonne());


            //Console.WriteLine("Personne : " + personne.getNomPrenom());


            //Auteur auteur = new Auteur(personne);
            //Console.WriteLine("Personne : " + auteur.getNomPrenom());



            ////calculatrice
            //Console.WriteLine("Nombre 1 :");
            //Double num1 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Nombre 2 :");
            //Double num2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Opérateur :");
            //String operateur = Console.ReadLine();

            //Calculatrice calcul = new Calculatrice(num1, num2, operateur);
            //Console.WriteLine("Résultat : " + calcul.Calculer(num1,num2));



            //creer fichier
            //Repertoire repertoire1 = new Repertoire();
            //string result = repertoire1.creerFichier("Historique_operation.txt","[" + DateTime.Now.ToLongTimeString() + "]" + " : " + calcul.Calculer(num1, num2).ToString() + "\r\n");
            //Console.WriteLine(result);
                                                          
                       
            Console.Read();
        }
    }
}
