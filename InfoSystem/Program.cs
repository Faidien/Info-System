using System;
using System.Text.Json;

namespace InfoSystem
{
    internal class Program
    {
        static void Main()
        {
            Person tom = new Person { Name = "Tom", Age = 35 };
            string json = JsonSerializer.Serialize<Person>(tom);
            Console.WriteLine(json);
            Person restorPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restorPerson.Name);
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

}
