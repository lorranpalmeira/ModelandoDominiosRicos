using System;
namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {

        public PayPalPayment(
        string transactionNumber,
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        string document, 
        string payer, 
        string address, 
        string email):base(paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            this.TransactionNumber = transactionNumber;

        }
        public string TransactionNumber { get; private set; }

    }
}