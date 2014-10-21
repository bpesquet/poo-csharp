Première approche de la POO
===========================

La notion d'objet
-----------------

Quand on utilise la POO, on cherche à représenter le domaine étudié sous la forme d'objets. C'est la phase de **modélisation orientée objet**.

{{% definition %}}
Un **objet** est une entité qui représente (*modélise*) un élément du domaine étudié : une voiture, un compte bancaire, un nombre complexe, une facture, etc.
{{% /definition %}}

Objet = état + actions
----------------------

Cette équation signifie qu'un objet rassemble à la fois :

* des **informations** (ou données) qui le caractérisent.
* des **actions** (ou traitements) qu'on peut exercer sur lui.

Imaginons qu'on souhaite modéliser des comptes bancaires pour un logiciel de gestion. On commence par réfléchir à ce qui caractérise un compte bancaire, puis on classe ces éléments en deux catégories :

* les informations liées à un compte bancaire.
* les actions réalisables sur un compte bancaire.

En première approche, on peut considérer qu'un compte bancaire est caractérisé par un **titulaire**, un **solde** (le montant disponible sur le compte) et utilise une certaine **devise** (euros, dollars, etc). Les actions réalisables sur un compte sont le dépôt d'argent (**crédit**) et le retrait (**débit**).

On peut regrouper les caractéristiques de notre objet "compte bancaire"
dans ce tableau.

Informations | Actions
-------------|--------
titulaire, solde, devise | créditer, débiter

{{% definition %}}
Un **objet** se compose **d'informations** et **d'actions**. Les actions utilisent (et parfois modifient) les informations de l'objet.
{{% /definition %}}

* L'ensemble des informations d'un objet donné est appelée son **état**.
* L'ensemble des actions applicables à un objet représente son **comportement**.

{{% remark %}}
Les actions associées à un objet s'expriment généralement sous la forme de verbes à l'infinitif (*créditer*, *débiter*).
{{% /remark %}}

A un instant donné, l'état d'un objet "compte bancaire" sera constitué par les valeurs de son titulaire, son solde et sa devise. L'état de l'objet "compte bancaire de Paul" sera, sauf exception, différent de l'état de l'objet "compte bancaire de Pierre".

La notion de classe
-------------------

Nous venons de voir que l'on pouvait représenter un compte bancaire sous la forme d'un objet. Imaginons que nous voulions gérer les différents comptes d'une banque. Chaque compte aura son propre titulaire, son solde particulier et sa devise. Mais tous les comptes auront un titulaire, un solde et une devise, et permettront d'effectuer les mêmes opérations de débit/crédit. Chaque objet "compte bancaire" sera construit sur le même modèle : ce modèle est appelée une **classe**.

{{% definition %}}
Une **classe** est un **modèle d'objet**. C'est un nouveau type créé par le programmeur et qui sert de modèle pour tous les objets de cette classe. Une classe spécifie les informations et les actions qu'auront en commun tous les objets créés à partir d'elle.
{{% /definition %}}

Le compte en banque appartenant à Jean, dont le solde est de 450 euros, est un compte bancaire particulier. Il s'agit d'un objet de la classe "compte bancaire". En utilisant le vocabulaire de la POO, on dit que l'objet "compte bancaire de Jean" est une **instance** de la classe "compte bancaire".

{{% warning %}}
Ne pas confondre **objet** et **classe**. Une classe est un type abstrait (exemple : un compte bancaire en général), un objet est un exemplaire concret d'une classe (exemple : le compte bancaire de Jean).
{{% /warning %}}

Il y a le même rapport entre un objet et sa classe qu'entre une variable et son type. Un objet est une variable particulière dont le type est une classe.

Représentation graphique
------------------------

Afin de faciliter la communication entre programmeurs utilisant des langages orientés objet différents, il existe un standard de représentation graphique d'une classe. Ce standard fait partie de la norme UML (*Unified Modeling Language*). On parle de **diagramme de classe**.

Voici la représentation de notre classe "compte bancaire" réalisée par Visual Studio.

{{% image src="uml_compte_bancaire_1.jpg" class="centered" %}}

Voici la même classe représentée sous la forme d'un diagramme conforme au standard UML.

{{% image src="uml_compte_bancaire_3.jpg" class="centered" %}}

Quel que soit l'outil utilisé, on observe que la classe est décomposée en deux parties :

* les **champs**, qui correspondent aux informations de la classe : *devise*, *solde* et *titulaire*.
* les **méthodes**, qui correspondent aux actions réalisables: *créditer*, *débiter* et *décrire*.

{{% definition %}}
Une **méthode** représente une action réalisable sur un objet de la classe.
{{% /definition %}}

En résumé
---------

* La POO consiste à programmer en utilisant des **objets**.
* Un objet modélise un élément du domaine étudié (exemples : un compte bancaire, une voiture, un satellite, etc).
* Un objet est une **instance** d'une **classe**. Une classe est un type abstrait, un objet est un exemplaire concret de cette classe.
* Une classe regroupe des **informations** et des **actions**.
* Les informations sont stockées sous la forme de **champs**. Ils décrivent ce que savent les objets sur eux-mêmes, leur **état**.
* Les actions réalisables sur un objet sont représentés par des **méthodes**. Elles expriment ce que les objets peuvent faire, leur **comportement**.

Les informations stockées par un objet peuvent être appelées **champs**, **attributs** ou encore **propriétés**. Ce dernier terme est ambigû en C# (TODO).
