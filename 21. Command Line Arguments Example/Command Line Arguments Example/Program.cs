using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Arguments_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Command line arguments  
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }

    }
}
