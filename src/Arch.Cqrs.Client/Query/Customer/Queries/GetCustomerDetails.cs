using System;
using Arch.Cqrs.Client.Query.Customer.Models;
using Arch.Cqrs.Contracts;

namespace Arch.Cqrs.Client.Query.Customer.Queries
{
    public class GetCustomerDetails : IQuery<CustomerDetails>
    {
        public GetCustomerDetails(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }

    }
}
