using Arch.Cqrs.Client.Query.OrderItem.Models;
using Arch.Cqrs.Contracts;

namespace Arch.Cqrs.Client.Query.OrderItem.Queries
{
    public class GetCart : IQuery<Cart>
    {
    }
}
