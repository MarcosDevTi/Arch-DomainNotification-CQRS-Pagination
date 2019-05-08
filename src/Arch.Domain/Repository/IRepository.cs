using Arch.Cqrs.Contracts.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain.Core;

namespace Arch.Domain.Repository
{
    public interface IRepository<T>
    {
        PagedResult<T> GetAll();
        Customer GetCustomerById(Guid id);
        PagedResult<TReturn> FindCustomers<TReturn>(Specification<T> specification, Paging<T> paging);
    }
}
