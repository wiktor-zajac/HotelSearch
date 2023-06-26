namespace Domain.Core.RoomAvailabilities
{
    public class RoomAvailability
    {
        public Guid RoomId { get; init; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set;}
        public IEnumerable<RoomAvailabilityTimeFrame> AvailabilityTimeFrames { get; init; }

        public RoomAvailability(Guid roomId, DateTime reservationStart, DateTime reservationEnd)
        {
            RoomId = roomId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
            AvailabilityTimeFrames = new List<RoomAvailabilityTimeFrame>();
        }
    }
}
