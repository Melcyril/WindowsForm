using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Concepts
{
    class Exemplaire:Ouvrage
    {
        public int code_bare = 0;
        int IdOuvrage = 0;
        

        public string getTitreOuvrage(int IdOuvrage)
        {
            if(IdOuvrage == 1)
            {
                return "Le tour du monde en 80 jours";
            }
            return "";
        }
    }
}
