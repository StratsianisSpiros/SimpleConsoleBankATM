

namespace BankSystem.Interfaces
{
    interface ITransactions
    {
        void WithDraw(decimal amount);
        void Deposit(decimal amount);
    }
}
