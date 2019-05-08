using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain.Core;
using Arch.Domain.Specifications;
using FluentValidation;

namespace Arch.Domain.Validations
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            var maxLengthName = 2;
            var ofAge = new CustomerOfAge();
            RuleFor(c => c.BirthDate)
                .Must(UnderAge)
                .WithMessage("The customer must have 18 years or more");
            RuleFor(c => c.Name)
                .MinimumLength(maxLengthName)
                .WithMessage($"Minimum Length {maxLengthName}");
        }

        private bool UnderAge(DateTime date) => 
            date < DateTime.Now.AddYears(-18);
    }
}
