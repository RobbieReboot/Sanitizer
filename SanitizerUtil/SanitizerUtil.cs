using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Sanitizer
{
    public static class SanitizerUtil
    {
        public static async System.Threading.Tasks.Task<int> SanitizeAsync<T>(DbContext context, DbSet<T> objList, Faker<T> template,int batchSize = 100) where T : class
        {
            context.ChangeTracker.LazyLoadingEnabled = false;
            var batchNumber = 0;
            var batch = objList.Take(batchSize);
            var total = objList.Count();
            var batches = total / batchSize;
            int totalRecords = 0;
            Console.WriteLine($"{total} records.");
            while (batch.Any())
            {
                foreach (var obj in batch)
                {
                    template.Populate(obj);
                }
                batchNumber++;
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
                Console.Write($"Completed {((double)batchNumber / (double)batches) * 100.0:##0.00}%, Batch {batchNumber:#####}\r");
                totalRecords += await context.SaveChangesAsync();
            }
            return totalRecords;
        }
    }
}
