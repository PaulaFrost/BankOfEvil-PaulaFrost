using BankOfEvil.Domain.Services;
using NUnit.Framework;

namespace BankOfEvil.Test.Services
{
    [TestFixture]
    class CustomerServiceTest
    {
        [Test]
        public void CreateCustomer_Should_Create_Customere_When_Given_Valid_Input() //ska heta så att andra ser vad detta ska testa
        {
            var customerService = new CustomerService();

            var johnDoe = customerService.CreateCustomer("John", "Doe", "8001021234");

            Assert.AreEqual("John", johnDoe.FirstName);
            Assert.AreEqual("Doe", johnDoe.LastName);
            Assert.AreEqual("8001021234", johnDoe.SocialSecurityNumber);

            //Assert.True(johnDoe.Accounts.Count == 1);
            Assert.AreEqual(1, johnDoe.Accounts.Count); // dessa två testar samma men två olika sätt att skriva på. Här testar vi att det bara finns ett konto i det.
        }
    }
}
