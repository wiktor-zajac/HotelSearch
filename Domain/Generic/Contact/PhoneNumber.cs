using Domain.Generic.Contact.Exceptions;
using PhoneNumbers;

namespace Domain.Generic.Contact
{
    public record PhoneNumber
    {
        private string _number = String.Empty;
        public string Number
        {
            get => _number;
            set
            {
                if (PhoneNumberUtil.IsViablePhoneNumber(value))
                    _number = value;
                else
                    throw new InvalidPhoneNumberException();
            }
        }

        public PhoneNumber(string number)
        {
            Number = number;
        }
    }
}
