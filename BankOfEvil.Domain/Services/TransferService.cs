using BankOfEvil.Domain.Entities;
using System;

namespace BankOfEvil.Domain.Services
{
    public class TransferService
    {
        public void Transfer(Account sourceAccount, Account destinationAccount, decimal amount)
        {

            if (sourceAccount.Balance < amount)
            {
                return;
            }

            sourceAccount.Withdraw(amount);
            destinationAccount.Deposit(amount * 0.90m);
        }
    }
}
