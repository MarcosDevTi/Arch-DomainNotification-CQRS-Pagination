using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Arch.Cqrs.Contracts;
using Arch.Cqrs.Handlers;
using SimpleInjector;

namespace Arch.Infra.IoC
{
    public static class CqrsExtensions
    {
        public static void AddCqrs<T>(this Container container, Func<AssemblyName, bool> filter = null)
        {
            var handlers = new[] { typeof(IQueryHandler<,>), typeof(ICommandHandler<>) };
            var target = typeof(T).Assembly;
            bool FilterTrue(AssemblyName x) => true;

            var assemblies = target.GetReferencedAssemblies()
                .Where(filter ?? FilterTrue)
                .Select(Assembly.Load)
                .ToList();
            assemblies.Add(target);

            var types = from t in assemblies.SelectMany(a => a.GetExportedTypes())
                        from i in t.GetInterfaces()
                where i.IsConstructedGenericType &&
                      handlers.Contains(i.GetGenericTypeDefinition())
                select new { i, t };

            foreach (var tp in types)
                container.Register(tp.i, tp.t, Lifestyle.Transient);
        }
    }

    
}
