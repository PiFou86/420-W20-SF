# Exercice récapitulatif 01 - Soccer

## Mise en situation

Pour cet examen, nous allons simuler la gestion de la coupe du monde de soccer féminin 2019.

Vous avez une base de code : si le projet ne s’importe pas, vous pouvez simplement créer votre projet et copier les classes fournies dans le répertoire POOI_Exercices_Supp_Soccer.

## Analyse du code existant

Faites le diagramme de classes sur papier de l’existant.

Le diagramme doit faire apparaître : les classes, les relations de type héritage, composition/agrégation, les méthodes publiques avec leurs paramètres. Les membres privés et protégés ne sont pas demandés.

## Modifications le diagramme existant

Modifiez le diagramme de classes pour incorporer les entités et fonctionnalités suivantes :

- Autre personnel d’équipe :
  - Entraîneur assistant : un entraîneur assistant est un entraîneur. Il joue le même rôle que l'entraîneur principal mais l’assiste.
- Ajout de fonctionnalités aux membres d’équipe : chaque membre d’équipe doit pouvoir se présenter. Pour cela, il renvoie son nom, son numéro de passeport ainsi que son rôle dans l’équipe
- Ajout de fonctionnalités aux personnels d’équipe
  - Un entraîneur, principal ou assistant, doit comporter une opération « entraîneur » qui renvoie la chaîne « J’entraîne »
  - La classe Tournoi doit comporter les opérations suivantes :
    - Rechercher l’ensemble des parties qui n’ont pas été jouées
    - Rechercher l’ensemble des parties qui ont été jouées
    - Rechercher l’ensemble des parties (jouées ou non) qui ont eu lieu ou auront lieu entre deux dates passées en paramètres. Si la date de fin est nulle, on considère qu’il n’y a pas de date de fin

## Implanter des classes

Ajoutez les classes ajoutées précédemment et les coder avec leurs fonctionnalités expliquées au point précédent.

Vous devez aussi coder la méthode privée « modifierStatistiques » de la classe « Tournoi ». Elle doit :

- Ajouter 3 points en cas de victoire de l’équipe courante
- Ajouter 1 point en cas de partie nulle
- Ajouter une partie au nombre de parties jouées
- Ajouter une partie au nombre de parties gagnées / nulles / perdues suivant le cas
- Ajouter le nombre de but marqués (buts pour) et pris (buts contre)

Les opérations de recherche de parties doivent être codées avec des streams et sans utiliser de boucle.

Modifiez la méthode « affecterScorePartieEtMAJStatistiques » pour qu’elle lève une exception du type « ScoreIncorrectException » à la place de l’exception « IllegalArgumentException » quand le score passé en paramètre est invalide.

## Testez

Faites des tests unitaires de la classe Tournoi pour les méthodes de recherche de parties ainsi que les méthodes qui modifient les statistiques.
