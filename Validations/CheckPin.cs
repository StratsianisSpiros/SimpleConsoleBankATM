using System;
using System.Collections.Generic;
using System.Linq;
using BankSystem.Models;
using BankSystem.Data;

namespace BankSystem.Validations
{
    abstract class CheckPin
    {
        public static List<Card> Cards { get; set; } = new List<Card>();

        public static bool CheckPinNumber()
        {
            Console.Clear();
            AllData data = new AllData();
            Cards = data.GetCardList();

            Console.WriteLine("Enter your pin number, or type exit. ");
            int pin = UserInput.InputInteger(1, 9999);
            try
            {
                Card card = Cards.Single(crd => crd.PinNumber == pin);
                MainMenu.SetCard(card);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Wrong pin number, Goodbye");
                Console.ReadKey(true);
            }
            return false;
        }

    }
}
