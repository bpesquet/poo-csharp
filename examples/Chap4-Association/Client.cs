using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4_Association
{
    // Modélise un client
    public class Client
    {
        private int numero;    // Numéro de compte
        private string nom;    // Nom
        private string prenom; // Prénom
        private List<CompteBancaire> comptes; // Liste des comptes bancaires

        public int Numero
        {
            get { return numero; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        public List<CompteBancaire> Comptes
        {
            get { return comptes; }
        }

        public Client(int leNumero, string leNom, string lePrenom)
        {
            comptes = new List<CompteBancaire>();

            numero = leNumero;
            nom = leNom;
            prenom = lePrenom;
        }
    }
}
