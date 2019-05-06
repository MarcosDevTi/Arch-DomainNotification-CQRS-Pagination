﻿using Arch.Cqrs.Client.Command.Product.Validation;

namespace Arch.Cqrs.Client.Command.Product
{
    public class CreateProduct : ProductCommand
    {
        public CreateProduct(){}

        protected CreateProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
