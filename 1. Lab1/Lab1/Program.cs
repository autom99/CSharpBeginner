using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = string.Empty;
                Console.WriteLine("Enter name :");
                name = Console.ReadLine();

                if (name.Length == 0)
                {
                    Console.WriteLine("Name is required.");
                    Console.Read();
                    return;
                }

                int age = 0;
                Console.WriteLine("Enter age :");
                age = Convert.ToInt16(Console.ReadLine());
                if (age <18)
                {
                    Console.WriteLine("Not eligible,only >18 can access.");
                    Console.Read();
                    return;
                }
                Console.WriteLine("Hello," + "Your name is: " + "\n" + name + "\n" + "Your age is : " + "\n" + age);
                Console.Read();
            }
            catch
            {
                Console.WriteLine("Please try..invalid data");
                Console.Read();
            }
        }
    }
}
