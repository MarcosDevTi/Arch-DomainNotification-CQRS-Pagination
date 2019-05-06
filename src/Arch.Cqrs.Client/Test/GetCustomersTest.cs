using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Cqrs.Contracts;

namespace Arch.Cqrs.Client.Test
{
    public class GetCustomersTest: IQuery<IReadOnlyList<CustomerItemTest>>
    {
        public int Take { get; set; }
    }
}
