using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain.Core;

namespace Arch.Domain
{
    public class Order: Entity
    {
        protected Order() { }
        public DateTime OrderDate { get; set; }
    }
}
