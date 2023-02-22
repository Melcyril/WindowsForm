using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ma Vidéothèque");

            Film film01 = new Film();
            film01.IdFilm = 1;
            film01.Titre = "Titanic";
            film01.Genre = "Drame";
            film01.DatePublication = new DateTime(1997, 09, 01);
            Console.WriteLine(film01.IdFilm + "  " + film01.Titre + "  " + film01.Genre + "  " + film01.DatePublication.ToShortDateString());


            Film film02 = new Film();
            film02.IdFilm = 2;
            film02.Titre = "Jurassic Parc";
            film02.Genre = "Aventure";
            film02.DatePublication = new DateTime(1993, 09, 01);
            Console.WriteLine(film02.IdFilm + "  " + film02.Titre + "  " + film02.Genre + "  " + film02.DatePublication.ToShortDateString());


            //liste des films
            List<Film> liste_films = new List<Film>();
            liste_films.Add(film01);
            liste_films.Add(film02);
            Console.WriteLine("Nombres de films : " + liste_films.Count());

            foreach (Film item in liste_films)
            {
                Console.WriteLine("Titre : " + item.Titre);
            }



            //calculatrice
            Console.WriteLine("Entrez Nombre 1 :");
            Double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez Nombre 2 :");
            Double num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez Opérateur :");
            String operateur = Console.ReadLine();

            Calculatrice calcul = new Calculatrice(num1, num2, operateur);
            Console.WriteLine("Résultat : " + calcul.Calculer(num1, num2));



            //créer fichier txt
            Repertoire repertoire1 = new Repertoire();
            string result = repertoire1.creerFichier("Historique_Calculatrice.txt", "[" + DateTime.Now.ToLongTimeString() + "]" + " : " + calcul.Calculer(num1, num2).ToString() + "\r\n");
            Console.WriteLine(result);



            Console.Read();
        }
    }
}
