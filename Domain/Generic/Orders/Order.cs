using Domain.SharedKernel;
using Domain.Generic.ContactDetails;

namespace Domain.Generic.Orders
{
    public class Order
    {
        public Guid Id { get; init; }
        public Money Price { get; set; }
        public string RecipientName { get; set; }
        public ContactDetail RecipientContactDetails { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime OrderPlaced { get; init; }


        public Order(Guid id, Money price, string recipientName, ContactDetail recipientContactDetails)
        {
            Id = id;
            Price = price;
            RecipientName = recipientName;
            RecipientContactDetails = recipientContactDetails;
            PaymentStatus = PaymentStatus.AwaitingPayment;
            OrderPlaced = DateTime.Now;
        }
        public Order(Guid id, Money price, string recipientName, ContactDetail recipientContactDetails, PaymentStatus paymentStatus, DateTime orderPlaced)
        {
            Id = id;
            Price = price;
            RecipientName = recipientName;
            RecipientContactDetails = recipientContactDetails;
            PaymentStatus = paymentStatus;
            OrderPlaced = orderPlaced;
        }
    }
}
