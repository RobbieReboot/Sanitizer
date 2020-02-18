using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Sanitizer
{
    public static class SanitizerUtil
    {
        public static DbContextOptions DbContextOptions { get; set; }
        public static async Task<int> SanitizeAsync<T,TContext>(
            Func<TContext, DbSet<T>> dbSet,
            Faker<T> template,
            int batchSize) where T : class where TContext : class, new()
        {
            int total = 0;
            using (var context = (IDisposable)((TContext)Activator.CreateInstance(typeof(TContext), DbContextOptions)))
            {
                total = dbSet((TContext)context).Count();
            }

            var batchNumber = 0;
            double batches = Math.Round((double)total / batchSize,MidpointRounding.ToPositiveInfinity);
            int totalRecords = 0;
            Console.WriteLine($"{total} records.");
            bool more = true;
            do
            {
//                using (var context = (IDisposable)new TContext(DbContextOptions))
                using (var context = (IDisposable)((TContext)Activator.CreateInstance(typeof(TContext), DbContextOptions)))
                {
                    var set = dbSet((TContext) context);
                    var currentBatch = set.Skip(batchNumber * batchSize).Take(batchSize);
                    foreach (var obj in currentBatch)
                        template.Populate(obj);

                    batchNumber++;
                    totalRecords += await ((DbContext) context).SaveChangesAsync();
                    Console.Write($"Completed {((double) totalRecords/ (double) total) * 100.0:##0.00}%, Batch {batchNumber:###}/{batches:###}\r");
                    more = currentBatch.Count() == batchSize;
                }
            } while (more);
            Console.Write($"Completed {((double)totalRecords / (double)total) * 100.0:##0.00}%, Batch {batchNumber:###}/{batches:###}\n");

            return totalRecords;
        }

        /// <summary>
        /// This Sanitize method takes a DbContext where another table has been '.Include'-ed. If the faker uses navigation properties, this other table MUST be passed in the method call.
        /// </summary>
        /// <typeparam name="T">Main Table</typeparam>
        /// <typeparam name="T1">Included table</typeparam>
        /// <typeparam name="TContext">Context type</typeparam>
        /// <param name="dbSet">Lambda provided to query for the DbSet.</param>
        /// <param name="template">Faker Template to apply to each object</param>
        /// <param name="batchSize">How many object to process at per call.</param>
        /// <remarks>
        /// The batchsize is defaulted to 1000 objects per query and the context is disposed after each batch reducing memory consumption.
        /// </remarks>
        /// <returns></returns>
        public static async Task<int> SanitizeAsync<T,T1, TContext>(
            Func<TContext, IIncludableQueryable<T,T1>> dbSet,
            Faker<T> template,
            int batchSize) where T : class where T1 : class where TContext : class, new()
        {

            int total = 0;
            using (var context = (IDisposable)new TContext())
            {
                total = dbSet((TContext)context).Count();
            }

            var batchNumber = 0;
            double batches = Math.Round((double)total / batchSize, MidpointRounding.ToPositiveInfinity);
            int totalRecords = 0;
            Console.WriteLine($"{total} records.");
            bool more = true;
            do
            {
                using (var context = (IDisposable)new TContext())
                {
                    var set = dbSet((TContext)context);
                    var currentBatch = set.Skip(batchNumber * batchSize).Take(batchSize);
                    foreach (var obj in currentBatch)
                        template.Populate(obj);

                    batchNumber++;
                    totalRecords += await ((DbContext)context).SaveChangesAsync();
                    Console.Write($"Completed {((double)totalRecords / (double)total) * 100.0:##0.00}%, Batch {batchNumber:###}/{batches:###}\r");
                    more = currentBatch.Count() == batchSize;
                }
            } while (more);
            Console.Write($"Completed {((double)totalRecords / (double)total) * 100.0:##0.00}%, Batch {batchNumber:###}/{batches:###}\n");

            return totalRecords;
        }



    }
}
