using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteCourant compteCourant = new CompteCourant("Pierre", 250, "dollars", "1234 5678 9123 4567", -500);
            compteCourant.Debiter(300);
            compteCourant.Debiter(500);
            Console.WriteLine(compteCourant.Decrire());

            CompteEpargne compteEpargne = new CompteEpargne("Paul", 1000, "euros", 0.04);
            compteEpargne.Debiter(300);
            compteEpargne.Debiter(500);
            Console.WriteLine(compteEpargne.Decrire());

            Console.ReadKey();
        }
    }
}
