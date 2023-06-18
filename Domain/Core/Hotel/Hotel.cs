namespace Domain.Core.Hotel
{
    public class Hotel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = string.Empty;
        public HotelStars Stars { get; private set; } = HotelStars.None;
        public string Address { get; private set; } = string.Empty;

        public Hotel() { }
        public Hotel(Guid id, string name, HotelStars stars, string address)
        {
            Id = id;
            Name = name;
            Stars = stars;
            Address = address;
        }
    }
}
