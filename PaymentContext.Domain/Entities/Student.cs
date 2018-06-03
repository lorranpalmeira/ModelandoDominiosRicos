using System.Collections.Generic;
using System;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

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
        }

        public Name name { get; set; }
        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public Address Address { get; private set; }

        public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscriptions.ToArray();} }


        public void AddSubscription(Subscription subscription){

            foreach (var sub in Subscriptions)
            {
                sub.Inactivate(); 
            }

            _subscriptions.Add(subscription);
        }



    }
}