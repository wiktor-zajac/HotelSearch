namespace Domain.SharedKernel
{
    public record Money
    {
        public string Currency { get; set; } = "PLN";
        public string Value { get; set; } = "0";

        public static readonly Money Zero = new();
    }
}
