using System.ComponentModel.DataAnnotations;
using Domain.Generic.Contact.Exceptions;

namespace Domain.Generic.Contact
{
    public record Email
    {
        private string _emailAddress = String.Empty;
        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                var email = new EmailAddressAttribute();
                if (email.IsValid(value))
                    _emailAddress = value;
                else
                    throw new InvalidEmailException();
            }
        }

        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
    }
}
