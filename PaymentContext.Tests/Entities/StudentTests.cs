using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests{

    [TestClass]
    public class StudentTests{


        private readonly Name _name;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Email _email;
        private readonly Student _student;
        private readonly Subscription _subscription;

        public StudentTests()
        {
            _name =  new Name("Bruce","Wayne");
            _document = new Document("123456789",EDocumentType.CPF);;
            _address = new Address("Rua 1",1234,"Bairro Legal", "Gothan","SP","BR","12300-000");
            _email = new Email("bruce@bruce.com");
            _student = new Student(_name,_document,_email);
            _subscription =  new Subscription(null);
        }

        [TestMethod]
        public void AdcionarAssinatura(){
            // var subscription = new Subscription(null);
            // var student = new Student("Lorran","Alves","1234567","Lorran.dba@gmail.com");

            // student.AddSubscription(subscription);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription(){
           
            var payment = new PayPalPayment("12345678",DateTime.Now,DateTime.Now.AddDays(5),10,10,_document,"Wayne",_address,_email);

            _subscription.AddPayments(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment(){

            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
            
        }

        [TestMethod]
        public void ShouldReturnSucessWhenHadActiveSubscription(){
            var payment = new PayPalPayment("12345678",DateTime.Now,DateTime.Now.AddDays(5),10,10,_document,"Wayne",_address,_email);

            _subscription.AddPayments(payment);
            _student.AddSubscription(_subscription);
            

            Assert.IsTrue(_student.Valid);

            

        }


    }
}