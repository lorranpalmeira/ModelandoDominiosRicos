using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {

        // public Address(string street, int number, string neighborhood, string city, string state, string country, string zipCode)
        // {
        //     this.Street = street;
        //     this.Number = number;
        //     this.Neighborhood = neighborhood;
        //     this.City = city;
        //     this.State = state;
        //     this.Country = country;
        //     this.ZipCode = zipCode;

        //  }
        public string Street { get; private set; }

        public int Number { get; private set; }

        public string Neighborhood { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }
        public string Country { get; private set; }

        public string ZipCode { get; private set; }



    }
}