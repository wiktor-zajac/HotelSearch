using Domain.SharedKernel.Customer.Exceptions;

namespace Domain.SharedKernel.Customer
{
    public class CustomerAggregate
    {
        private const int MinimalNameLength = 3;
        private const int MinimumAgeInYears = 18;

        public Guid Id { get; init; }

        private string _name = String.Empty;
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

        public CustomerAggregate(Guid id, string name, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }
    }
}
