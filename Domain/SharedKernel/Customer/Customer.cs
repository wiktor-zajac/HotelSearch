namespace Domain.SharedKernel.Customer
{
    public class Customer
    {
        private const int MinimalNameLength = 3;
        private const int MinimumAgeInYears = 18;

        public Guid Id { get; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < MinimalNameLength)
                    throw new CustomerNameIsTooShort();
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

#pragma warning disable CS8618
        public Customer(Guid id, string name, DateOnly birthDate)
#pragma warning restore CS8618
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }
    }
}
