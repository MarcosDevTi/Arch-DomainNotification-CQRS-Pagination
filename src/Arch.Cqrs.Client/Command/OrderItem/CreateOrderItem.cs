using System;
using Arch.Cqrs.Contracts;
using FluentValidation.Results;

namespace Arch.Cqrs.Client.Command.OrderItem
{
    public class CreateOrderItem : ICommand
    {
        public CreateOrderItem()
        {
            
        }
        public CreateOrderItem(Guid productId, int qtd)
        {
            ProductId = productId;
            Qtd = qtd;
        }
        public Guid ProductId { get; set; }
        public int Qtd { get; set; }
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
