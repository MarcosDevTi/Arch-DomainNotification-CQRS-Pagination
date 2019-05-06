using System;
using Arch.Cqrs.Client.Command.Product;

namespace Arch.Cqrs.Client.Query.Product.Models
{
    public class ProductDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
