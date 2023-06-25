using Domain.Core.Reservation.Exceptions;

namespace Domain.Core.Reservation
{
    public class ReservationAggregate
    {

        public Guid Id { get; init; }
        public Guid RoomId { get; init; }
        public Guid OrderId { get; init; }
        public Guid CustomerId { get; init; }
        public DateTime ReservationStart { get; set; }

        private DateTime _reservationEnd;
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

        public ReservationAggregate(Guid id, Guid roomId, Guid orderId, Guid customerId, DateTime reservationStart, DateTime reservationEnd)
        {
            Id = id;
            RoomId = roomId;
            OrderId = orderId;
            CustomerId = customerId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }
    }
}
