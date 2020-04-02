# Module 08 - Héritage

## Exercice 01 - Comptes bancaires

Nous allons faire un premier exercice d’héritage en représentant trois types de comptes bancaires.

Un **compte général** possède un solde, ainsi que deux opérations : déposer et retirer. On ajoute à cela une fonctionnalité pour afficher le solde à l’écran.

Un **compte à intérêt** possède aussi un solde, mais il a les particularités suivantes :

- Aucun solde négatif n’est permis,
- À chaque transaction, on enlève 0.25 $ du solde, pour les frais.
  
Un **compte à marge de crédit** possède aussi un solde, mais avec les particularités suivantes :

- Un solde négatif est permis,
- À chaque transaction, on enlève 0.25 $ du solde, pour les frais,
- Si le solde est négatif pendant 10 opérations, on déduit 5% du compte, en guise d’intérêt.

Codez et faites les tests unitaires des classes demandées.

Faites un main pour manipuler les différentes classes et tester la compatibilité des types à travers différents types de déclarations et d'affectations (exemple affecter un compte intérêt à un compte général et inversement).

## Exercice 2 - Animaux

Vous devez reproduire la hiérarchie suivante, à l’aide de classes.

Dans la nature, tous les animaux peuvent respirer et se déplacer, mais de manières différentes.

Pour nos besoins, un animal est identifié par un numéro d’identification qui apparaît sur un collier ou un tag apposé sur lui. Ce numéro peut être arbitrairement long.

Dans cet exercice, on vous demande de représenter deux types d’animaux : les mammifères et les poissons.

Lorsqu’un mammifère respire, il ouvre ses poumons, alors que pour un poisson, il ouvre ses branchies.

Lorsqu’un mammifère se déplace, il marche, alors que pour un poisson, il nage.

Pour réaliser ces comportements dans votre programme, faites un affichage dans la console. Voici un exemple :

```console
Le poisson #0191902923 nage.
Le mammifère #15246 marche.
Le poisson #12873 nage.
...
```

Codez et faites les tests unitaires des classes demandées.

Faites un main où vous créez plusieurs mammifères et plusieurs poissons.

Demander à l’utilisateur quel comportement il veut demander aux animaux : s’il veut les voir respirer, faites-les tous respirer, s’il veut les voir se déplacer, faites-les tous se déplacer.

## Exercice 03 - Mineur

Reprenez votre classe Personne, avec le nom et l’âge. Ajoutez un nouveau type de personne : un mineur.

La particularité d’un mineur est que son âge doit toujours être entre 0 et 17, tous deux inclus.

Vous devez vérifier et lancer des exceptions lorsqu’on ne respecte pas cette contrainte.

Codez et faites les tests unitaires des classes demandées.
