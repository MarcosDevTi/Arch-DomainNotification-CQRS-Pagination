using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Domain;

namespace Arch.Infra.Data
{
    public class ArchDbContext: DbContext
    {
        public ArchDbContext():base("DefaultConnection")
        {
            
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Ignore(customer => customer.ValidationResult)
                .Ignore(customer => customer.Valid);
        }


    }
}
