﻿namespace Castanha.Domain.Customers.Accounts
{
    using Castanha.Domain.Customers.Events;
    using Castanha.Domain.ValueObjects;
    using System;

    public abstract class Transaction : Entity
    {
        public Amount Amount { get; private set; }
        public abstract string Description { get; }
        public DateTime TransactionDate { get; private set; }

        public Transaction()
        {

        }

        protected Transaction(Amount amount)
        {
            Amount = amount;
            TransactionDate = DateTime.Now;
        }

        public void When(CustomerRegisteredDomainEvent domainEvent)
        {
            Id = domainEvent.TransactionId;
            Amount = domainEvent.TransactionAmount;
            TransactionDate = domainEvent.TransactionDate;
        }
    }
}
