using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment( DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document, string payer, string address, string email)
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
        }

        public string Number { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime ExpireDate { get; set; }    

        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; }

        public string Document { get; set; }

        public string Payer {get;set;}

        public string Address { get; set; }

        public string Email { get; set; }
        
    }


    

}