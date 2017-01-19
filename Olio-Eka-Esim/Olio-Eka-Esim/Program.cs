using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Eka_Esim
{
    class Program
    {
        static void Main(string[] args)
        {
            // määritellään muuttuja 
            string nimi = "Pepe";
            // tulostetaan muuttujan arvo konsolille
            Console.WriteLine("C'est ne pas un " + nimi);
            // pidetään sovelluksen ajoikkuna näytöllä. Sulkeutuu, kun käyttäjä painaa Enter-painiketta
            Console.ReadLine();
        }
    }
}
