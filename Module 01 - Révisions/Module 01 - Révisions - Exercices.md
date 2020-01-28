# Module 01 - Révisions

Pour chaque exercice, posez-vous les questions suivantes :

1. Quels sont les paramètres et leurs types
2. Choisissez un bon nom de fonctions
3. Choisissez de bons noms de paramètres
4. Écrivez des tests unitaires

## Exercice 2

Écrivez une fonction qui prend deux entiers en paramètres et qui renvoi la somme de ces deux entiers.

## Exercie 3

Écrivez une fonction qui prend deux entiers en paramètres et qui renvoi l’entier le plus petit.

## Exercice 4

Écrivez une fonction qui prend un tableau de réels et qui renvoie la somme des valeurs de ce tableau.

## Exercice 5

Écrivez une fonction qui prend un tableau de réels et qui renvoie le minimum des valeurs de ce tableau.

## Exercice 6

Écrivez une fonction qui prend un tableau de réels et qui renvoie le maximum des valeurs de ce tableau.

## Exercice 7

Écrivez une fonction qui prend un tableau de réels et qui renvoie la moyenne des valeurs de ce tableau.

## Exercice 8

Écrivez une fonction qui prend en paramètres un tableau d’entiers et une valeur à chercher. Cette fonction renvoie vrai si la valeur est trouvée, faux sinon.

## Exercice 9

Écrivez une fonction qui prend en paramètres un tableau d’entiers. Cette fonction renvoie vrai si le tableau est trié en ordre croissant, faux sinon.

## Exercice 10

Écrivez une fonction qui prend en paramètres deux tableaux d’entiers. Cette fonction renvoie vrai si les deux tableaux sont égaux, faux sinon.

## Exercice 11

Écrivez une fonction qui prend en paramètres un tableau d’entiers et qui renvoie un nouveau tableau dont les valeurs sont rangées dans l’ordre inverse. ({1, 4, 3} => {3, 4, 1}).

## Exercice 12

Écrivez une fonction qui prend en paramètres un tableau d’entiers, deux indices et qui échange les valeurs présentes aux indices donnés.

## Exercice 13

Écrivez une fonction qui prend en paramètres un tableau de réels, un indice et une nouvelle valeur à insérer dans le tableau. La fonction doit insérer la nouvelle valeur à l’indice reçu en paramètre, en décalant les éléments existants. Le dernier élément sera perdu.

Par exemple :

- Avec le tableau « double tab[6] = {15, 25, -3, 6, 27, 13};  »
- Après avoir exécuter « Inserer(tab, 2, -99); » le tableau devrait contenir : {15, 25, -99, -3, 6, 27}

<details>
    <summary>Indice #1</summary>
Avant d'insérer la valeur dans le tableau, décalez les valeurs d'une case vers la droite.
</details>

## Exercice 14

Écrivez une fonction qui prend en paramètres deux tableaux de même capacité et qui renvoie un nouveau tableau dont chaque case est la somme des valeurs correspondantes dans les deux tableaux.

<details>
    <summary>Indice #1</summary>
Faut-il créer un nouveau tableau ?
</details>

## Exercice 15

Vous devez gérer une liste d'articles.

Un article est défini par :

- un numéro de référence
- une date de référencement (Utilisez le type DateTime)
- une description

Vous devez proposer un menu permettant d'ajouter un article, de les afficher, d'en supprimer et de recherche un article par numéro de référence ou par la présence d'une sous-chaine dans la description (Utilisez la méthode Contains pour le valider).

Les articles doivent être triés par ordre croissant de numéro d'article.

Posez-vous la question de quels algorithmes vous allez utiliser pour le tri et pour la recherche. Par quoi pourriez-vous remplacer le tri dans la situation actuelle ?

<details>
    <summary>Indice #1</summary>
Revisitez les derniers exercices sur les menus et les exercices ramassés.
</details>

<details>
    <summary>Indice #2</summary>
Relisez vos notes sur les différences entre les algorithmes de recherche (itérative et dichotomique).
</details>

<details>
    <summary>Indice #3</summary>
Relisez vos notes sur les tris. Est-ce que tous les tris se valent ?
</details>

<details>
    <summary>Indice #4</summary>
Recherchez le fonctionnement de la méthode "Insert" des listes de C#.
</details>
