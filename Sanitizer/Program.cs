using System.Linq;
using System;
using Bogus;
using CountryData;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using Microsoft.EntityFrameworkCore;
using Sanitizer;
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

            if (args.Length != 2)
            {
                Console.WriteLine("Usage:\n");
                Console.WriteLine("        sanitizer <server> <database-name>:\n");
                return;
            }

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
            catch(DirectoryNotFoundException)
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
            new Program().run(args);
        }

        private void run(string[] args)
        {
            // Catalogs does not exists in Dotnet Core, so you need to manage your own.
            var optionsBuilder = new DbContextOptionsBuilder<RailSmartContext>();
            optionsBuilder
                .UseSqlServer($"Server={args[0]};Database={args[1]};Trusted_Connection=True;MultipleActiveResultSets=true", o => o.CommandTimeout(120));
            Sanitizer.SanitizerUtil.DbContextOptions = optionsBuilder.Options;

            List<Tuple<string,TimeSpan,int>> timings = new List<Tuple<string, TimeSpan, int>>(Sanitizers.Count());
            var ctx = new RailSmartContext(optionsBuilder.Options);
            foreach (var sanitizer in Sanitizers)
            {
                var timeTaken = new Stopwatch();
                timeTaken.Start();
                Console.WriteLine($"Sanitizing {sanitizer.Name}.");
                int total = sanitizer.Sanitize();
                timeTaken.Stop();
                Console.WriteLine($"{sanitizer.Name}, {total} records sanitized in {timeTaken.Elapsed.Minutes:D}m {timeTaken.Elapsed.Seconds:D}s.");
                timings.Add(new Tuple<string, TimeSpan, int>(sanitizer.Name.Elipsize(32),timeTaken.Elapsed,total));
            } 

            var col1 = "Sanitizer";
            var col2 = "Time taken";
            var col3 = "Records"; 

            Console.WriteLine($"\n\n{col1,-32} {col2,-16} {col3,-12}");
            Console.WriteLine($"{new string('=',32)} {new string('=', 16)} {new string('=', 12)}");
            foreach (var t in timings)
            {
                var tm = $"{t.Item2.Minutes:00}:{t.Item2.Seconds:00}:{t.Item2.Milliseconds:000}";
                Console.WriteLine($"{t.Item1,-32} {tm,16} {t.Item3,12}");
            }
        }
    }
} 
