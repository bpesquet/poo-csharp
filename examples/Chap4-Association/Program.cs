using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4_Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Client pierre = new Client(123456, "Kiroul", "Pierre");
            Client paul = new Client(987654, "Ochon", "Paul");

            // association entre pierre et compte1
            CompteBancaire compte1 = new CompteBancaire(pierre, 500, "euros");
            pierre.Comptes.Add(compte1);

            // association entre paul et compte2
            CompteBancaire compte2 = new CompteBancaire(paul, 1000, "euros");
            paul.Comptes.Add(compte2);

            Console.WriteLine(compte1.Decrire());
            Console.WriteLine(compte2.Decrire());

            Console.ReadKey();
        }
    }
}
