# Module 10 - Linq

## Introduction aux expressions lambda

Une expression lambda est une fonction anonyme, c’est-à-dire sans nom. En C#, elles permettent de créer des fonctions déléguées et des arbres d’expressions.

Ce qui suit est un exercice d’introduction à ce type d’expressions.

### Activité 1 - Une première expression lambda

Créez le projet C# nommé "POOI_Module10_ExperimentationsLINQ" de type "Application console" dans Visual studio.

Ajoutez les fichiers présents dans le répertoire src du répertoire courant du dépot git.

#### Exemple 1 - Une première expression lambda

1. Dans la classe "Programme", créer la méthode "Identite" comme suit :

```csharp
private static int Identite(int val)
{
    return val;
}
```

2. Dans la méthode principale, tester la séquence d’instructions suivante :

```csharp
    ObjectDumper.Write(Identite(10));
```

3. Qu’affiche le programme ?
4. Nous allons écrire une première expression lambda d’une ligne. Ajouter la séquence suivante dans le "Main" :

```csharp
// int => int
Func<int, int> fctIdentite_V01 = (int x) => x;
ObjectDumper.Write(fctIdentite_V01(10));
```

5. Valider que le programme affiche toujours la même chose. Ici nous retrouvons le paramètre x de type int. Ce qui est renvoyé ici se trouve après l’opérateur "=>", soit x.

#### Exercice 1 - Une première expression lambda

1. Écrire la méthode "Carre" qui prend un double en paramètre et qui renvoie le résultat de son carré (Question à se poser : quel type de retour ?) et la tester à l’aide de la méthode statique "Write" de la classe "ObjectDumper"
2. Écrire l’expression lambda équivalente et l’affecter à la variable fctCarre_V01. La tester à l’aide de la méthode statique "Write" de la classe "ObjectDumper"

### Activité 2 - On joue avec les paramètres

#### Exemple 2 - On joue avec les paramètres

Nous allons ajouter un deuxième paramètre. Mettre les instructions du "Main" en commentaire. Ajouter la séquence suivante dans le "Main" :

```csharp
// int, int => int
Func<int, int, int> fctAddition_V01 = (int x, int y) => x + y;
ObjectDumper.Write(fctAddition_V01(10, 20));
```

Qu’affiche le programme ?

#### Exercice 2 - On joue avec les paramètres

1. Écrire la méthode "Multiplication" qui prend deux int en paramètres et qui renvoie le résultat de leur multiplication (Question à se poser : quel type de retour ?) et la tester à l’aide de la méthode statique Write de la classe ObjectDumper
2. Écrire l’expression lambda équivalente et l’affecter à la variable fctMultiplication_V01. La tester à l’aide de la méthode statique Write de la classe ObjectDumper

### Activité 3 - Simplification d'écriture

#### Exemple 3 - Simplification d'écriture

Généralement, le typage dans les paramètres n’est pas obligatoire car le compilateur peut le déduire.

Tester les deux séquences suivantes :

```csharp
// int => int
Func<int, int> fctIdentite_V02 = (x) => x;
ObjectDumper.Write(fctIdentite_V02(10));
// int, int => int
Func<int, int, int> fctAddition_V02 = (x, y) => x + y;
ObjectDumper.Write(fctAddition_V02(10, 20));
```

#### Exercice 3 - Simplification d'écriture

1. Reprendre les expressions lambda précédentes et enlever le type dans les paramètres comme dans l’exemple. Affecter ces expressions à des variables suffixées par "_V2" en lieu et place de "_V1".
2. Valider que le tout fonctionne toujours.

## Introduction à Linq

LINQ (Language-Integrated Query) est un langage intégré dans les langages du cadriciel .Net dont dans le langage C#. Ce langage est dédié à l'interrogation de collections. Il est très proche du langage SQL. LINQ peut aussi interroger des bases de données comme vous pourrez le voir en cours de bases de données avancées et en POOII.

Durant la compilation d'un code C#, LINQ est traduit en appels de méthodes d'extension. Ces méthodes sont aussi accessibles pour vous. Vous aurez donc le choix entre la syntaxe LINQ ou l'appel de ces méthodes.

Dans cet exercice, vous allez pouvoir explorer la syntaxe du langage LINQ en manipulant des collections d’objets.

1. Au niveau de ce répertoire, vous trouverez la classe "Product" qui représente les informations d’un produit :
  
- Category : string
- ProductID : int
- ProductName : string
- UnitPrice : decimal
- UnitsInStock : int

2. La classe "DonneesLINQ" contient la méthode statique "CreateProductList". Cette méthode renvoie une liste de produits de type "Product" (List<Product>).

### Activité 1 - Filtrer une collection

#### Exemple 1 - Filtrer une collection

#### Syntaxe requête 1

1. Dans la classe "Programme", créer la méthode "ObtenirElement01_SyntaxeRequete_v01» comme suit :

```csharp
private static void ObtenirElement01_SyntaxeRequete_v01()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = from produit in produits
                    where produit.ProductID == 12
                    select produit;

    ObjectDumper.Write(resultat);
}
```

2. Dans la méthode principale, tester la méthode en l’appelant.
3.	Qu’affiche le programme ? Quel est le type de "resultat" ?

##### Syntaxe méthode 1

Dans la classe "Programme", créer la méthode "ObtenirElement01_SyntaxeMethode_v01" comme suit :

```csharp
private static void ObtenirElement01_SyntaxeMethode_v01()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = produits.Where(p => p.ProductID == 12);

    ObjectDumper.Write(resultat);
}
```

#### Exercice 1 - liste d’éléments

1. Écrire les méthodes "ObtenirSousListeCategorieCondiments_SyntaxeRequete_v01" et "ObtenirSousListeCategorieCondiments_SyntaxeMethode_v01" qui filtrent la collection en gardant seulement les produits dont la catégorie est "Condiments".
2. Écrire les méthodes "ObtenirSousListePrixSupp100_SyntaxeRequete_v01" et "ObtenirSousListePrixSupp100_SyntaxeMethode_v01" qui filtrent la collection en gardant seulement les produits dont le prix unitaire est supérieur à 100$.

### Activité 2 - Élément unique

#### Exemple 2 - Élément unique

1. Tester les méthodes suivantes :

```csharp
private static void ObtenirElement01_SyntaxeRequete_v02()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = (from produit in produits
                    where produit.ProductID == 12
                    select produit).SingleOrDefault();

    ObjectDumper.Write(resultat);
}
private static void ObtenirElement01_SyntaxeRequete_v02Bis()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = (from produit in produits
                    where produit.ProductID == 12
                    select produit).Single();

    ObjectDumper.Write(resultat);
}
private static void ObtenirElement01_SyntaxeMethode_v02()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = produits.Where(p => p.ProductID == 12).SingleOrDefault();

    ObjectDumper.Write(resultat);
}
private static void ObtenirElement01_SyntaxeMethode_v02Bis()
{
    var produits = DonneesLINQ.CreateProductList();
    var resultat = produits.Where(p => p.ProductID == 12).Single();

    ObjectDumper.Write(resultat);
}
```

2. La méthode d’extension "Single" spécifie que l’on s’attend à avoir un résultat unique. "SingleOrDefault" est similaire à "Single", à la différence que si aucun élément n’est trouvé, la valeur par défaut est renvoyée.

#### Exercice 2 - Élément unique

1. Écrire de nouvelles versions des quatre méthodes précédentes mais qui recherchent cette fois ci le produit identifié 666. Que se passe-t-il ? Qu’est ce qui est renvoyé ? Comment modifier le code si nécessaire ?
2. Écrire de nouvelles versions des quatre méthodes précédentes mais qui filtrent non plus sur l’identifiant du produit mais sur la catégorie "Condiments". Que se passe-t-il ? Est-ce normal ?

### Activité 3 - Projection

#### Exemple 3 : Projection

Tester les méthodes suivantes :

```csharp
private static void ObtenirListeNomsProduits_SyntaxeRequete_v01()
{
    var produits = DonneesLINQ.CreateProductList();

    var categories = from produit in produits
                        select produit.ProductName;

    ObjectDumper.Write(categories);
}

private static void ObtenirListeNomsProduits_SyntaxeMethode_v01()
{
    var produits = DonneesLINQ.CreateProductList();

    var categories = produits.Select(p => p.ProductName);

    ObjectDumper.Write(categories);
}
```

2. Que renvoie ces méthodes ? Quel est le type renvoyé ?

#### Exercice 3 - Projections

1. Écrire les méthodes "ObtenirListeCategories_SyntaxeRequete_v01" et "ObtenirListeCategories_SyntaxeMethode_v01" qui permettent d’obtenir seulement la liste des catégories de produits.
2. Que constatez-vous ?
3. Écrire deux nouvelles versions des méthodes précédentes. De la même façon que vous avez utilisé les méthodes d’extension "Single" et "SingleOrDefault", utiliser la méthode d’extension "Distinct".
4. Qu’observez-vous ?

### Activité 4 - Tri

#### Exemple 4 - Tri

Tester les méthodes suivantes :

```csharp
private static void ObtenirListeNomsProduitsOrdonee_SyntaxeRequete_v01()
{
    var produits = DonneesLINQ.CreateProductList();

    var categories = from produit in produits
                        orderby produit.ProductName
                        select produit.ProductName;

    ObjectDumper.Write(categories);
}

private static void ObtenirListeNomsProduitsOrdonnee_SyntaxeMethode_v01()
{
    var produits = DonneesLINQ.CreateProductList();

    //var categories = produits.Select(p => p.ProductName).OrderBy(c => c);
    var categories = produits.OrderBy(p => p.ProductName).Select(p => p.ProductName);

    ObjectDumper.Write(categories);
}
```

#### Exercice 4 - Tri

- Écrire les méthodes "ObtenirListeCategoriesOrdonee_SyntaxeRequete_v01" et "ObtenirListeCategoriesOrdonnee_SyntaxeMethode_v01" qui permettent de lister les catégories de produits tout en les ordonnant.
- Qu’observez-vous ?

## Aller plus loin

- ORM (lien entre vos classes et un SGBD) : https://entityframeworkcore.com/
- 101 exemples : https://linqsamples.com/
- Collection d'articles d'Andras Nemes : https://dotnetcodr.com/linq/