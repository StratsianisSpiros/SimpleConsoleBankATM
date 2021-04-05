using System;
using System.Collections.Generic;
using BankSystem.Interfaces;
using System.Linq;

namespace BankSystem.Models
{
    class Card : Account, ITransactions
    {
        public long  CardNumber { get; set; }
        public string CardType { get; private set; }
        public int CVV { get; set; }
        public int PinNumber { get; set; }

        public DateTime ExpiryDate { get; set; }

        private readonly List<Statement> statements = new List<Statement>();
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Statement statement = new Statement(this, amount, true);
            statements.Add(statement);   
        }

        public void WithDraw(decimal amount)
        {
            if (Balance >= amount && DailyWithdraw() + amount <= MaxWithdawal)
            {
                Balance -= amount;
                Statement statement = new Statement(this, amount, false);
                statements.Add(statement);
            }
            else
                Console.WriteLine("Balance low or maximum daily withdrawal reached.");
        }

        public void DisplayStatements(int times)
        {
            if (statements.Count < times)
                times = statements.Count;

            if (statements.Count == 0)
            {
                Console.WriteLine("No statements available.");
            }
            else
            {
                Console.WriteLine($"{CardType} card with No {CardNumber} of {BankName} bank.");
                Console.WriteLine($"Last {times} statements for customer {FullName}.");
                Console.WriteLine($"{Address}, {City}");
                for (int i = statements.Count - 1; i >= statements.Count - times; i--)
                {
                    statements[i].ShowStatement();
                }
            }
        }

        public Card(long cardNumber, int type, int cvv, int pinNumber,
             DateTime expiryDate, Account account) : base (account)
        {
            CardNumber = cardNumber;
            SetCardType(type);
            CVV = cvv;
            PinNumber = pinNumber;
            ExpiryDate = expiryDate;
        }

        public Card(Card card)
        {
            Balance = card.Balance;
        }

        private string SetCardType(int type)
        {
            switch (type)
            {
                case 1:
                    return CardType = "Credit";
                case 2:
                    return CardType = "Debit";
                default:
                    return CardType = "Other";
            }
        }
        public void ShowBalance()
        {
            Console.Write("Your balance is ");
            Console.Write(Balance.ToString("c", MainMenu.Greek));
        }
        public void ShowCustomer()
        {
            Console.WriteLine(FullName);
            Console.WriteLine($"{Address}, {City}");
            Console.WriteLine($"Mobile number --> {MobileNumber:0000000000}");
        }
        public void ShowCardDetails()
        {
            Console.WriteLine($"Bank --> {BankName}");
            Console.WriteLine($"{CardType} card with No *{CardNumber}*");
            Console.WriteLine($"Expiry date {ExpiryDate:dd/MM/yyyy}");
        }
        private decimal DailyWithdraw()
        {
            //return from state in statements
            //       where state.TransactionDate > DateTime.Now.AddDays(-1)
            //       let x = statements.Add(state.Amount)
            //       select x;

            return statements.Where(state => state.TransactionDate > DateTime.Now.AddDays(-1))
                .Where(type => type.TransactionType.Equals("Withdrawal")).Sum(amount => amount.Amount);
        }
    }
}
