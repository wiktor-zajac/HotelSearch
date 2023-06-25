using Domain.SharedKernel;

namespace Domain.Core.Room
{
    internal class RoomAggregate
    {
        public Guid Id { get; init; }
        public Guid HotelId { get; init; }
        public string Name { get; set; }
        public Money Price { get; set; }
        public HashSet<RoomFeature> Features { get; init; }

        public RoomAggregate(Guid id, Guid hotelId, string name, Money price, HashSet<RoomFeature> features)
        {
            Id = id;
            HotelId = hotelId;
            Name = name;
            Price = price;
            Features = features;
        }
    }
}
