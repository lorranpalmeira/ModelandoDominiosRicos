using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {

        public Email(string Address)
        {
            this.Address = Address;
        }
        public string Address { get; set; }
    }
}