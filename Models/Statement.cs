using System;

namespace BankSystem.Models
{
    class Statement : Card
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; private set; }
        public string TransactionType { get; private set; }

        public Statement(Card card, decimal amount, bool isDeposit) : base (card)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
            SetTransaction(isDeposit);
        }

        private void SetTransaction(bool check)
        {
            if (!check)
                TransactionType = "Withdrawal";
            else
                TransactionType = "Deposit";
        }

        public void ShowStatement()
        {
            Console.WriteLine($"{TransactionType} of {Amount.ToString("c", MainMenu.Greek)} at {TransactionDate} --> " +
                $" New balance {Balance.ToString("c", MainMenu.Greek)}");
        }
    }
}
