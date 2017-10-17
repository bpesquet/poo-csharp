using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap7_Exceptions
{
    public class GastonLagaffe
    {
        public void TrierCourrierEnRetard(int nbLettres)
        {
            Console.Write("Quoi, " + nbLettres + " lettre(s) à trier ? ");
            try
            {
                Console.WriteLine("OK, OK, je vais m'y mettre...");
                if (nbLettres > 2)
                {
                    throw new Exception("Beaucoup trop de lettres...");
                }
                Console.WriteLine("Ouf, j'ai fini.");
            }
            catch (Exception e)
            {
                Console.WriteLine("M'enfin ! " + e.Message);
            }
            Console.WriteLine("Après tout ce travail, une sieste s'impose.");
        }

        public void FaireSignerContrats()
        {
            try
            {
                Console.WriteLine("Encore ces contrats ? OK, je les imprime...");
                ImprimerContrats();
                Console.WriteLine("A présent une petite signature...");
                AjouterSignature();
                Console.WriteLine("Fantasio, les contrats sont signés !");
            }
            catch (Exception e)
            {
                Console.WriteLine("M'enfin ! " + e.Message);
            }
        }

        public void AjouterSignature()
        {
            Console.WriteLine("Signez ici, M'sieur Demesmaeker.");
        }

        public void ImprimerContrats()
        {
            Console.WriteLine("D'abord, mettre en route l'imprimante.");
            AllumerImprimante();
            Console.WriteLine("Voilà, c'est fait !");
        }

        public void AllumerImprimante()
        {
            Console.WriteLine("Voyons comment allumer cette machine...");
            throw new Exception("Mais qui a démonté tout l'intérieur ?");
        }

        public void RepondreAuTelephone(string appelant)
        {
            if (appelant == "Mr. Boulier")
            {
                throw new ExceptionMenfin("Je finis un puzzle.");
            }
            else if (appelant == "Prunelle")
            {
                throw new ExceptionBof("Pas le temps, je suis dé-bor-dé !");
            }
            else
            {
                Console.WriteLine("Allô, ici Gaston, j'écoute...");
            }
        }
    }
}
