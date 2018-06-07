using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests{

    [TestClass]
    public class StudentTests{

        [TestMethod]
        public void AdcionarAssinatura(){
            // var subscription = new Subscription(null);
            // var student = new Student("Lorran","Alves","1234567","Lorran.dba@gmail.com");

            // student.AddSubscription(subscription);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription(){
            var name = new Name("Bruce","Wayne");
            var document = new Document("123456789",EDocumentType.CPF);
            var address = new Address("Rua 1",1234,"Bairro Legal", "Gothan","SP","BR","12300-000");
            var email = new Email("bruce@bruce.com");
            var student = new Student(name,document,email);
            var subscription = new Subscription(null);
            var payment = new PayPalPayment("12345678",DateTime.Now,DateTime.Now.AddDays(5),10,10,document,"Wayne",address,email);

            subscription.AddPayments(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);

            Assert.Fail();

        }

        [TestMethod]
        public void ShouldReturnSucessWhenSubscriptionNoPayment(){

            var name = new Name("Bruce","Wayne");
            var document = new Document("123456789",EDocumentType.CPF);
            var address = new Address("Rua 1",1234,"Bairro Legal", "Gothan","SP","BR","12300-000");
            var email = new Email("bruce@bruce.com");
            var student = new Student(name,document,email);

            Assert.Fail();
            
        }

        [TestMethod]
        public void ShouldReturnSucessWhenHadActiveSubscription(){
            

            Assert.Fail();

        }


    }
}