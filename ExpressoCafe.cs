using DrinkDispenser;
using System;

public class ExpressoCafe : Drink
{
    /*
     * La Classe correspondant au Cafe esspresso qui dérive de la classe Drink
     */
    public ExpressoCafe()
	{
        //initialisation du prix et des ingrédiens pour faire le cafe esspresso
        Price = 1.50;
        Qut_water = this.ConvertToLiter(50);
        Qut_grain_cafe = 18;
        Qut_milk = 0;
    }

    private static ExpressoCafe expresso_cafe;

    //fonction qui permet d'avoir une instance de cafe esspresso
    public static ExpressoCafe GetInstance()
    {
        if (expresso_cafe == null) expresso_cafe = new ExpressoCafe(); return expresso_cafe;
    }
}
