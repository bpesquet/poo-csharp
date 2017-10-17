using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3_Memoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle monCercle = new Cercle(7.5);   // déclaration et instanciation

            // ****** VALEUR ******
            int nombre1;
            nombre1 = 5;
            int nombre2 = 3;

            nombre2 = nombre1;
            nombre1 = 10;

            Console.WriteLine("nombre1 = " + nombre1); // 10
            Console.WriteLine("nombre2 = " + nombre2); // 5

            Cercle cercle1;           // déclaration
            cercle1 = new Cercle(5);  // instanciation
            Cercle cercle2 = new Cercle(3);   // déclaration et instanciation

            cercle2 = cercle1;
            cercle1.Rayon = 10;

            Console.WriteLine("cercle1.Rayon = " + cercle1.Rayon); // 10
            Console.WriteLine("cercle2.Rayon = " + cercle2.Rayon); // 10 (???)

            // ****** EGALITE ******
            nombre1 = 5;
            nombre2 = 3;

            if (nombre1 == nombre2)
                Console.WriteLine("nombre1 et nombre2 sont égaux");
            else
                Console.WriteLine("nombre1 et nombre2 sont différents");

            nombre2 = 5;

            if (nombre1 == nombre2)
                Console.WriteLine("nombre1 et nombre2 sont égaux");
            else
                Console.WriteLine("nombre1 et nombre2 sont différents");

            cercle1 = new Cercle(5);
            cercle2 = new Cercle(3);

            if (cercle1 == cercle2)
                Console.WriteLine("cercle1 et cercle2 sont égaux");
            else
                Console.WriteLine("cercle1 et cercle2 sont différents");

            cercle2.Rayon = 5;

            if (cercle1 == cercle2)
                Console.WriteLine("cercle1 et cercle2 sont égaux");
            else
                Console.WriteLine("cercle1 et cercle2 sont différents");

            // ****** PASSAGE EN PARAMETRE ******
            int nombre = 5;

            Console.WriteLine("Avant l'appel, nombre = " + nombre);
            Augmenter(nombre);
            Console.WriteLine("Après l'appel, nombre = " + nombre);

            Cercle cercle = new Cercle(5);

            Console.WriteLine("Avant l'appel, cercle.Rayon = " + cercle.Rayon);
            AugmenterRayon(cercle);
            Console.WriteLine("Après l'appel, cercle.Rayon = " + cercle.Rayon);

            Console.ReadKey();
        }

        static void Augmenter(int unNombre)
        {
            Console.WriteLine("Avant l'augmentation, unNombre = " + unNombre);
            unNombre = unNombre + 1;
            Console.WriteLine("Après l'augmentation, unNombre = " + unNombre);
        }

        static void AugmenterRayon(Cercle unCercle)
        {
            Console.WriteLine("Avant l'augmentation, unCercle.Rayon = " + unCercle.Rayon);
            unCercle.Rayon = unCercle.Rayon + 1;
            Console.WriteLine("Après l'augmentation, unCercle.Rayon = " + unCercle.Rayon);
        }
    }
}
