using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5_Heritage
{
    // Défnit un compte bancaire (classe abstraite)
    public abstract class CompteBancaire
    {
        private string titulaire; // Titulaire du compte
        private double solde;     // Solde du compte
        private string devise;    // Devise du compte

        public string Titulaire
        {
            get { return titulaire; }
        }

        public double Solde
        {
            get { return solde; }
            protected set { solde = value; }  // mutateur protégé pour la modification
        }
        // public string Solde { get; protected set; } // Propriété automatique 

        public string Devise
        {
            get { return devise; }
        }

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

        // déclaration d'une méthode abstraite
        public abstract void Debiter(double montant);

        // Renvoie la description du compte
        public virtual string Decrire()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
            return description;
        }
    }
}
