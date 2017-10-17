using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap1_Initiation
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire comptePierre = new CompteBancaire();
            comptePierre.titulaire = "Pierre";
            comptePierre.solde = 500;
            comptePierre.devise = "euros";

            CompteBancaire comptePaul = new CompteBancaire();
            comptePaul.titulaire = "Paul";
            comptePaul.solde = 150;
            comptePaul.devise = "euros";

            Console.Write("Entrez le montant du transfert : ");
            double montantTransfert = Convert.ToDouble(Console.ReadLine());
            comptePierre.Debiter(montantTransfert);
            comptePaul.Crediter(montantTransfert);

            Console.WriteLine(comptePierre.Decrire());
            Console.WriteLine(comptePaul.Decrire());

            Console.ReadKey();
        }
    }
}
