using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class Reservation
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid RoomId { get; private set; } = Guid.Empty;
        public DateTime ReservationStart { get; private set; } = DateTime.Now;
        public DateTime ReservationEnd { get; private set; } = DateTime.Now;

        public Reservation() {}
        public Reservation(Guid id, Guid roomId, DateTime reservationStart, DateTime reservationEnd)
        {
            Id = id;
            RoomId = roomId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }
    }
}
