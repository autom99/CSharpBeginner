using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter user name :");
            string name = Console.ReadLine();

            Console.Write("Enter age :");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("User name is {0}\nAge is {1}", name, age);
            Console.Read();

            //Value type to Ref type-Stack to Heap & Heap to Stack.
            int a = 10;
            Object obj = a; //Auto-boxing
            Console.Write("Auto-boxing example int to object is " + obj);

            int b = (int)obj; //Unboxing
            Console.Write("\nUnboxing example object to int is " + b);
            Console.Read();
        }
    }
}
