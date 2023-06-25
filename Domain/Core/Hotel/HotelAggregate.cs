using Domain.SharedKernel;

namespace Domain.Core.Hotel
{
    public class HotelAggregate
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public HotelStars Stars { get; set; }
        public Address Address { get; set; }

        public HotelAggregate(Guid id, string name, HotelStars stars, Address address)
        {
            Id = id;
            Name = name;
            Stars = stars;
            Address = address;
        }
    }
}
