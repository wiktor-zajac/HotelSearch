namespace Domain.Core.Room
{
    internal class Room
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid HotelId { get; private set; } = Guid.Empty;
        public string Name { get; private set; } = string.Empty;
        public Money Price { get; private set; } = Money.Zero;
        public IEnumerable<RoomFeature> Features { get; private set; } = new List<RoomFeature>();

        public Room() { }
        public Room(Guid id, Guid hotelId, string name, Money price, IEnumerable<RoomFeature> features)
        {
            Id = id;
            HotelId = hotelId;
            Name = name;
            Price = price;
            Features = features;
        }
    }
}
