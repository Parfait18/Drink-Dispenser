using System.Linq;
using System;
using System.Collections.Generic;
using DrinkDispenser;

public class RessourceManage
{
    /*
     * La Classe qui permet de gérer les ressources (eau, grain de café et quantité de lait)
     */
    private static double total_water;

    private static double total_grain_cafe;

    private static  double total_milk;

    public RessourceManage()
    {
        total_water = 1;

        total_grain_cafe = 500;

        total_milk = 0.5;
    }

    public static double Total_water { get => total_water; set => total_water = value; }
    public static double Total_grain_cafe { get => total_grain_cafe; set => total_grain_cafe = value; }
    public static double Total_milk { get => total_milk; set => total_milk = value; }

   

    public  int GetPossibleNumberOfDrink(Drink drink)
    {
        int a = 0; int b = 0; int c = 0;
        if(drink.Qut_water != 0){  a = Convert.ToInt32(Total_water / drink.Qut_water);  }

        if ( drink.Qut_grain_cafe != 0) { b = Convert.ToInt32(Total_grain_cafe / drink.Qut_grain_cafe); }
      
        if (drink.Qut_milk != 0){ c = Convert.ToInt32(Total_milk / drink.Qut_milk); }
       
        return  this.GetMinimum(a,b,c);
    }

    private int GetMinimum(int a, int b, int c)
    {
        List<int> numberList = new List<int> { a , b ,c};
     
      numberList.RemoveAll(p =>p == 0);

      int min = numberList.Min();

        return min;
    }

    public void UpdateRessource(Drink drink)
    {
        Total_water = Total_water - drink.Qut_water;
        Total_grain_cafe = Total_grain_cafe - drink.Qut_grain_cafe;
        Total_milk = Total_milk- drink.Qut_milk;

       // return this;
    }

    public bool CanCommand(Drink drink) {

        if (Total_water >= drink.Qut_water && Total_grain_cafe >= drink.Qut_grain_cafe && Total_milk >= drink.Qut_milk)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void GetRessource()
    {
        Console.WriteLine();
        Console.WriteLine("     L'eau restant :" + Total_water+"L");
        Console.WriteLine();
        Console.WriteLine("     Grain de café restant  :" + Total_grain_cafe+"g");
        Console.WriteLine();
        Console.WriteLine("     Quantité de Lait restant :" + Total_milk+"L");
        Console.WriteLine();
    }
}

    