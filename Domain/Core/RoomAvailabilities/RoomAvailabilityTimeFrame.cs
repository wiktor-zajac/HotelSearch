namespace Domain.Core.RoomAvailabilities
{
    public record RoomAvailabilityTimeFrame
    {
        public DateTime From { get; init; }
        public DateTime To { get; init; }
    }
}
