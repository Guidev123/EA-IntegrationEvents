namespace EA.IntegrationEvents.Integration.ReceivedAddress
{
    public class ReceivedAddressIntegrationEvent : IntegrationEvent
    {
        public ReceivedAddressIntegrationEvent(Guid customerId, string street, string number, string additionalInfo, string neighborhood, string zipCode, string city, string state)
        {
            CustomerId = customerId;
            Street = street;
            Number = number;
            AdditionalInfo = additionalInfo;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            City = city;
            State = state;
        }
        public Guid CustomerId { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string AdditionalInfo { get; private set; }
        public string Neighborhood { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
    }
}
