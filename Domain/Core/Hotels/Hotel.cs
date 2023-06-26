using Domain.SharedKernel;

namespace Domain.Core.Hotels
{
    public class Hotel
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public HotelStars Stars { get; set; }
        public Address Address { get; set; }

        public Hotel(Guid id, string name, HotelStars stars, Address address)
        {
            Id = id;
            Name = name;
            Stars = stars;
            Address = address;
        }
    }
}
