using System;
using System.Text;

using BankSystem.Validations;


namespace BankSystem
{
    class Program
    {
        public static bool Check { get; set; }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Check = CheckPin.CheckPinNumber();

                while (Check)
                {
                    MainMenu.Start();
                }
            }

        }
    }
}



