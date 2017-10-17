using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap1_Initiation
{
    // Défnit un compte bancaire
    public class CompteBancaire
    {
        public string titulaire; // Titulaire du compte
        public double solde;     // Solde du compte
        public string devise;    // Devise du compte

        // Ajoute un montant au compte
        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        // Retire un montant au compte
        public void Debiter(double montant)
        {
            solde = solde - montant;
        }

        // Renvoie la description du compte
        public string Decrire()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
            return description;
        }
    }
}
