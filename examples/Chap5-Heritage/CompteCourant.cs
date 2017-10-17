using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5_Heritage
{
    // Modélise un compte courant
    public class CompteCourant : CompteBancaire
    {
        private string numeroCB;
        private double decouvertMaxi;

        // Constructeur
        public CompteCourant(string leTitulaire, double soldeInitial, string laDevise, string numeroCB, double decouvertMaxi)
            : base(leTitulaire, soldeInitial, laDevise)  // appel au constructeur de CompteBancaire
        {
            this.numeroCB = numeroCB;
            this.decouvertMaxi = decouvertMaxi;
        }

        // Redéfinition de la méthode Debiter
        public override void Debiter(double montant)
        {
            // on n'effectue le débit que si le solde final reste supérieur au découvert
            if (Solde - montant >= decouvertMaxi)
                Solde -= montant;
        }

        // Redéfinition de la méthode Decrire
        public override string Decrire()
        {
            return base.Decrire() + ". Son numéro CB est " + numeroCB + " et son découvert maxi est de " + decouvertMaxi + " " + Devise + ".";
        }
    }
}
