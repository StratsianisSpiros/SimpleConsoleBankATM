using System;
using System.Globalization;
using BankSystem.Validations;
using BankSystem.Models;

namespace BankSystem
{
    abstract class MainMenu : UserInput
    {
        public static CultureInfo Greek { get => new CultureInfo("el-GR"); } 
 
        static readonly int[] DepositWithdrawDefaultValues = new int[] { 50, 100, 180, 300, 500 };

        private static Card activeCard;

        public static void SetCard(Card card)
        {
            activeCard = card;
        }
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Bank.");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View statements");
            Console.WriteLine("4. Customer Information");
            Console.WriteLine("5. Exit");
            Console.Write(Environment.NewLine);
            int selection = InputInteger(1, 5);
           

            switch (selection)
            {
                case 1: Deposit();
                    Console.ReadKey(true);
                    break;
                case 2: Withdraw();
                    Console.ReadKey(true);
                    break;
                case 3: Statements();
                    Console.ReadKey(true);
                    break;
                case 4: Customer();
                    Console.ReadKey(true);
                    break;
                case 5: Program.Check = false;
                    break;
                default: Start();
                    break;
            }
        }

        public static void Deposit()
        {
            Console.Clear();
            Console.WriteLine("How much would you like to Deposit?");
            Console.WriteLine("1. {0}", DepositWithdrawDefaultValues[0].ToString("c", Greek));
            Console.WriteLine("2. {0}", DepositWithdrawDefaultValues[1].ToString("c", Greek));
            Console.WriteLine("3. {0}", DepositWithdrawDefaultValues[2].ToString("c", Greek));
            Console.WriteLine("4. {0}", DepositWithdrawDefaultValues[3].ToString("c", Greek));
            Console.WriteLine("5. {0}", DepositWithdrawDefaultValues[4].ToString("c", Greek));
            Console.WriteLine("6. Other amount");
            Console.WriteLine("7. Balance");
            Console.WriteLine("8. Back");
            Console.Write(Environment.NewLine);
            int selection = InputInteger(1, 8);


            switch (selection)
            {
                case 1: activeCard.Deposit(DepositWithdrawDefaultValues[0]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 2: activeCard.Deposit(DepositWithdrawDefaultValues[1]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 3: activeCard.Deposit(DepositWithdrawDefaultValues[2]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 4: activeCard.Deposit(DepositWithdrawDefaultValues[3]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 5: activeCard.Deposit(DepositWithdrawDefaultValues[4]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 6: activeCard.Deposit(InputInteger(50, 5000));
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 7: activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Deposit();
                    break;
                case 8: Start();
                    break;
                default: Deposit();
                    break;
            }
        }

        public static void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("How much would you like to Withdraw?");
            Console.WriteLine("1. {0}", DepositWithdrawDefaultValues[0].ToString("c", Greek));
            Console.WriteLine("2. {0}", DepositWithdrawDefaultValues[1].ToString("c", Greek));
            Console.WriteLine("3. {0}", DepositWithdrawDefaultValues[2].ToString("c", Greek));
            Console.WriteLine("4. {0}", DepositWithdrawDefaultValues[3].ToString("c", Greek));
            Console.WriteLine("5. {0}", DepositWithdrawDefaultValues[4].ToString("c", Greek));
            Console.WriteLine("6. Other amount");
            Console.WriteLine("7. Balance");
            Console.WriteLine("8. Back");
            Console.Write(Environment.NewLine);
            int selection = InputInteger(1, 8);
            

            switch (selection)
            {
                case 1: activeCard.WithDraw(DepositWithdrawDefaultValues[0]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 2: activeCard.WithDraw(DepositWithdrawDefaultValues[1]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 3: activeCard.WithDraw(DepositWithdrawDefaultValues[2]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 4: activeCard.WithDraw(DepositWithdrawDefaultValues[3]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 5: activeCard.WithDraw(DepositWithdrawDefaultValues[4]);
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 6: activeCard.WithDraw(InputInteger(50, 5000));
                    activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 7: activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Withdraw();
                    break;
                case 8: Start();
                    break;
                default: Withdraw();
                    break;
            }
        }

        public static void Statements()
        {
            Console.Clear();
            Console.WriteLine("Statement reports");
            Console.WriteLine("1. View Current Balance");
            Console.WriteLine("2. View Last 5 Statements");
            Console.WriteLine("3. View Last 10 Statements");
            Console.WriteLine("4. View Last 20 Statements");
            Console.WriteLine("5. Back");
            Console.Write(Environment.NewLine);
            int selection = InputInteger(1, 5);

            switch (selection)
            {
                case 1: activeCard.ShowBalance();
                    Console.ReadKey(true);
                    Statements();
                    break;
                case 2: activeCard.DisplayStatements(5);
                    Console.ReadKey(true);
                    Statements();
                    break;
                case 3: activeCard.DisplayStatements(10);
                    Console.ReadKey(true);
                    Statements();
                    break;
                case 4: activeCard.DisplayStatements(20);
                    Console.ReadKey(true);
                    Statements();
                    break;
                case 5: Start();
                    break;
                default: Statements();
                    break;
            }
        }

        public static void Customer()
        {
            Console.Clear();
            Console.WriteLine("Customer Information.");
            Console.WriteLine("1. Show Customer Details");
            Console.WriteLine("2. Show Card Details");
            Console.WriteLine("3. Change Address");
            Console.WriteLine("4. Change Moblie Number");
            Console.WriteLine("5. Change PIN");
            Console.WriteLine("6. Exit");
            Console.Write(Environment.NewLine);
            int selection = InputInteger(1, 6);


            switch (selection)
            {
                case 1: activeCard.ShowCustomer();
                    Console.ReadKey(true);
                    Customer();
                    break;
                case 2: activeCard.ShowCardDetails();
                    Console.ReadKey(true);
                    Customer();
                    break;
                case 3: string newAddress = ChangeAddres();
                    activeCard.Address = newAddress;
                    activeCard.ShowCustomer();
                    Console.ReadKey(true);
                    Customer();
                    break;
                case 4: long newMobileNumber = ChangeMobile();
                    activeCard.MobileNumber = newMobileNumber;
                    activeCard.ShowCustomer();
                    Console.ReadKey(true);
                    Customer();
                    break;
                case 5: int newPIN = ChangePIN();
                    activeCard.PinNumber = newPIN;
                    Console.ReadKey(true);
                    Customer();
                    break;
                case 6: Start();
                    break;
                default: Customer();
                    break;
            }

        }

    }
}
