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
        public static void Sanitize<T>(DbContext dbToSanitize, DbSet<T> objList, Faker<T> template) where T : class
        {
            var batchNumber = 0;
            var batchSize = 100;

            var batch = objList.Take(batchSize);
            var total = objList.Count();
            var batches = total / batchSize;

            while (batch.Any())
            {
                foreach (var obj in batch)
                {
                    template.Populate(obj);
                }
                batchNumber++;
                batch = objList.Skip(batchNumber * batchSize).Take(batchSize);
                Console.Write($"Completed {((double)batchNumber / (double)batches) * 100.0:##0.00}%, Batch {batchNumber}\r\r\r\r");
            }
        }
    }
}
