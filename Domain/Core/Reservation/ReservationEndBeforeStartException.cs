namespace Domain.Core.Reservation
{
    internal class ReservationEndBeforeStartException : Exception
    {
        public ReservationEndBeforeStartException(DateTime start, DateTime end)
            : base($"{start} vs {end}") {}
    }
}
