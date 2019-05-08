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
    public class Repository<T>: IRepository<T>
    {
        private readonly ArchDbContext _context;

        public Repository(ArchDbContext context)
        {
            _context = context;
        }
        public PagedResult<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        public PagedResult<TReturn> FindCustomers<TReturn>(Specification<T> specification, Paging<T> paging)
        {
            throw new NotImplementedException();
        }
    }
}
