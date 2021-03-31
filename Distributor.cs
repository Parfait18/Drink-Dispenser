using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkDispenser
{
    class Distributor
    {


        static List<Drink> stock = new List<Drink>();

        private static double gain;

        // A money collector
        private static MoneyCollector mc = new MoneyCollector();
    
        public static List<Drink> Stock { get => stock; set => stock = value; }

        public static double Gain { get => gain; set => gain = value; }
        public static MoneyCollector Collector { get => mc; }


       /* public void Distributor()
        {
            Gain = 0;
        }*/
        private static double CalculateGain(double drinkPrice)
        {
            return Gain += drinkPrice;
        }
        public static void ResetMoneyCollector()
        {
           Gain = CalculateGain(Collector.GainCollect);
           Display.ShowGain();
           mc = new MoneyCollector();      
           
        }

        // A display
        static Display disp = new Display();
        public static Display Disp { get => disp; }

    }
}
