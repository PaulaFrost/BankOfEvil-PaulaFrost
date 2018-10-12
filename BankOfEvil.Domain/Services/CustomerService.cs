using BankOfEvil.Domain.Entities;
using System;

namespace BankOfEvil.Domain.Services
{
    public class CustomerService
    {
        public Customer CreateCustomer(string firstName, string lastName, string socialSecurityNumber)
        {
            var customer = new Customer(firstName, lastName, socialSecurityNumber);

            var random = new Random();

            var accountNumbere = (uint) random.Next(10000, 99999);

            var account = new Account(accountNumbere, customer);

            customer.AddAccount(account);
                
            return customer;
            
        }
    }
}
