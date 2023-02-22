using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Calculatrice
    {

        public Double Num1 = 0;
        public Double Num2 = 0;
        public String Operateur = "";
        public Double Resultat = 0;


        //constructeur
        public Calculatrice(Double num1, Double num2, String operateur)
        {
            Num1 = num1;
            Num2 = num2;
            Operateur = operateur;
        }


        public Double Calculer(Double num1, Double num2)
        {
            if (Operateur == "+")
            {
                Resultat = num1 + num2;
            }
            else if (Operateur == "-")
            {
                Resultat = num1 - num2;
            }
            else if (Operateur == "*")
            {
                Resultat = num1 * num2;
            }
            else
            {
                Resultat = num1 / num2;
            }
            return Resultat;
        }

    }
}
