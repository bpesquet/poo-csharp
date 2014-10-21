Programmer avec des objets
==========================

Ecriture d'une classe
---------------------

Une fois la modélisation d'une classe terminée, il est possible de la traduire dans n'importe quel langage de programmation orienté objet.

Voici la traduction en C# de la classe `CompteBancaire`.

```csharp
public class CompteBancaire
{
    public string titulaire;
    public double solde;
    public string devise;

    public void Crediter(double montant)
    {
        solde = solde + montant;
    }
    public void Debiter(double montant)
    {
        solde = solde - montant;
    }
}
```

La définition d'une classe commence par le mot-clé `class`. On retrouve ensuite la définition des champs (attributs) et des méthodes de la classe. On remarque que les méthodes utilisent (et modifient) les valeurs des attributs.

Une méthode est une sorte de sous-programme. On peut y déclarer des variables locales et y utiliser tous les éléments de programmation déjà connus (alternatives, boucles, etc).

On remarque d'un nouveau mot-clé : `public`, sur lequel nous reviendrons ultérieurement (TODO).

A noter également : l'absence du mot-clé `static` dans la définition d'une méthode. Ce mot-clé était utilisé pour définir un sous-programme en C#.

Utilisation d'une classe
------------------------

En utilisant le modèle fourni par la classe, il est possible de créer autant d'objets que nécessaire. Des objets différents de la même classe disposent tous des mêmes attributs et méthodes, mais les valeurs des attributs sont différentes pour chaque objet. Par exemple, tous les comptes bancaires auront un solde, mais sauf exception, ce solde sera différent pour chaque compte.

Le programme C# ci-dessous utilise la classe `CompteBancaire` définie plus haut pour créer le compte de Jean et y effectuer deux opérations.

    static void Main(string[] args)
    {
        CompteBancaire comptePierre;          // déclaration d'un nouvel objet
        comptePierre = new CompteBancaire();  // instanciation de cet objet

        // affectations de valeurs aux attributs
        comptePierre.titulaire = "Pierre";
        comptePierre.solde = 0;
        comptePierre.devise = "euros";

        // appels de méthodes
        comptePierre.Crediter(300);
        comptePierre.Debiter(500);
        string description = "Le solde du compte de " + comptePierre.titulaire +
            " est de " + comptePierre.solde + " " + comptePierre.devise;
        Console.WriteLine(description);
    }

A la fin du programme, l'attribut *solde* de l'objet `comptePierre` contient la valeur -200.

{{% img compte_pierre.jpg %}}

Déclaration et instanciation
----------------------------

On remarque que la création de l'objet `comptePierre` se fait en deux étapes :

1.  déclaration de l'objet
2.  instanciation de l'objet

    CompteBancaire comptePierre;          // déclaration d'un nouvel objet
    comptePierre = new CompteBancaire();  // instanciation de cet objet
    // ...

La **déclaration** permet de créer une nouvelle variable, appelée `comptePierre` dans l'exemple ci-dessus. A ce stade, aucune réservation de mémoire n'a eu lieu pour cet objet. Il est donc inutilisable.

Le type de la variable `comptePierre` est `CompteBancaire`. Le type d'un objet est sa classe.

**L'instanciation** utilise l'opérateur `new`, qui permet de réserver une zone mémoire spécifique pour l'objet. On dit que l'objet est instancié par l'opérateur `new`. Sans cette étape indispensable, l'objet déclaré ne peut pas être utilisé.

{{% definition %}}
**L'instanciation** est l'opération qui consiste à créer un nouvel objet à partir d'une classe, au moyen de l'opérateur `new`.
{{% /definition %}}

Il est courant de rassembler sur une même ligne déclaration et instanciation d'un objet.

    CompteBancaire comptePierre = new CompteBancaire();  // déclaration et instanciation d'un nouvel objet
    // ...

{{% warning %}}
Ne pas confondre **instanciation** et **initialisation** :

* instancier, c'est créer un nouvel objet (opérateur ``new``)
* initialiser, c'est donner une valeur initiale à quelque chose (opérateur ``=``)
{{% /warning %}}

Ajout d'une méthode
-------------------

Comme il est fastidieux de construire la description d'un compte bancaire à chaque fois qu'on en a besoin, on voudrait ajouter une opération de description du compte. Cette action est réalisée par une nouvelle méthode nommée *Decrire* ajoutée à la classe `CompteBancaire`. La description est renvoyée sous la forme d'une chaîne de caractères (`string`).

    public class CompteBancaire
    {
        // ...

        // Renvoie la description d'un compte
        public string Decrire()
        {
            string description = "Le solde du compte de " +  titulaire + " est de " + solde + " " + devise;
            return description;
        }
    }

Instanciation de plusieurs objets
---------------------------------

Voici un autre programme qui gère les comptes de Pierre et de Paul. Il permet à l'utilisateur de saisir un montant qui sera débité à Pierre et crédité à Paul.

    static void Main(string[] args)
    {
        CompteBancaire comptePierre = new CompteBancaire();
        comptePierre.titulaire = "Pierre";
        comptePierre.solde = 500;
        comptePierre.devise = "euros";

        CompteBancaire comptePaul = new CompteBancaire();
        comptePaul.titulaire = "Paul";
        comptePaul.solde = 150;
        comptePaul.devise = "euros";

        Console.Write("Entrez le montant du transfert : ");
        double montantTransfert = Convert.ToDouble(Console.ReadLine());
        comptePierre.Debiter(montantTransfert);
        comptePaul.Crediter(montantTransfert);

        Console.WriteLine(comptePierre.Decrire());
        Console.WriteLine(comptePaul.Decrire());
    }

{{% img compte_pierre_paul.jpg %}}
