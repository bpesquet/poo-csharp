using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2_Concepts
{
    // Définit un compte bancaire
    public class CompteBancaire
    {
        private string titulaire; // Titulaire du compte
        private double solde;     // Solde du compte
        private string devise;    // Devise du compte

        public string Titulaire
        {
            get { return titulaire; }
        }
        // public string Titulaire { get; private set; } // Propriété automatique
        // public string Titulaire { get; } // Incorrect avant C# 6 (.NET framework 4.6)

        public double Solde
        {
            get { return solde; }
        }
        // public string Solde { get; private set; } // Propriété automatique 

        public string Devise
        {
            get { return devise; }
        }
        // public string Devise { get; private set; } // Propriété automatique

        // Constructeur
        public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
        {
            titulaire = leTitulaire;
            solde = soldeInitial;
            devise = laDevise;
        }

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
