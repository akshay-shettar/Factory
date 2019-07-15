﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Client
{
    class Program
    {
        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string cardType = Console.ReadLine();
            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFacory(500000, 1000);
                    break;
                default:
                    Console.WriteLine("\nWRONG CARD ...!!\n");
                    Console.ReadKey();
                    return;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
