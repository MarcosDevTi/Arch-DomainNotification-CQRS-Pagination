using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Cqrs.Contracts.Paging;
using Arch.Domain;
using Arch.Domain.Core;
using Arch.Domain.Repository;

namespace Arch.Infra.Data.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ArchDbContext _context;

        public CustomerRepository(ArchDbContext context)
        {
            _context = context;
        }

        public PagedResult<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        public PagedResult<Customer> FindCustomers(Specification<Customer> specification, Paging<Customer> paging) =>
            _context.Customers.Where(specification.ToExpression()).GetPagedResult(paging);
    }
}
