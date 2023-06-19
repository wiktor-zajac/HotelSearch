namespace Domain.Core.Hotel
{
    public class HotelEmployee
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid HotelId { get; private set; } = Guid.Empty;
        public HashSet<HotelRights> Rights { get; private set; } = new();

        public HotelEmployee() { }
        public HotelEmployee(Guid id, Guid hotelId, HashSet<HotelRights> rights)
        {
            Id = id;
            HotelId = hotelId;
            Rights = rights;
        }
    }
}
