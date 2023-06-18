namespace Domain.Core
{
    public class Order
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Money Price { get; private set; } = Money.Zero;
        public PaymentStatus PaymentStatus { get; private set; } = PaymentStatus.AwaitingPayment;
        public DateTime OrderPlaced { get; private set; } = DateTime.Now;
        public DateTime OrderUpdated { get; private set;} = DateTime.Now;

        public Order() { }
        public Order(Guid id, Money price, PaymentStatus paymentStatus, DateTime orderPlaced, DateTime orderUpdated)
        {
            Id = id;
            Price = price;
            PaymentStatus = paymentStatus;
            OrderPlaced = orderPlaced;
            OrderUpdated = orderUpdated;
        }
    }
}
