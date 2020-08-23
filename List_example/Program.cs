using System;
using System.Collections.Generic;

namespace List_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Milica", "Bosko", "Stefan" };
            names.Add("Lazar");
            names.Add("Jovana");
            names.Remove("Jovana");
            foreach (var item in names)
            {
                Console.WriteLine($"Hello {item.ToUpper()}!");
            }

            Console.WriteLine(names[1].ToLower());

            var index = names.IndexOf("Bosko");
            //var index = names.IndexOf("Scott");
            if (index == -1)
            {
                Console.WriteLine($"When an index is not found, IndexOf returns {index} \n");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index: {index} \n");
            }

            names.Sort();
            Console.WriteLine("Sorted list".ToUpper() + "\n");

            foreach (var item in names)
            {
                Console.WriteLine(item.ToUpper());
            }
        }
    }
}
