namespace Domain.Core.HotelEmployees
{
    public class HotelEmployee
    {
        public Guid Id { get; init; }
        public Guid HotelId { get; init; }
        public HashSet<HotelEmployeeRight> Rights { get; init; }

        public HotelEmployee(Guid id, Guid hotelId, HashSet<HotelEmployeeRight> rights)
        {
            Id = id;
            HotelId = hotelId;
            Rights = rights;
        }
    }
}
