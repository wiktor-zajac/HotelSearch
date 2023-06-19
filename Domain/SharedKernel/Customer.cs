namespace Domain.SharedKernel
{
    public class Customer
    {
        public Guid Id { get; }
        public string Name { get; private set; } = String.Empty;
        public DateOnly BirthDate { get; private set; } = DateOnly.MinValue;

        public Customer() { }
        public Customer(Guid id, string name, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }
    }
}
