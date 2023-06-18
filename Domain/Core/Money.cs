namespace Domain.Core
{
    public record Money(string Currency, string Value)
    {
        public static string DefaultCurrency = "PLN";
        public static Money Zero = new(DefaultCurrency, "0");
    }
}
