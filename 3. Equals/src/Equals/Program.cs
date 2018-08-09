using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            object obj = ".Net interview content";
            //object obj1 = obj;
            object obj1 = new string(".Net interview content".ToCharArray());

            Console.Write("Comaprision with == & equals with object\n");
            Console.WriteLine(obj == obj1);
            Console.WriteLine(obj.Equals(obj1));

            Console.Write("Comaprision with == & equals with String\n");

            string str = "String content comparision";
            //object obj1 = obj;
            string str1 = new string("String content comparision".ToCharArray());

            Console.WriteLine(str == str1);
            Console.WriteLine(str.Equals(str1));
            Console.ReadLine();
        }
    }
}
