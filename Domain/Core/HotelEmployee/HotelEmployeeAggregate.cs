namespace Domain.Core.HotelEmployee
{
    public class HotelEmployeeAggregate
    {
        public Guid Id { get; init; }
        public Guid HotelId { get; init; }
        public HashSet<HotelEmployeeRights> Rights { get; init; }

        public HotelEmployeeAggregate(Guid id, Guid hotelId, HashSet<HotelEmployeeRights> rights)
        {
            Id = id;
            HotelId = hotelId;
            Rights = rights;
        }
    }
}
