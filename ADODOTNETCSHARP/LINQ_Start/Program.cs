using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
            {
            new Human("Oleg", "Programmer", 30),
            new Human("Nikita", "Director", 27),
            new Human("Ilya", "Programmer", 33),
            new Human("Ivan", "Developer", 23),
            new Human("Kristina", "Manager", 25)
            };
            var result = from human in humans where human.Age > 25 select human;
            foreach (Human h in result)
            {
                Console.WriteLine("Name: {0} \nJob:{1}\nAge:{2}",h.Name,h.Description,h.Age);

            }
            Console.ReadLine();
        }

    }
    class Human
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Age { get; set; }
        public Human(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }


    }
}
