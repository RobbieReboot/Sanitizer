﻿using System.Linq;
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
        [ImportMany] private static IEnumerable<ISanitizer> Sanitizers { get; set; }
        private static ContainerConfiguration Container { get; set; }
        private static void Main(string[] args)
        {
            
            Console.WriteLine("███████╗ █████╗ ███╗   ██╗██╗████████╗██╗███████╗███████╗██████╗ ");
            Console.WriteLine("██╔════╝██╔══██╗████╗  ██║██║╚══██╔══╝██║╚══███╔╝██╔════╝██╔══██╗");
            Console.WriteLine("███████╗███████║██╔██╗ ██║██║   ██║   ██║  ███╔╝ █████╗  ██████╔╝");
            Console.WriteLine("╚════██║██╔══██║██║╚██╗██║██║   ██║   ██║ ███╔╝  ██╔══╝  ██╔══██╗");
            Console.WriteLine("███████║██║  ██║██║ ╚████║██║   ██║   ██║███████╗███████╗██║  ██║");
            Console.WriteLine("╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝   ╚═╝   ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝");
            Console.WriteLine("Santitizes & anonymises a database with the Railsmart Schema.\n\n");

            var assemblies = new List<Assembly>() { typeof(Program).GetTypeInfo().Assembly };
//            var pluginFolder = @"C:\GitSouce\Sanitizer\Plugins";
            var pluginFolder = @"..\..\..\..\Plugins";

            try
            {
                var pluginsPath = Path.GetFullPath(pluginFolder);
                var pluginAssemblies = Directory.GetFiles(pluginsPath, "*.dll", SearchOption.AllDirectories)
                    .Select(AssemblyLoadContext.Default.LoadFromAssemblyPath)
                    // Ensure that the assembly contains an implementation for the given type.
                    .Where(s => s.GetTypes().Any(p => typeof(ISanitizer).IsAssignableFrom(p)));
                assemblies.AddRange(pluginAssemblies);
            }
            catch(DirectoryNotFoundException dne)
            {
                Console.WriteLine($"Couldn't load plugins from folder : {pluginFolder}");
                return;
            }
            Container = new ContainerConfiguration()
                .WithAssemblies(assemblies);
            using (var container = Container.CreateContainer())
            {
                Sanitizers = container.GetExports<ISanitizer>();
            }

            Console.WriteLine($"Found {Sanitizers.Count()} sanitizer plugins.\n");
            new Program().run();
        }

        private void run()
        {
            // Catalogs does not exists in Dotnet Core, so you need to manage your own.
            var optionsBuilder = new DbContextOptionsBuilder<RailSmartContext>();
            optionsBuilder
                .UseSqlServer("Server=.\\;Database=RailSmart-DEV-Local-EMT;Trusted_Connection=True;", o => o.CommandTimeout(60));
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            var dbc = new RailSmartContext(optionsBuilder.Options);

            
            foreach (var sanitizer in Sanitizers)
            {
                Console.WriteLine($"Sanitizing {sanitizer.Name}.");
                var total = sanitizer.Sanitize(dbc);
                Console.WriteLine($"{sanitizer.Name}, {total} records.");
            }
        }
    }
} 
