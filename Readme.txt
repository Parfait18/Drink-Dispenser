Ceci est le Project C# de PPAR est un distributeur qui distribue les boissons chaudes suivantes :
� Le caf� expresso coute 1�50 et n�cessite 18g de caf� en grain et 50ml d'eau
� Le caf� au lait coute 2�50 et n�cessite 24g de caf� en grain et 200ml d'eau et 150ml de lait
� et le cappuccino coute 3� et n�cessite 24g de caf� en grain et 250ml d'eau et 50ml de lait
Pour pr�parer une commande le distributeur contient initialement :
� 1L d'eau
� 500g de caf� en grain
� 0.5L de lait
Le distributeur contient une caisse dans laquelle les pi�ces tombent.
Un client peut ins�rer dans le distributeur des pi�ces de :
1c, 5c, 10c, 25c, 50c, 1�
Si les pi�ces ins�r�es ne correspondent pas au prix de la commande, l'appareil l'indique au client (il peut aussi
indiquer le montant � compl�ter) et retourne les pi�ces ins�r�es.
L'appareil est capable de rendre la monnaie si on ins�re plus de pi�ces qu'il ne faut.
Le distributeur doit �galement �tre en mesure d'afficher � tout instant un rapport indiquant le montant dans la caisse
et les ressources disponibles.
Quand les ressources sont insuffisantes l'appareil l'indique et rend les pi�ces ins�r�es. Dans ce cas il doit �tre
r�aliment� en ressources manquantes.

Nous avec d'abords 
 *une classe Abstraite Drink dont D�rive les classes MilkCafe(Caf� au lait ), Cappuccino et EspressoCafe qui sont les boissons de notre distributeur
 *une classe MoneyCollector pour recupe�rer les diff�rentes les pi�ces etfaire les diff�rentes calcul qui y sont li�s
 *une classe Display qui a pour objectif d'afficher les informations a l'utilisateur et d'interagir avec ce dernier
 *une classe RessourceManage qui permet de g�rer les ressources lors de la fabrication des boissons et de voir si une commande est possible avec les ressources disponibles
 *une derniere classe Distributor qui represente vraiment notre machine. Elle est le chef d'orchestre qui utilise les autes classes pour simuler le fonctionnement du systeme
 *Une classe program qui est la classe qui run le projet et fait l'appel aux autres classes de mani�res automatique.