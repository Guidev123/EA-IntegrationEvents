namespace EA.IntegrationEvents.Integration.PaymentConfirmed;

public class PaymentConfirmedIntegrationEvent : IntegrationEvent
{
    public PaymentConfirmedIntegrationEvent(bool isPaid, string orderCode)
    {
        IsPaid = isPaid;
        OrderCode = orderCode;
    }

    public bool IsPaid { get; private set; }
    public string OrderCode { get; private set; }
}
