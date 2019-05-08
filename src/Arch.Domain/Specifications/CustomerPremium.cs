using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain.Core;

namespace Arch.Domain.Specifications
{
    public class CustomerPremium: Specification<Customer>
    {
        public override Expression<Func<Customer, bool>> ToExpression() =>
            customer => customer.SubscriptionDate < DateTime.Now.AddYears(-4) && customer.Orders.Count() > 30;
    }

    public class CustomerOfAge: Specification<Customer>
    {
        public override Expression<Func<Customer, bool>> ToExpression() =>
            customer => customer.BirthDate < DateTime.Now.AddYears(-18);
    }
}
