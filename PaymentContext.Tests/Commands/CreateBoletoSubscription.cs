using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{

    [TestClass]
    public class CreateBoletoSubscription
    {

        public void ShouldReturnErrorNameIsInvalid(){

            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName  ="";

            command.Validate();

            Assert.AreEqual(false, command.Valid);
        }
        
    }
}