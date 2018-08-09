using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 obj1 = new class1();
            class2 obj2 = new class2();
            //Datatype int
            obj1.InvoiceNumber = 123;
            //Datatype object.
            obj2.InvoiceNumber = "123456"; 
        }

        class class1
        {
            public int InvoiceNumber { set; get; }
        }

        class class2 : class1
        {
            public new object InvoiceNumber { set; get; }
        }
    }


}
