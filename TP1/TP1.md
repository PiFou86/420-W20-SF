# Programmation orientée objet - TP 1

## Consignes et modalités de remise

- Vous avez le droit à tous vos documents personnels.
- La correction tient compte :
  - Des algorithmes utilisés
  - Du respect minimal de l’encapsulation
  - De l’écriture des tests unitaires demandés
  - Des préconditions
  - De la cohérence et propreté des diagrammes
  - Du respect des nomenclatures (Majuscule, p_, m_, this, etc.)
  - Utilisation des abstractions
  - Respect des principes et notions vus en cours
- Les remises se feront par LÉA dans la section Travaux dans une archive au format ZIP
- Il y a une remise à effectuer à la fin de la période de cours et une autre, si vous désirez, le soir de votre prochain cours
- Le fichier de remise ne doit pas contenir de version binaire (pas de dossier bin ou obj)

## Questionnaire, on concurrence Google forms !

Vous devez créer un programme permettant de poser des questionnaires. Un questionnaire est composé d'un ensemble de questions. Les questions sont des types suivants :

- Question avec une réponse de type décimal attendue
- Question avec une réponse de type mot attendu
- Question avec sélection d'un choix parmi une liste
- Question avec sélection de choix (plus qu'un) parmi une liste

Chaque question à une certaine valeur de points. L'évaluation par question est binaire, soit le candidat a la réponse attendue et il a tous les points, soit il ne l'a pas ou l'a partiellement et n'a aucun point.

Toutes les questions d'un questionnaire sont posées dans un ordre aléatoire. Le candidat ne peut pas retourner sur une question déjà posée (le but est de faciliter le code !).

## Travail à réaliser (97,5%) :

- Créez la solution Visual Studio qui suit la nomenclature suivante : « H2020_TP1_Questionnaires_\<NumeroMatricule\> » (2,5%)
- Faites le diagramme de classes (10%)
- Codez vos classes (50%)
- Proposez un exemple de questionnaire (10%). Le questionnaire doit avoir au moins une question de chaque type.
- Écrivez un programme qui demande le nom d'un candidat, lui pose l'ensemble des questions du questionnaire et lui affiche son score sur le total du questionnaire ainsi que son score en pourcentage (5%)
- Testez les questions des types « valeur décimale », « sélection de choix (plus qu’un) parmi une liste » (20%)

## Remise (2,5%) :

- Nettoyez la solution (supprimer les fichiers qui ne font pas partis du code source)
- Compressez l’ensemble des fichiers de votre solution Visual Studio. Le fichier doit se nommer « H2020_TP1_Questionnaires_\<NumeroMatricule\>.zip »
- Remettez le fichier sur Léa
- Validez la remise en testant l’archive transmise sur Léa
