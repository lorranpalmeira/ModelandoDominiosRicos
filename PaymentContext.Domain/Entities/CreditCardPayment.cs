using System;
namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {

        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumer,
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        string document, 
        string payer, 
        string address, 
        string email):base(paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            this.CardHolderName = cardHolderName;
            this.CardNumber = cardNumber;
            this.LastTransactionNumer = lastTransactionNumer;

        }
        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumer { get; private set; }
    }
}