Ceci est le Project C# de PPAR est un distributeur qui distribue les boissons chaudes suivantes :
• Le café expresso coute 1€50 et nécessite 18g de café en grain et 50ml d'eau
• Le café au lait coute 2€50 et nécessite 24g de café en grain et 200ml d'eau et 150ml de lait
• et le cappuccino coute 3€ et nécessite 24g de café en grain et 250ml d'eau et 50ml de lait
Pour préparer une commande le distributeur contient initialement :
• 1L d'eau
• 500g de café en grain
• 0.5L de lait
Le distributeur contient une caisse dans laquelle les pièces tombent.
Un client peut insérer dans le distributeur des pièces de :
1c, 5c, 10c, 25c, 50c, 1€
Si les pièces insérées ne correspondent pas au prix de la commande, l'appareil l'indique au client (il peut aussi
indiquer le montant à compléter) et retourne les pièces insérées.
L'appareil est capable de rendre la monnaie si on insère plus de pièces qu'il ne faut.
Le distributeur doit également être en mesure d'afficher à tout instant un rapport indiquant le montant dans la caisse
et les ressources disponibles.
Quand les ressources sont insuffisantes l'appareil l'indique et rend les pièces insérées. Dans ce cas il doit être
réalimenté en ressources manquantes.

Nous avec d'abords 
 *une classe Abstraite Drink dont Dérive les classes MilkCafe(Café au lait ), Cappuccino et EspressoCafe qui sont les boissons de notre distributeur
 *une classe MoneyCollector pour recupeérer les différentes les piêces etfaire les différentes calcul qui y sont liés
 *une classe Display qui a pour objectif d'afficher les informations a l'utilisateur et d'interagir avec ce dernier
 *une classe RessourceManage qui permet de gérer les ressources lors de la fabrication des boissons et de voir si une commande est possible avec les ressources disponibles
 *une derniere classe Distributor qui represente vraiment notre machine. Elle est le chef d'orchestre qui utilise les autes classes pour simuler le fonctionnement du systeme
 *Une classe program qui est la classe qui run le projet et fait l'appel aux autres classes de manières automatique.