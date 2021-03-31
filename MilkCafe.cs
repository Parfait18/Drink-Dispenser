using DrinkDispenser;
using System;
using System.Collections.Generic;
using System.Text;

public  class MilkCafe : Drink
{ 
    /*
     * La Classe correspondant au Cafe au Lait qui dérive de la classe Drink
     */
     private MilkCafe() {
        
           //initialisation du prix et des ingrédiens pour faire le café au lait
            Price = 2.50;
            Qut_grain_cafe = 24;
            Qut_water = this.ConvertToLiter(200);
            Qut_milk = this.ConvertToLiter(150);
     }
     
     
     private static MilkCafe milk_cafe;

    //fonction qui permet d'avoir une instance de café au lait
    public static MilkCafe GetInstance() {

            if (milk_cafe == null)  milk_cafe = new MilkCafe(); return milk_cafe;
    }
}

