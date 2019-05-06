using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain;

namespace Arch.Infra.Data
{
    public class InMemoryDatabaseContext
    {
        public ISet<Customer> Customers { get; } = new HashSet<Customer>();
    }
}
