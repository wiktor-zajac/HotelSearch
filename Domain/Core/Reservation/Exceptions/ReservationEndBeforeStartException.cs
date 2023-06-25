namespace Domain.Core.Reservation.Exceptions
{
    internal class ReservationEndBeforeStartException : Exception
    {
        public ReservationEndBeforeStartException(DateTime start, DateTime end)
            : base($"{start} vs {end}") { }
    }
}
