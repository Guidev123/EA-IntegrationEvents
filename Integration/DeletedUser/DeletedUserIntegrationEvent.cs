﻿namespace EA.IntegrationEvents.Integration.DeletedUser
{
    public class DeletedUserIntegrationEvent : IntegrationEvent
    {
        public DeletedUserIntegrationEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; private set; }
    }
}
