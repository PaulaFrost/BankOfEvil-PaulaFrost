using BankOfEvil.Domain.Services;
using NUnit.Framework;
using System.Linq;

namespace BankOfEvil.Test.Services
{
    [TestFixture] // kallas attribute den här texten
    class TransferServiceTest
    {
        [Test]
        public void TestSomething()
        {
            var tranferService = new TransferService();
            var costumerService = new CustomerService();

            var johnDoe = costumerService.CreateCustomer("John", "Doe", "8001021234");
            var janeDoe = costumerService.CreateCustomer("Jane", "Doe", "8101021294");

            var johnDoeAccount = johnDoe.Accounts.First();
            johnDoeAccount.Deposit(2000);

            var janeDoeAccount = janeDoe.Accounts.First();
            var amount = 1000;

            tranferService.Transfer(johnDoeAccount, janeDoeAccount, amount);

            Assert.AreEqual(amount * 0.90m, janeDoeAccount.Balance);
        }
    }
}
