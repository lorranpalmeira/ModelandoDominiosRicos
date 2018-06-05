using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {

        public Email(string Address)
        {
            this.Address = Address;

            AddNotifications(new Contract()
            .Requires()
            .IsEmail(Address,"Email.Address","E-mail Inálido"));
        }
        public string Address { get; set; }
    }
}