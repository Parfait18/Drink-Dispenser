using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkDispenser
{
    class Display
    {

        public static void ShowGain()
        {
            Console.WriteLine();
            Console.WriteLine("     Le gain de la machine est  " + Distributor.Gain/100+" euros ");
            Console.WriteLine();
        }
        public static void ShowDrinks(List<Drink> stock)
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
            foreach (Drink drink in stock)
            {
                Console.WriteLine();
                Console.Write("         |"+ stock.IndexOf(drink)+"| *** "+ drink.GetType().Name +" , price: " + drink.Price + " euros");
                Console.WriteLine();
            } 
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
           

        }

        public static void MoneyInserted(MoneyCollector m)
        {
            Console.WriteLine();
            Console.WriteLine("Vous avez déjà inséré " + m.TotalMoneyInDouble + " euros :");
            Console.WriteLine(m.Show());

        }

        public static void Insert(MoneyCollector m) // Method which ask the user what types of coins he wants to insert
        {
            string choice;
            Console.WriteLine();
            Console.WriteLine("Quelles pièces voulez vous insérer ?");
            Console.WriteLine("\t1 : 1 euro");
            Console.WriteLine("\t2 : 50 cents");
            Console.WriteLine("\t3 : 25 cents");
            Console.WriteLine("\t4 : 10 cents");
            Console.WriteLine("\t5 : 5 cents");
            Console.WriteLine("\t6 : 1 cent");
            Console.WriteLine("\t-------------------------------------");
            Console.WriteLine("\t7 : Choisir une boisson");
            Console.WriteLine("\t8 : Voir les ressources de la machine");
            Console.WriteLine("\t9 : Voir les gains de la machine");
            Console.WriteLine("\t-------------------------------------");
            Console.WriteLine();

            do
            {
                MoneyInserted(m);
                choice = Console.ReadLine();
                switch (choice)
                {
                  
                    case "1":
                        m.Insert(Money.EURO_1);
                        break;
                    case "2":
                        m.Insert(Money.CENT_50);
                        break;
                    case "3":
                        m.Insert(Money.CENT_25);
                        break;
                    case "4":
                        m.Insert(Money.CENT_10);
                        break;
                    case "5":
                        m.Insert(Money.CENT_5);
                        break;
                    case "6":
                        m.Insert(Money.CENT_1);
                        break;
                    case "8":
                        RessourceManage.GetRessource();
                        break;
                    case "9":
                        ShowGain();
                        break;
                }
            } while (choice != "7");
        }

        public void Run()
        {
            bool test = false;
            int drinkPrice = 0;
            RessourceManage ressourceManage = new RessourceManage();
            bool leave;
            do
            {
                ShowDrinks(Distributor.Stock);
                Insert(Distributor.Collector);
                ShowDrinks(Distributor.Stock);

                do
                {
                    Console.WriteLine("Choisissez une boisson en utilitsant son code");
                    int code = Convert.ToInt32(Console.ReadLine());



                    if (!VerifyCode(code)) // If the code doesn't exist
                    {
                        Console.WriteLine("Mauvais code");
                    }
                    if (!IsCommandPosible(ressourceManage, code)) // If there is no more stock of a drink
                    {

                        Console.WriteLine("Pas assez de ressource pour votre commande\n");
                        Console.WriteLine("La machine vous retourne : " + Distributor.Collector.TotalMoney/100+" euros ");
                        Console.WriteLine("Veuillez patienter que la machine soit ravitailler");
                        goto AfterLoop;
                    }
                    else
                    {
                        while (Distributor.Collector.TotalMoneyInDouble < Distributor.Stock.ElementAt(code).Price) // If there is no enough moner inserted
                        {
                            Console.WriteLine("Vous avez inséré " + Distributor.Collector.TotalMoneyInDouble + " euros (cent)  et le pris du product es " + Distributor.Stock.ElementAt(code).Price + " euros, you have to insert more !\n");
                            Insert(Distributor.Collector);
                        }

                        Console.WriteLine("Vous avez reçu 1 " + Distributor.Stock.ElementAt(code).GetType().Name + "\n");
                        drinkPrice = Convert.ToInt32(Distributor.Stock.ElementAt(code).Price * 100); // As I said, we used both TotalMoney in Int and in Double
                        ressourceManage.UpdateRessource(Distributor.Stock.ElementAt(code));
                        test = true;

                    }
                } while (!test);

                Dictionary<Money, int> moneyReturned = Distributor.Collector.GetChange(drinkPrice);
                ShowMoneyReturned(moneyReturned, drinkPrice);
                Distributor.ResetMoneyCollector();

                AfterLoop:
                Console.WriteLine("\nVoulez vous quitter ?");
                Console.WriteLine("\t1. Oui");
                Console.WriteLine("\t2. Non");

                leave = Console.ReadLine() == "1";

            } while (!leave);
        }

        private bool IsCommandPosible(RessourceManage rm,int code)
        {
            try
            {
                bool canCommand = rm.CanCommand(Distributor.Stock.ElementAt(code));
                if (canCommand)
                    return true;
                else 
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private bool VerifyCode(int code)
        {
           try {
                Drink drink = Distributor.Stock.ElementAt(code);
                if (drink == null) return false;
                else return true;
            }
             catch{  return false; }
        }

        public static void ShowMoneyReturned(Dictionary<Money,int> change, int drinkPrice)
        {

            double money = (double)(Distributor.Collector.TotalMoney - drinkPrice) / 100;
            Console.WriteLine("La machine vous retourne " + money + " :");
            foreach (KeyValuePair<Money,int> coins in change)
            {
                string test = CoinInString(coins.Key);
                Console.WriteLine("\t- " + coins.Value + " fois " + test);

            }
        }

        public static string CoinInString(Money coin)
        {
            string coinInString = "";
            switch (coin)
            {
               
                case Money.EURO_1:
                    coinInString = "1 euro";
                    break;
                case Money.CENT_50:
                    coinInString = "50 cents";
                    break;
                case Money.CENT_25:
                    coinInString = "20 cents";
                    break;
                case Money.CENT_10:
                    coinInString = "10 cents";
                    break;
                case Money.CENT_5:
                    coinInString = "5 cents";
                    break;
                case Money.CENT_1:
                    coinInString = "1 cent";
                    break;
            }
            return coinInString;
        }
    }
}
