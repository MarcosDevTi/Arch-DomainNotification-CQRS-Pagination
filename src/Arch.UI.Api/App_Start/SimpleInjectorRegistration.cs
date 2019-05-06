using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Arch.Infra.IoC;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace Arch.UI.Api.App_Start
{
    public class SimpleInjectorInitializer
    {
        private static Container _container;

        public static void Initialize(Container container)
        {
            _container = container;

            InitializeContainer();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(_container));
        }

        private static void InitializeContainer()
        {
            ArchBootstrapper.Register(_container);
        }
    }
}