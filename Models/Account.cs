

namespace BankSystem.Models
{
    class Account : CardHolder
    {
        public decimal Balance { get; set; }
        public decimal MaxWithdawal { get; set; }

        public Account(CardHolder cardHolder, string bankname, decimal balance, decimal maxWithdrawal) : base(cardHolder)
        {
            Balance = balance;
            BankName = bankname;
            MaxWithdawal = maxWithdrawal;
        }

        public Account(Account account)
        {
            Name = account.Name;
            Surname = account.Surname;
            MobileNumber = account.MobileNumber;
            DateOfBirth = account.DateOfBirth;
            Address = account.Address;
            City = account.City;
            Balance = account.Balance;
            BankName = account.BankName;
            MaxWithdawal = account.MaxWithdawal;
        }

        public Account() { }
    }
}
