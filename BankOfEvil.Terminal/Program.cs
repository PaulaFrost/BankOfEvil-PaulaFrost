using BankOfEvil.Domain.Entities;
using BankOfEvil.Domain.Services;
using System;

namespace BankOfEvil.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();

            var johnDoe = customerService.CreateCustomer("John", "Doe", "8001015689");
            var janeDoe = customerService.CreateCustomer("Jane", "Doe", "8101015685");
        }   
    }
}
