using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Cqrs.Client.Query.Customer.Models;
using Arch.Cqrs.Client.Query.Customer.Queries;
using Arch.Cqrs.Client.Test;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Contracts.Paging;
using Arch.Infra.Data;

namespace Arch.Cqrs.Handlers
{
    public class CustomerQueryHandler: IQueryHandler<GetCustomersIndex, PagedResult<CustomerIndex>>
    {
        private readonly ArchDbContext _context;

        public CustomerQueryHandler(ArchDbContext context)
        {
            _context = context;
        }

        public PagedResult<CustomerIndex> Handle(GetCustomersIndex query)
        {
            return _context.Customers.GetPagedResult(query.Paging);
        }
    }
}
