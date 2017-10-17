using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3_Memoire
{
    // Modélise un cercle
    public class Cercle
    {
        private double rayon;  // Rayon du cercle

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        // Constructeur
        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        // Calcule le périmètre du cercle
        public double CalculerPerimetre()
        {
            double perimetre = 2 * Math.PI * rayon;
            return perimetre;
        }
    }
}
