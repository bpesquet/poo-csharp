using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap6_Complements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avant la 1ère création : " + CompteBancaire.GetNumeroProchainCompte());
            CompteBancaire comptePierre = new CompteBancaire("Pierre");

            Console.WriteLine("Avant la 2ème création : " + CompteBancaire.GetNumeroProchainCompte());
            CompteBancaire comptePaul = new CompteBancaire("Paul");

            Console.WriteLine("Avant la 3ème création : " + CompteBancaire.GetNumeroProchainCompte());
            CompteBancaire compteJacques = new CompteBancaire("Jacques");

            Console.WriteLine("Après la 3ème création : " + CompteBancaire.GetNumeroProchainCompte());

            Console.WriteLine(comptePierre);
            Console.WriteLine(comptePaul);
            Console.WriteLine(compteJacques);

            Console.ReadKey();
        }
    }
}
