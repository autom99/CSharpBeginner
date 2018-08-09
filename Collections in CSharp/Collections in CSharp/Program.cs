using System;
using System.Collections.Generic;

namespace Collections_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();

            names.Add("Maria"); //Add element in collection List.
            names.Add("Bill");
            names.Remove("Ana");
            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
                Console.WriteLine($"Hello {name.ToLower()}!");
                Console.WriteLine();
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine();

            Console.WriteLine($"The list has {names.Count} people in it");
            Console.WriteLine();

            /* Fibonaci Series */
            Console.WriteLine("************* Fibonaci Series ***************");
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
