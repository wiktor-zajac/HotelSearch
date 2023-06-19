using Domain.Core.Reservation;
using Domain.SharedKernel;

namespace Domain.Supporting.Order
{
    public class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Money Price { get; private set; } = Money.Zero;
        public PaymentStatus PaymentStatus { get; private set; } = PaymentStatus.AwaitingPayment;
        public DateTime OrderPlaced { get; } = DateTime.Now;
        public IEnumerable<Reservation> Reservations { get; } = Enumerable.Empty<Reservation>();

        public Order() {}
        public Order(Guid id, Money price, PaymentStatus paymentStatus, DateTime orderPlaced, IEnumerable<Reservation> reservations)
        {
            Id = id;
            Price = price;
            PaymentStatus = paymentStatus;
            OrderPlaced = orderPlaced;
            Reservations = reservations;
        }
    }
}
