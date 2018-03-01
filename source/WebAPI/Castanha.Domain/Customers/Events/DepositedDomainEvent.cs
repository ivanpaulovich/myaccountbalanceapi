﻿namespace Castanha.Domain.Customers.Events
{
    using Castanha.Domain.ValueObjects;
    using System;

    public class DepositedDomainEvent : DomainEvent
    {
        public Guid TransactionId { get; private set; }
        public Guid CustomerId { get; private set; }
        public Amount Amount { get; private set; }

        public DepositedDomainEvent(Guid aggregateRootId, int version, 
            Guid transactionId, Guid customerId, Amount amount)
            : base(aggregateRootId, version)
        {
            this.TransactionId = transactionId;
            this.CustomerId = customerId;
            this.Amount = amount;
        }
    }
}
