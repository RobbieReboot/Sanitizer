using System.Linq;
using System;
using Bogus;
using CountryData;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using Microsoft.EntityFrameworkCore;
using Sanitizer.Contracts;
using Sanitizer.Model;

namespace anon
{
    class Program
    {
        //[ImportMany]
        //public List<Lazy<ISanitizer>> AllSanitizers { get; set; }
        [ImportMany] private IEnumerable<ISanitizer> Sanitizers { get; set; }
        private static ContainerConfiguration Container { get; set; }
        private static void Main(string[] args)
        {
            var assemblies = new List<Assembly>() { typeof(Program).GetTypeInfo().Assembly };
            var pluginAssemblies = Directory.GetFiles(@"C:\GitSouce\Sanitizer\Plugins\netcoreapp3.1", "*.dll", SearchOption.TopDirectoryOnly)
                .Select(AssemblyLoadContext.Default.LoadFromAssemblyPath)
                // Ensure that the assembly contains an implementation for the given type.
                .Where(s => s.GetTypes().Any(p => typeof(ISanitizer).IsAssignableFrom(p)));
            assemblies.AddRange(pluginAssemblies);
            Container = new ContainerConfiguration()
                .WithAssemblies(assemblies);

            new Program().run();
        }

        private void run()
        {
            // Catalogs does not exists in Dotnet Core, so you need to manage your own.
            using (var container = Container.CreateContainer())
            {
                Sanitizers = container.GetExports<ISanitizer>();
            }

            var optionsBuilder = new DbContextOptionsBuilder<RailSmartContext>();
            optionsBuilder
                .UseSqlServer("Server=.\\;Database=RailSmart-DEV-Local-EMT;Trusted_Connection=True;", o => o.CommandTimeout(60));
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            var dbc = new RailSmartContext(optionsBuilder.Options);

            
            foreach (var sanitizer in Sanitizers)
            {
                sanitizer.Sanitize(dbc);
            }
        }
    }
}
