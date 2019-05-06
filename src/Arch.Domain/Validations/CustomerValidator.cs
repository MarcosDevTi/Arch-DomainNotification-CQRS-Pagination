using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Arch.Domain.Validations
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.BirthDate)
                .Must(UnderAge)
                .WithMessage("The customer must have 18 years or more");
        }

        private bool UnderAge(DateTime date) => 
            date < DateTime.Now.AddYears(-18);
    }
}
