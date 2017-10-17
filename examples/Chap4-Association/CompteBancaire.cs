using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4_Association
{
    // Définit un compte bancaire
    public class CompteBancaire
    {
        private Client titulaire; // Titulaire du compte
        private double solde;     // Solde du compte
        private string devise;    // Devise du compte

        public Client Titulaire
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

        // Constructeur
        public CompteBancaire(Client leTitulaire, double soldeInitial, string laDevise)
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
            string descriptionTitulaire = titulaire.Prenom + " " + titulaire.Nom;
            string description = "Le solde du compte de " + descriptionTitulaire + " est de " + solde + " " + devise;
            return description;
        }
    }
}
