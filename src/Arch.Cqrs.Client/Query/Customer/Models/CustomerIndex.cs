using System;
using Arch.Cqrs.Contracts.AutoMapper;

namespace Arch.Cqrs.Client.Query.Customer.Models
{
    public class CustomerIndex: IMapFrom<Domain.Customer>

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
