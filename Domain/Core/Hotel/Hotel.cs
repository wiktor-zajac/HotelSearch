using Domain.SharedKernel;

namespace Domain.Core.Hotel
{
    public class Hotel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; private set; } = string.Empty;
        public HotelStars Stars { get; private set; } = HotelStars.None;
        public Address Address { get; private set; } = Address.Empty;

        public Hotel() { }
        public Hotel(Guid id, string name, HotelStars stars, Address address)
        {
            Id = id;
            Name = name;
            Stars = stars;
            Address = address;
        }
    }
}
