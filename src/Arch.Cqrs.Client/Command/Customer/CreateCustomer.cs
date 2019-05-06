using System;
using Arch.Cqrs.Client.Command.Customer.Validation;
using FluentValidation.Results;

namespace Arch.Cqrs.Client.Command.Customer
{
    public class CreateCustomer : CustomerCommand
    {
        //ctor AutoMapper
        public CreateCustomer() { }
        public CreateCustomer(
            string name,
            string lastName,
            string email,
            DateTime birthDate,
            string street,
            string number,
            string city,
            string zipCode, 
            Guid? userId = null)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Street = street;
            Number = number;
            City = city;
            ZipCode = zipCode;
            Id = userId;
        }

        //public override bool IsValid()
        //{
        //    ValidationResult = new CreateCustomerValidation().Validate(this);
        //    return ValidationResult.IsValid;
        //}
    }
}
