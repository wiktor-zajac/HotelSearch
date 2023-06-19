namespace Domain.SharedKernel
{
    public record Address(string Country, string SubRegion, string City, string Street, string BuildingNumber,
        string ZipCode)
    {
        public static Address Empty { get; } = new(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
            string.Empty);
    }
}
