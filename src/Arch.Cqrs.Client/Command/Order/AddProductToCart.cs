using System;
using Arch.Cqrs.Contracts;
using FluentValidation.Results;

namespace Arch.Cqrs.Client.Command.Order
{
    public class AddProductToCart : ICommand
    {
        public AddProductToCart(Guid productId, Guid userId)
        {
            ProductId = productId;
            UserId = userId;
        }

        public Guid ProductId { get; private set; }
        public Guid UserId { get; private set; }
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
