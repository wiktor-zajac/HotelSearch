namespace Domain.SharedKernel
{
    public record Money
    {
        private string Currency { get; set; } = "PLN";
        private string Value { get; set; } = "0";

        public static Money Zero = new();
    }
}
