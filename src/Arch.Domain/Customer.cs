using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain.Core;
using Arch.Domain.Validations;

namespace Arch.Domain
{
    public class Customer : Entity
    {
        protected Customer(DateTime subscriptionDate)
        {
            SubscriptionDate = subscriptionDate;
        } // Empty constructor for EF

        public Customer(string name, string email, DateTime birthDate, DateTime subscriptionDate, Guid? id = null)
        {
            Id = id == null ? Guid.NewGuid() : Id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            SubscriptionDate = subscriptionDate;
            Validate(this, new CustomerValidator());
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime SubscriptionDate { get; private set; }
        public ICollection<Order> Orders { get; private set; }
    }
}
