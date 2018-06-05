using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment( DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Document = document;
            Payer = payer;
            Address = address;
            Email = email;

            AddNotifications(new Contract().Requires()
                .IsGreaterThan(0,Total,"Payment.Total","O Total não pode ser zero")
                .IsGreaterOrEqualsThan(Total,TotalPaid,"Payment.TotalPaid","O valor pago é menor que o total")
                );

        }

        public string Number { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime ExpireDate { get; set; }    

        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; }

        public Document Document { get; set; }

        public string Payer {get;set;}

        public Address Address { get; set; }

        public Email Email { get; set; }
        
    }


    

}