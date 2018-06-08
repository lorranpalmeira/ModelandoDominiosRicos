using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscription : Notifiable , ICommand
    {

        public string FirstName { get;  set; }
        public string LastName { get;  set; }



        public int Number {get;  set;}

        public EDocumentType Type {get; set;}

        public string Address {get ;  set;}

        public string BarCode { get; private set; }

        public string BoletoNumber { get; private set; }

        

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

                public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName,3,"Name.FirstName","Nome deve ter 3 caracteres no minimo")
            .HasMinLen(LastName,3,"Name.LastName","Nome deve ter 3 caracteres no minimo")
            .HasMaxLen(FirstName,40,"Name.FirstName","Nome deve ter maximo 40")
            
            );
        }

        
    }
}