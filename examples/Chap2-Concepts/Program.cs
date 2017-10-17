using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration et instanciation d'un nouvel objet en utilisant son constructeur
            CompteBancaire comptePierre = new CompteBancaire("Pierre", 0, "euros");

            // Impossible : le seul constructeur existant attend 3 paramètres
            //CompteBancaire comptePaul = new CompteBancaire();

            // appels de méthodes
            comptePierre.Crediter(300);
            comptePierre.Debiter(500);
            Console.WriteLine(comptePierre.Decrire());

            string titulaireCompte = comptePierre.Titulaire;  // OK : le getter existe
            //comptePierre.Solde = 500;                         // Erreur : pas de setter
            //comptePierre.Devise = "dollars";                  // Erreur : pas de setter

            Console.ReadKey();
        }
    }
}
