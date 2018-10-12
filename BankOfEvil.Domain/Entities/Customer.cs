using System.Collections.Generic;

namespace BankOfEvil.Domain.Entities
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public List<Account> Accounts {get;} = new List<Account>();

        public Customer(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    } 
}
