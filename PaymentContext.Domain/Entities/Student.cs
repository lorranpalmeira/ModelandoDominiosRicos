using System.Collections.Generic;
using System;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities
{
    public class Student :  Entity
    {

        private IList<Subscription> _subscriptions;

        
        public Student(Name name, Document document, Email email)
        {
            this.name = name;
            this.Document = document;
            this.Email = email;
            _subscriptions = new List<Subscription>();


            AddNotifications(name,document,email);

        }

        public Name name { get; set; }
        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public Address Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscriptions.ToArray();} }


        public void AddSubscription(Subscription subscription){

            var hasSubscriptionActive = false;
            foreach (var sub in _subscriptions)
            {
                if(sub.Active == true)
                    hasSubscriptionActive = true;
            }

            if(hasSubscriptionActive)
                AddNotification("Student.Subscriptions","Você já tem uma assisnatura");

            // AddNotifications(
            //     new Contract()
            //     .Requires()
            //     .IsFalse(hasSubscriptionActive,3,"Student.Subscriptions","Você já tem uma assinatura")
            // );

            //_subscriptions.Add(subscription);
        }



    }
}