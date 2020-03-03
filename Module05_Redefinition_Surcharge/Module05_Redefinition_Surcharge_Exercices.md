# Module 05 - Redéfinition et surcharge

## Exercice 1 - Bibliothèque

Votre bibliothèque vous mandate afin de créer un programme pour gérer ses abonnements et ses prêts de livres.

### Contexte

Un abonné peut emprunter un maximum de 10 livres.

Les livres doivent être empruntés pour une durée maximum de 10 jours et peuvent être renouvellé une fois. Une pénalité de retard de 25 cents par jour est appliquée au retour du livre si celui ci est rendu en retard.

Un livre est caractérisé par :

- Un titre
- Une liste d'auteurs non vide
- Un ISBN (International Standard Book Number)
- Une référence interne unique (Ex. J47B6.ABC)

Un livre peut exister en plusieurs exemplaires. Dans ce cas, il aura les mêmes valeurs de titre, liste d'auteurs et ISBN mais une référence interne unique différente.

Un abonné est caractérisé par :

- Son nom
- Son prénom
- Un numéro de membre unique
- Une date de début d'abonnement

Le programme de gestion doit permettre :

- Gérer des prêts :
  - Rechercher les livres empruntés par un abonné
  - D'emprunter un livre si aucune pénalité n'est dûe (Il faut valider les livres en sa possession)
  - De renouveler un livre
  - De rendre un livre : le programme calcule la pénalité si nécessaire.
- Effectuer des recherches :
  - Rechercher des livres par :
    - Son ISBN
    - Un mot clef dans son titre
    - Sa référence unique
    - Par auteur

### Travail à effectuer

- Proposez un diagramme de classes et discutez en avec vos collègues
- Décidez d'un menu cohérent avec le sujet
- Écrivez le programme en testant les fonctions au fur et à mesure avec des tests unitaires
- Codez le menu final
