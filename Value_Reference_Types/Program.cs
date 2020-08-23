using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mixedList = new List<object>
            {
                "First string!"
            };

            for (int i = 0; i < 5; i++)
            {
                mixedList.Add(i);
            }

            mixedList.Add("Another string ");
            for (int i = 0; i < 10; i++)
            {
                mixedList.Add(i);
            }

            // Displaying elements in the lsit 
            foreach (var item in mixedList)
            {
                Console.WriteLine(item);
            }

            var sum = 0;

            sum += (int)mixedList.Count * (int)mixedList.Count;

            Console.WriteLine("Sum: " + sum);

            Console.WriteLine();

        }
    }
}
