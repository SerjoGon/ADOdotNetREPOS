using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWtwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddCounter(new Counter(50,"NewCounter","1000",DateTime.Now));
            GetAllCounters();
            Console.ReadLine();
        }
        static void AddCounter(Counter item)
        {
            using (StorageEntities storageEntities = new StorageEntities())
            {
                storageEntities.Counter.Add(item);
                storageEntities.SaveChanges();
            }
        }
        static void GetAllCounters()
        {
            using(StorageEntities storageEntities = new StorageEntities())
            {
                List<Counter> counters = storageEntities.Counter.ToList();
                foreach (Counter item in counters)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
