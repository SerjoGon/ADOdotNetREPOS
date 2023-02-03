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
            AddCounter(new Counter(55, "Pork", "140kg", DateTime.Now));
            GetAllCounters();
            Console.ReadLine();
        }
        static void AddCounter(Counter item)
        {
            using (StorageEntities storageEntities = new StorageEntities())
            {
                Counter exist = storageEntities.Counter.Where((x) => x.Id == item.Id).FirstOrDefault();
                if (exist == null)
                {
                    storageEntities.Counter.Add(item);
                    storageEntities.SaveChanges();
                }
            }
        }
        static void GetAllCounters()
        {
            using (StorageEntities storageEntities = new StorageEntities())
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
