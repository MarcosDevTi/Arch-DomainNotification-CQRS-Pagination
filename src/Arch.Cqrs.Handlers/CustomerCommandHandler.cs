﻿using System;
using System.Linq;
using Arch.Cqrs.Client.Command.Customer;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Contracts.DomainNotifications;
using Arch.Domain;
using Arch.Infra.Data;

namespace Arch.Cqrs.Handlers
{
    public class CustomerCommandHandler:
        ICommandHandler<CreateCustomer>
    {
        private readonly NotificationContext _notificationContext;
        private readonly ArchDbContext _databaseContext;
        public CustomerCommandHandler(NotificationContext notificationContext, ArchDbContext databaseContext)
        {
            _notificationContext = notificationContext;
            _databaseContext = databaseContext;
        }

        public void Handle(CreateCustomer command)
        {
            var customer = new Customer(command.Name, command.Email, command.BirthDate, command.SubscriptionDate);

            if (customer.Invalid)
            {
                _notificationContext.AddNotifications(customer.ValidationResult);
            }
            if (_databaseContext.Customers.Any(c => c.Email == command.Email))
            {
                _notificationContext.AddNotification("Email", "Email already exists");
            }
            else
            {
                _databaseContext.Customers.Add(customer);
                _databaseContext.SaveChanges();
            }
        }
    }
}
