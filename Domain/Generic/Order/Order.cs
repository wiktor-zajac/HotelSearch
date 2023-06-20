using Domain.SharedKernel;

namespace Domain.Generic.Order
{
    public class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Money Price { get; private set; } = Money.Zero;
        public PaymentStatus PaymentStatus { get; private set; } = PaymentStatus.AwaitingPayment;
        public DateTime OrderPlaced { get; } = DateTime.Now;

        public Order() { }
        public Order(Guid id, Money price, PaymentStatus paymentStatus, DateTime orderPlaced)
        {
            Id = id;
            Price = price;
            PaymentStatus = paymentStatus;
            OrderPlaced = orderPlaced;
        }
    }
}
