using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Cqrs.Contracts.Paging;
using Arch.Domain.Core;

namespace Arch.Domain.Repository
{
    public interface ICustomerRepository
    {
        PagedResult<Customer> GetAll();
        Customer GetCustomerById(Guid id);
        PagedResult<Customer> FindCustomers(Specification<Customer> specification, Paging<Customer> paging);
    }
}
