using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Example
{
    /*
     Partial Class :
        We were declaring a class in a single file but Partial class is a feature which allows us to write class across multiple files.
        The partial indicates that the parts of the class, struct, or interface can be defined in the namespace. 
        All the parts must be used with the partial keyword. 
        All the parts must be available at compile time to form the final type or final class. 
        All the parts must have the same accessibility level, such as public, private, protected, and so on.
        If any part of the class is declared abstract, then the whole type is considered to be as abstract.
        If any part is declared sealed, then the whole type is considered to be as sealed.
        If any part declares a base type, then the whole type inherits that class.* 
     */

    #region Simple logic
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        A.A1();
    //        A.A2();
    //        Console.Read();
    //    }
    //}

    //partial class A
    //{
    //    public static void A1()
    //    {
    //        Console.WriteLine("A1");
    //    }
    //}

    //partial class A
    //{
    //    public static void A2()
    //    {
    //        Console.WriteLine("A2");
    //    }
    //}
    #endregion

    #region Realtime example Partial

    class Program
    {
        static void Main(string[] args)
        {
            //Passing parameter partial class Record in Main();
            Record myRecord = new Record(10, 15);
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }


    class File1 { }

    //class Record define as a PARTIAL 
    public partial class Record
    {
        private int h;
        private int w;
        public Record(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
    }

    class File2 { }

    //class Record define as a PARTIAL 
    public partial class Record
    {
        public void PrintRecord()
        {
            Console.WriteLine("Height:" + h);
            Console.WriteLine("Weight:" + w);
        }
    }
    #endregion
}
