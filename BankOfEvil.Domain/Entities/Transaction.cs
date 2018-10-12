using System;

namespace BankOfEvil.Domain.Entities
{
    public class Transaction
    {
        public Account SourceAccount { get; }
        public Account DestinationAccount { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }

        public Transaction(Account sourceAccount, Account destinationAccount, DateTime date, decimal amount)
        {
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Amount = amount;
            Date = date;
        }
    }
}
