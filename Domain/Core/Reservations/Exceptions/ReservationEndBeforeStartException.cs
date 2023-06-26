namespace Domain.Core.Reservations.Exceptions
{
    internal class ReservationEndBeforeStartException : Exception
    {
        public ReservationEndBeforeStartException(DateTime start, DateTime end)
            : base($"{start} vs {end}") { }
    }
}
