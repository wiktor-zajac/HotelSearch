namespace Domain.Core.Reservation
{
    public class Reservation
    {
        
        public Guid Id { get; } = Guid.NewGuid();
        public Guid RoomId { get; } = Guid.Empty;
        public DateTime ReservationStart { get; set; } = DateTime.Now;

        private DateTime _reservationEnd = DateTime.Now;
        public DateTime ReservationEnd
        {
            get => _reservationEnd;
            set
            {
                if (_reservationEnd < ReservationStart)
                    throw new ReservationEndBeforeStartException(ReservationStart, value);
                _reservationEnd = value;
            }
        }

        public Reservation() { }
        public Reservation(Guid id, Guid roomId, DateTime reservationStart, DateTime reservationEnd)
        {
            Id = id;
            RoomId = roomId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }
    }
}
