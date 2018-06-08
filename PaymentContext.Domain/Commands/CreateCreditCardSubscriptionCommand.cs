using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Commands
{
    public class CreateCreditCardSubscriptionCommand
    {
                    public class CreatePayPalSubscriptionCommand{

        public string FirstName { get;  set; }
        public string LastName { get;  set; }

        public int Number {get;  set;}

        public EDocumentType Type {get; set;}

        public string Address {get ;  set;}

        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumer { get; private set; }

        

        public DateTime PaidDate { get; set; }

        public DateTime ExpireDate { get; set; }    

        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; }

        public Document Document { get; set; }

        public string Payer {get;set;}

        public string PayerDocument {get;set;}

        public EDocumentType PayerDocumentType {get;set;}

        
        public Email Email { get; set; }

        public string Street { get;  set; }

        
        public string Neighborhood { get;  set; }

        public string City { get;  set; }

        public string State { get;  set; }
        public string Country { get;  set; }

        public string ZipCode { get;  set; }
    }
}