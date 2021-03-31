using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinkDispenser
{
    class Program
    {
 
        private static void Init()
        {
            // MOCK OBJECTS FOR THE EXERCISE
            RessourceManage ressourceManage = new RessourceManage();

            MilkCafe milkCafe =  MilkCafe.GetInstance();
            ExpressoCafe expressoCafe = ExpressoCafe.GetInstance();
            Cappuccino cappuccino = Cappuccino.GetInstance();


            //int numberMilkCafe = ressourceManage.getPossibleNumberOfDrink(milkCafe);
            //int numberExpressoCafe = ressourceManage.getPossibleNumberOfDrink(expressoCafe);


            Distributor.Stock.Add(expressoCafe);
            Distributor.Stock.Add(milkCafe);
            Distributor.Stock.Add(cappuccino);

        }

        static void Main(string[] args)
        {
            Init();

            Distributor.Disp.Run(); 
        }
    }
}