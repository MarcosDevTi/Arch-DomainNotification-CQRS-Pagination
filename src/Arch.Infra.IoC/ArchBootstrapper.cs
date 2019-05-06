using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Arch.Cqrs.Client.Command.Customer;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Contracts.AutoMapper;
using Arch.Cqrs.Contracts.DomainNotifications;
using Arch.Cqrs.Handlers;
using Arch.Infra.Data;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace Arch.Infra.IoC
{
    public class ArchBootstrapper
    {
        public static Container MyContainer { get; set; }
        public static void Register(Container container)
        {
            MyContainer = container;

            container.Register<IProcessor, Processor>(Lifestyle.Transient);
            container.Register<ArchDbContext>(Lifestyle.Scoped);

            container.AddCqrs<CustomerCommandHandler>();
            container.Register<NotificationContext>(Lifestyle.Scoped);
            container.Register<InMemoryDatabaseContext>(Lifestyle.Singleton);

            AutoMapperConfig.Register<CreateCustomer>();
        }
    }
}
