using Domain.Supporting.Customers.Exceptions;

namespace Domain.Supporting.Customers
{
    public class Customer
    {
        private const int MinimalNameLength = 3;
        private const int MinimumAgeInYears = 18;

        public Guid Id { get; init; }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < MinimalNameLength)
                    throw new CustomerNameIsTooShortException();
                _name = value;
            }
        }

        private DateOnly _birthDate;
        public DateOnly BirthDate
        {
            get => _birthDate;
            set
            {
                if (CheckIfCustomerIsUnderAge(value))
                    throw new CustomerIsUnderAgedException();
                _birthDate = value;
            }
        }

        private static bool CheckIfCustomerIsUnderAge(DateOnly value)
            => value.AddYears(MinimumAgeInYears) > DateOnly.FromDateTime(DateTime.Now);

        public Customer(Guid id, string name, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }
    }
}
