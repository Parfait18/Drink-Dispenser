using DrinkDispenser;
using System;

public class Cappuccino :Drink 
{
    /*
    * La Classe correspondant au Cappuccino qui dérive de la classe Drink
    */
    private Cappuccino()
     {
        //initialisation du prix et des ingrédiens pour faire le cafe cappuccino
           Price = 3;
           Qut_grain_cafe = 24;
           Qut_water = this.ConvertToLiter(250);
           Qut_milk = this.ConvertToLiter(50);
     }
     private static Cappuccino cappuccino;

    //fonction qui permet d'avoir une instance de cafe cappuccino
    public static Cappuccino GetInstance()
     {

        if (cappuccino == null) cappuccino = new Cappuccino(); return cappuccino;
     }
}

  