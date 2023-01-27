using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLStartLINK
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price{ get; set; }

        public Product(int id, string name, int price) 
        {
            Id = id;    
            Name = name;
            Price = price;
        }
        public override string ToString() 
        {
            return Id.ToString() + " " + Name + " "  + Price.ToString() + " rub";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqToSqlDataContext db = new LinqToSqlDataContext();
            var queryResults = from c in db.Goods
                               where c.Count > 1
                               select new Product (  c.Id,  c.Name, c.Price );
            var queryResults1 = from c in db.Goods
                               where c.Count > 1
                               select new {Id = c.Id, Name = c.Name, Price = c.Price};
            var queryResults2 =  db.Goods.Where(c => c.Count > 1).Select(c => new Product(c.Id, c.Name, c.Price));
            
            foreach (var item in queryResults)
            {
                    Console.WriteLine(item);
            }
            foreach (var item in queryResults1)
            {
                    Console.WriteLine(item);
            }
            foreach (var item in queryResults2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any key to complete...");
            Console.ReadLine();
        }
    }
}
