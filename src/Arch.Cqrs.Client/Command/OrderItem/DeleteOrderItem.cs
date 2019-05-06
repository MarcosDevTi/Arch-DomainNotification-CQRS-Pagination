using System;
using Arch.Cqrs.Contracts;
using FluentValidation.Results;

namespace Arch.Cqrs.Client.Command.OrderItem
{
    public class DeleteOrderItem : ICommand
    {
        public DeleteOrderItem(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
