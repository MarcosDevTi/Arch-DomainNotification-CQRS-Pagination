using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Arch.Cqrs.Contracts;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Arch.Cqrs.Client.Command.Product
{
    public abstract class ProductCommand : ICommand
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(40)]
        [DisplayName("First Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(2)]
        [MaxLength(250)]
        [DisplayName("Description")]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
