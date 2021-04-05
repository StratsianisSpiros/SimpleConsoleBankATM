using System;
using System.Text.RegularExpressions;

namespace BankSystem
{
    abstract class UserInput
    {
        public static int InputInteger(int min, int max)
        {
            string temp;

            do
            {
                if (Program.Check)
                    Console.Write($"Enter a value from {min} to {max} : ");
                if (!Program.Check)
                    Console.Write($"PIN number mut be only 4 nubmers : ");

                temp = Console.ReadLine(); 
                if (!Program.Check && temp.ToLower().Equals("exit"))
                    Environment.Exit(0);
            }
            while (!int.TryParse(temp, out _) || int.Parse(temp) < min || int.Parse(temp) > max);

            return int.Parse(temp);
        }

        public static string ChangeAddres()
        {
            string temp;
            bool match;
            do
            {
                Console.Write("Enter new address, number and street name : ");
                temp = Console.ReadLine();
                match = Regex.Match(temp, @"^[0-9]{1,3}\s*?[A-Za-z]+$").Success;
            }
            while (!match);

            return temp;
        }

        public static long ChangeMobile()
        {
            string temp;
            bool match;
            do
            {
                Console.Write("Enter new mobile number, must be 10 digits : ");
                temp = Console.ReadLine();
                match = Regex.Match(temp, "^[0-9]{10}$").Success;
            }
            while (!long.TryParse(temp, out _) || !match);

            return long.Parse(temp);
        }

        public static int ChangePIN()
        {
            string temp;
            bool match;
            do
            {
                Console.Write("Enter new PIN number, must be 4 digits : ");
                temp = Console.ReadLine();
                match = Regex.Match(temp, "^[0-9]{4}$").Success;
            }
            while (!int.TryParse(temp, out _) || !match);

            return int.Parse(temp);
        }
    }
}
