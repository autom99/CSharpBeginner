using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDLL;

namespace MyAssembly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.Method();

            Console.WriteLine("Hello");
            Console.Read();
        }
    }
}
