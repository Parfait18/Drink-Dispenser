using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkDispenser
{
    /*
     Ici Une classe abstrate pour garder toutes les boissons d'être d'un même type de base Drink */
    public abstract class Drink
    {

        //le prix de la boisson
        private double price;

        //quantité de l'eau de la boisson
        private double qut_water;

        //quantité de grain de café de la boisson
        private double qut_grain_cafe;

        //quantité de lait de la boisson
        private double qut_milk;

        //les accesseurs et setterus des différentes propriétés précédente
        public double Price { get => price; set => SetPrice(value); }
        public double Qut_water { get => qut_water; set => SetQutWater(value); }
        public double Qut_grain_cafe { get => qut_grain_cafe; set => SetQutGrainCafe(value); }

        public double Qut_milk { get => qut_milk; set => SetQutMilk(value); }

        //fonction qui permet de modifier la quantité de lait
        private void SetQutMilk(double value)
        {
            this.qut_milk = value;
        }


        //fonction qui permet de modifier la quantité de grain de cafe
        private void SetQutGrainCafe(double value)
        {
            this.qut_grain_cafe = value;
        }

        //fonction qui permet de modifier la quantité d'eau
        private void SetQutWater(double value)
        {
            this.qut_water = value;
        }

        //fonction qui permet d'actualiser la quantité de prix
        private void SetPrice(double value)
        {
            this.price = value;
        }

        //fonction qui permet de convertir une valeur de mL en litre (L)
        public double ConvertToLiter(double value)
        {
            return value/1000;
        }
    }
}
