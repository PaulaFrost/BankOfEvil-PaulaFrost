namespace BankOfEvil.Domain.Entities
{
    public class Account
    {
        public uint AccountNumber { get; }
        public Customer  Owner { get; }
        public decimal Balance { get; private set; }

        public Account(uint accountNumber, Customer owner, decimal balance = 0) //balance satte vi en standarvärde med 0
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount; //Balance sattes private set; för att få tag det inne i klassen men inte utanför
            }
        }

        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
        }
    }
}
