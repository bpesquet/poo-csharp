using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap6_Complements
{
    // Définit un compte bancaire
    public class CompteBancaire
    {
        private string titulaire; // Titulaire du compte
        private double solde;     // Solde du compte
        private string devise;    // Devise du compte
        private int numero;       // Numéro de compte
        private static int numeroProchainCompte = 1;  // Numéro du prochain compte créé

        public string Titulaire
        {
            get { return titulaire; }
        }

        public double Solde
        {
            get { return solde; }
        }

        public string Devise
        {
            get { return devise; }
        }

        public CompteBancaire(string titulaire)
            : this(titulaire, 0)
        { }

        public CompteBancaire(string titulaire, double soldeInitial)
            : this(titulaire, soldeInitial, "euros")
        { }

        public CompteBancaire(string titulaire, double soldeInitial, string devise)
        {
            this.titulaire = titulaire;
            solde = soldeInitial;
            this.devise = devise;
            numero = numeroProchainCompte;
            numeroProchainCompte++;
        }

        // Ajoute un montant au compte
        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        // Ajoute un montant au compte dans une certaine devise
        public void Crediter(double montant, string devise)
        {
            if (devise == Devise)
                Crediter(montant);
            else
            {
                // TODO : gérer la conversion de devises
            }
        }

        // Retire un montant au compte
        public void Debiter(double montant)
        {
            solde = solde - montant;
        }

        public override string ToString()
        {
            return "Le solde du compte numéro " + numero + " de " + titulaire + " est de " + solde + " " + devise;
        }

        public static int GetNumeroProchainCompte()
        {
            return numeroProchainCompte;
        }
    }
}
