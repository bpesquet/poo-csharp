using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap7_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            GastonLagaffe gaston = new GastonLagaffe();

            Console.WriteLine("Debout Gaston ! Il faut trier le courrier !");
            gaston.TrierCourrierEnRetard(2);
            gaston.TrierCourrierEnRetard(3);

            Console.WriteLine("Gaston, Mr, Demesmaeker arrive, faites vite !");
            gaston.FaireSignerContrats();

            GererAppel(gaston, "Mr. Boulier");
            GererAppel(gaston, "Prunelle");
            GererAppel(gaston, "Jules-de-chez-Smith");

            Console.ReadKey();
        }

        private static void GererAppel(GastonLagaffe gaston, string appelant)
        {
            Console.WriteLine("Gaston, " + appelant + " au téléphone !");
            try
            {
                gaston.RepondreAuTelephone(appelant);
            }
            catch (Exception e)  // intercepte toute exception
            {
                Console.WriteLine("Encore une bonne excuse, j'imagine ?");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
