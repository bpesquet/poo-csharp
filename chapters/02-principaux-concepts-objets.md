# Principaux concepts objets

L'objectif de ce chapitre est de présenter les concepts essentiels de la programmation orientée objet.

## Constructeur

Reprenons l'exemple de notre classe `CompteBancaire` du chapitre précédent.

![Diagramme de la classe CompteBancaire](../images/uml_compte_bancaire_4.png)

Tout compte a nécessairement un titulaire, un solde initial et une devise lors de sa création. On aimerait pouvoir instancier un objet de la classe `CompteBancaire` en définissant directement les valeurs de ses attributs. Pour cela, nous allons ajouter à notre classe une méthode particulière : le **constructeur**.

```csharp
public class CompteBancaire
{
    public string titulaire;
    public double solde;
    public string devise;

    // Constructeur
    public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
    {
        titulaire = leTitulaire;
        solde = soldeInitial;
        devise = laDevise;
    }

    // ...
```

**DEFINITION** : le **constructeur** est une méthode spécifique dont le rôle est de construire un objet, le plus souvent en initialisant ses attributs.

**ATTENTION** : le nom du constructeur doit être identique au nom de la classe, et sa définition ne comporte pas le mot-clé `void`.

L'utilisation d'un constructeur se fait au moment de l'instanciation de l'objet (opérateur `new`), en passant en paramètres les futures valeurs des attributs de l'objet créé.

```csharp
// déclaration et instanciation d'un nouvel objet en utilisant son constructeur
CompteBancaire comptePierre = new CompteBancaire("Pierre", 0, "euros");

// appels de méthodes
comptePierre.Crediter(300);
comptePierre.Debiter(500);
Console.WriteLine(comptePierre.Decrire());
```

**REMARQUES**

* Un constructeur par défaut (vide) est implicitement créé (pas besoin de l'écrire).
* Une classe peut disposer de plusieurs constructeurs initialisant différents attributs.

## Encapsulation

L'écriture de classes offre d'autres avantages que le simple regroupement de données et de traitements au même endroit. Parmi ces avantages figure la possibilité de restreindre l'accès à certains éléments de la classe. C'est ce que l'on appelle **l'encapsulation**.

Exemple d'utilisation
---------------------

On souhaite qu'un compte bancaire créé ne puisse pas changer de titulaire ni de devise. Cela est possible en définissant les attributs `titulaire` et `devise` comme étant **privés**.

```csharp
public class CompteBancaire
{
    private string titulaire;   // attribut privé
    public double solde;
    private string devise;      // attribut privé

    public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
    {
        titulaire = leTitulaire;
        solde = soldeInitial;
        devise = laDevise;
    }

    // ...
```

A présent, la seule manière de définir des valeurs pour `titulaire` et `devise` est d'utiliser le constructeur. Toute tentative d'accès externe aux propriétés privées génèrera une erreur lors de la compilation.

```csharp
CompteBancaire comptePierre = new CompteBancaire("Pierre", 0, "euros");

comptePierre.titulaire = "Pierre";  // Erreur : titulaire est un attribut privé
comptePierre.solde = 500;           // OK : solde est un attribut public
comptePierre.devise = "euros";      // Erreur : devise est un attribut privé
```

### Définition

Les mots-clés `public` et `private` permettent de modifier le **niveau d'encapsulation** (on parle aussi de **visibilité** ou **d'accessibilité**) des éléments de la classe (attributs et méthodes) :

* un élément **public** est librement utilisable depuis le reste du programme.
* un élément **privé** est uniquement utilisable depuis les méthodes de la classe elle-même.

**REMARQUE** : dans de nombreux langages dont le C#, il existe un niveau d'encapsulation intermédiaire (``protected``) qui sera étudié plus loin.

**DEFINITION** : **l'encapsulation** est l'un des principes fondamentaux de la POO. Il consiste à restreindre l'accès à certains éléments d'une classe (le plus souvent ses attributs). L'objectif de l'encapsulation est de ne laisser accessible que le strict nécessaire pour que la classe soit utilisable.

**CONSEIL** : sauf cas particulier, on donne le niveau de visibilité `private` à tous les attributs d'une classe.

```csharp
public class CompteBancaire
{
    private string titulaire;
    private double solde;
    private string devise;

    // ...
```

### Avantages

L'encapsulation offre de nombreux avantages :

* diminution des risques de mauvaise manipulation d'une classe.
* création de classes "boîtes noires" par masquage des détails internes.
* possibilité de modifier les détails internes d'une classe (la manière dont elle fonctionne) sans changer son comportement extérieur (ce qu'elle permet de faire).

## Accesseurs

L'encapsulation des attributs a permis d'interdire toute modification (accidentelle ou volontaire) des données d'un compte bancaire. Cependant, il est maintenant impossible de consulter le solde, le titulaire ou la devise d'un compte créé, ce qui est gênant. On aimerait pouvoir accéder aux données de la classe, tout en maintenant un certain niveau de contrôle. Cela est possible en ajoutant à la classe des **accesseurs**.

### Ajout d'accesseurs à une classe

Voici la classe `CompteBancaire` modifiée pour intégrer des accesseurs vers ses attributs, ainsi que son diagramme de classe.

```csharp
public class CompteBancaire
{
    private string titulaire;
    private double solde;
    private string devise;

    public string Titulaire
    {
        get { return titulaire; }
        set { titulaire = value; }
    }

    public double Solde
    {
        get { return solde; }
        set { solde = value; }
    }

    public string Devise
    {
        get { return devise; }
        set { devise = value; }
    }

    // ...
```

![Diagramme de la classe CompteBancaire](../images/uml_compte_bancaire_2.jpg)

### Définition

**DEFINITION** : un **accesseur** est une méthode le plus souvent *publique* qui permet d'accéder à un attribut *privé*.

* un accesseur en lecture (*getter*) permet de **lire** la valeur d'un attribut.
* un accesseur en écriture (mutateur ou *setter*) permet de **modifier** la valeur d'un attribut.

**REMARQUE** : en C#, les accesseurs prennent la forme de **propriétés**. Une propriété se manipule comme un champ, mais il s'agit en réalité d'un couple d'accesseurs *get* et *set*. Dans la plupart des autres langages, les accesseurs sont des méthodes de la forme `getXXX` et `setXXX`.

**DANGER !** Ne pas confondre un champ ou attribut (qui, en général, commence par une lettre minuscule) avec une propriété au sens du C# (qui commence toujours par une lettre majuscule). **Une propriété C# est un accesseur vers un champ**.

### Avantages

Voici un exemple d'utilisation des accesseurs définis précédemment.

```csharp
CompteBancaire comptePierre = new CompteBancaire("Pierre", 1000, "euros");

// utilisation des propriétés (accesseurs)
string titulaireCompte = comptePierre.Titulaire;  // en lecture (getter)
comptePierre.Solde = 500;                         // en écriture (setter)
comptePierre.Devise = "dollars";                  // en écriture (setter)
```

En remplaçant l'accès direct à un attribut par l'utilisation d'une méthode, un accesseur permet d'effectuer des contrôles supplémentaires : respect d'une plage de valeurs, accès en lecture uniquement, etc.

### Attributs en lecture seule

On observe dans l'exemple ci-dessus qu'on peut à nouveau modifier directement les données d'un compte. Pour interdire ces modifications tout en permettant de lire les informations d'un compte, il suffit de supprimer les accesseurs en écriture (*setters*).

```csharp
public class CompteBancaire
{
    private string titulaire;
    private double solde;
    private string devise;

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

    // ...
```

A présent, l'accès aux champs est toujours possible, mais toute tentative de modification des données sera refusée.

```csharp
CompteBancaire comptePierre = new CompteBancaire("Pierre", 1000, "euros");

string titulaireCompte = comptePierre.Titulaire;  // OK : le getter existe
comptePierre.Solde = 500;                         // Erreur : pas de setter
comptePierre.Devise = "dollars";                  // Erreur : pas de setter
```

## Héritage

L'héritage est l'un des mécanismes fondamentaux de la POO. Il permet de créer des classes à partir de classes déjà existantes. Nous allons nous contenter d'une introduction à ce vaste sujet.

### Exemple d'utilisation

Supposons maintenant que nous ayons à gérer un nouveau type de compte : le compte épargne. Comme un compte classique, un compte épargne possède un titulaire, un solde et une devise. Sa spécificité est qu'il permet d'appliquer des intérêts à l'argent déposé sur le compte.

Bien sûr, il serait possible de concevoir une classe `CompteEpargne` totalement distincte de la classe `CompteBancaire`. Cependant, on constate qu'un compte épargne possède toutes les caractéristiques d'un compte bancaire, ainsi que des caractéristiques spécifiques. Nous allons donc définir un compte épargne par **héritage** de la définition d’un compte bancaire.

```csharp
public class CompteEpargne : CompteBancaire
{
    private double tauxInteret;

    public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret) : base(leTitulaire, soldeInitial, laDevise)
    // appel du constructeur de la classe CompteBancaire
    // le mot-clé "base" permet d'accéder à la classe parente
    {
        tauxInteret = leTauxInteret;
    }

    // Calcule et ajoute les intérêts au solde du compte
    public void AjouterInterets()
    {
        // ... (détaillé plus bas)
    }
}
```

La syntaxe de déclaration `class CompteEpargne : CompteBancaire` indique que la classe `CompteEpargne` hérite de la classe `CompteBancaire`.

**REMARQUE** : d'autres langages comme Java ou PHP utilisent le mot-clé ``extends`` plutôt que le symbole ``:`` pour indiquer une relation d'héritage entre deux classes.

On observe que le constructeur de `CompteEpargne` fait appel au constructeur de `CompteBancaire` afin d'initialiser ses attributs, en utilisant le mot-clé `base` qui désigne la classe parente. Il initialise également l'attribut `tauxInteret` défini dans `CompteEpargne`.

### Représentation graphique

Le formalisme graphique UML décrit la relation d'héritage entre deux classes par une **flèche pleine** allant de la classe dérivée à la classe de base (les propriétés C# de `CompteBancaire` ont été masquées afin d'alléger le diagramme).

![Diagramme de classes UML](../images/uml_compte_epargne_1.jpg)

Définition
----------

**DEFINITION** : **l'héritage** est un mécanisme objet qui consiste à définir une classe à partir d'une classe existante. Une classe qui hérite d'une autre classe possède les caractéristiques de la classe initiale et peut définir ses propres éléments.

La nouvelle classe (ou classe **dérivée**) correspond à une **spécialisation** de la classe de base (appelée classe **parente** ou **superclasse**). On dit que l'héritage crée une relation de type **est un** entre les classes. Dans notre exemple, un compte épargne *est un* type particulier de compte bancaire.

**ATTENTION** : le constructeur d'une classe dérivée doit obligatoirement faire appel au constructeur de la classe parente lorsque celui-ci prend des paramètres. C'est le cas dans notre exemple.

### Avantages

Grâce à la relation d'héritage, un objet de la classe `CompteEpargne` peut utiliser les fonctionnalités de la classe `CompteBancaire` sans avoir à les redéfinir. On peut donc débiter ou créditer un compte épargne exactement comme un compte bancaire.

```csharp
double tauxInteret = 0.05;  // taux d'intérêt : 5%

// déclaration et instanciation d'un nouveau compte épargne
CompteEpargne comptePaul = new CompteEpargne("Paul", 0, "dollars", tauxInteret);

// appel des méthodes de CompteBancaire sur le compte épargne
comptePaul.Debiter(1000);
comptePaul.Crediter(1500);
Console.WriteLine(comptePaul.Decrire());
```

Par contre, le calcul des intérêts (méthode `AjouterInterets`) ne peut se faire que sur un objet de la classe `CompteEpargne`. L'héritage est une relation *unidirectionnelle*.

```csharp
CompteEpargne comptePaul = new CompteEpargne("Paul", 0, "dollars", 0.05);
CompteBancaire comptePierre = new CompteBancaire("Pierre", 100, "euros");

// OK : comptePaul est un compte épargne
comptePaul.AjouterInterets();

// Erreur : comptePierre est un compte bancaire, pas un compte épargne
comptePierre.AjouterInterets();
```

Grâce à l'héritage, il est possible de réutiliser les fonctionnalités d'une classe existante en la spécialisant. Il est également possible de spécialiser une classe dérivée.

On voit bien tous les avantages que l'héritage peut apporter : gain de temps de développement, amélioration de la qualité du code, création de hiérarchies de classes reflétant précisément le domaine d'étude, etc.

### Héritage et encapsulation

Nous avons volontairement laissé de côté un point délicat. La méthode `AjouterInterets` de la classe `CompteEpargne`, qui doit ajouter les intérêts au solde, n'est pas encore définie. En voici une première version.

```csharp
public class CompteEpargne : CompteBancaire
{
    // ...

    public void AjouterInterets()
    {
        // calcul des intérêts sur le solde
        double interets = solde * tauxInteret;
        // ajout des intérêts au solde
        solde += interets;
    }
}
```

Cependant, le compilateur nous signale l'erreur suivante.

![Erreur de compilation](../images/erreur_heritage_encapsulation.jpg)

Dans cet exemple, la classe dérivée `CompteEpargne` tente d'accéder à l'attribut `solde` qui appartient à la classe de base `CompteBancaire`. Cependant, cet attribut est défini avec le niveau de visibilité `private` ! Cela signifie qu'il n'est utilisable que dans la classe où il est défini, et non dans les classes dérivées.

Pour interdire l'accès à un élément (attribut, propriété C# ou méthode) depuis l'extérieur tout en permettant son utilisation par une classe dérivée, il faut associer à cet élément un niveau de visibilité intermédiaire : `protected`.

```csharp
public class CompteBancaire
{
    private string titulaire;
    protected double solde;   // attribut protégé
    private string devise;

    // ...
```

Une autre solution à ce problème consiste à laisser le champ `solde` privé et à définir un accesseur *protégé* pour modifier le solde depuis les méthodes de la classe `CompteEpargne`.

```csharp
public class CompteBancaire
{
    private string titulaire;
    private double solde;
    private string devise;

    // ...

    public double Solde
    {
        get { return solde; }             // accesseur public pour la lecture
        protected set { solde = value; }  // mutateur protégé pour la modification
    }

    // ...
```

Bien entendu, il faut alors utiliser le mutateur `Solde` et non plus l'attribut `solde` pour accéder au solde depuis la classe dérivée.

```csharp
public class CompteEpargne : CompteBancaire
{
    // ...

    public void AjouterInterets()
    {
        // utilisation du mutateur Solde pour accéder au solde du compte
        double interets = Solde * tauxInteret;
        Solde += interets;
    }
}
```

Le tableau ci-dessous rassemble les trois niveaux de visibilité utilisables.

Visibilité | Classe| Classes dérivées | Extérieur
-----------|:-----:|:----------------:|:--------:
`public` | X | X | X
`protected` | X | X |
`private` | X ||

