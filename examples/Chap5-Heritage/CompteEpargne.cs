using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5_Heritage
{
    // Définit un compte épargne (type particulier de compte bancaire)
    public class CompteEpargne : CompteBancaire
    {
        private double tauxInteret; // Taux d'intérêt du compte

        public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret)
            : base(leTitulaire, soldeInitial, laDevise)
        // appel du constructeur de la classe CompteBancaire
        // le mot-clé "base" permet d'accéder à la classe parente
        {
            tauxInteret = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // utilisation du mutateur Solde protégé dans CompteBancaire pour accéder au solde du compte
            double interets = Solde * tauxInteret;
            Solde += interets;
        }

        // redéfinition de la méthode Debiter
        public override void Debiter(double montant)
        {
            // Le montant maximal d'un retrait est la moitié du solde actuel
            if (montant <= Solde / 2)
                Solde -= montant;
        }

        // Redéfinition de la méthode Decrire
        public override string Decrire()
        {
            return base.Decrire() + ". Son taux d'intérêt est de " + (tauxInteret * 100) + "%.";
        }
    }
}
