# Injection de dépendances

## Exercice 1 - Journalisation

Reprenez l'interface "Journalisation".

Écrivez les classes suivantes :

- "JournalisationConsole" : affichage chaque message sur une nouvelle ligne
- "JournalisationConsoleDateBW" : affiche chaque message en blanc précédé par la date et l'heure
- "JournalisationConsoleDateHeureVert" : affiche chaque message en blanc précédé par la date et l'heure écrites en noir sur un fond vert.

Écrivez la classe "De1" qui permet de simuler l'utilisation d'un dé à n faces. Afin d'obtenir une valeur, le développeur appelle la méthode "Lancer" qui renvoie la valeur tirée.

Chaque appel à cette méthode doit être journalisé.

L'objet de journalisation doit être injecté par le constructeur.

Écrivez la classe "De2Attribute" sur le même principe que "De1" à la différence que l'objet de journalisation doit être injecté par une propriété en suivant la méthode "[Dependancy] Attribute" décrite sur le site https://www.tutorialsteacher.com/ioc/property-injection-using-unity-container.

Écrivez la classe "De3Runtime" sur le même principe que "De1" à la différence que l'objet de journalisation doit être injecté par une propriété en suivant la méthode "run-time" décrite sur le site https://www.tutorialsteacher.com/ioc/property-injection-using-unity-container.
