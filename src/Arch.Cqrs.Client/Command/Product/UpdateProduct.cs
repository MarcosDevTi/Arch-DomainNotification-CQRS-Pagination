using System;
using Arch.Cqrs.Client.Command.Product.Validation;

namespace Arch.Cqrs.Client.Command.Product
{
    public class UpdateProduct : ProductCommand
    {
        public UpdateProduct() { }
        protected UpdateProduct(Guid id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
