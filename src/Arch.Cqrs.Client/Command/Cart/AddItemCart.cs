using System;
using Arch.Cqrs.Contracts;
using FluentValidation.Results;

namespace Arch.Cqrs.Client.Command.Cart
{
    public class AddItemCart : ICommand
    {
        public AddItemCart(Guid orderItemId, int value)
        {
            Value = value;
            OrderItemId = orderItemId;
        }

        public int Value { get; private set; }

        public Guid OrderItemId { get; private set; }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
