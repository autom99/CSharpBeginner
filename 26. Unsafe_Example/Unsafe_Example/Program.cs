using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Open the properties for the project, go to the Build tab and check the Allow unsafe code checkbox.
*/

namespace Unsafe_Example
{
    //#region MyRegion
    //// compile with: -unsafe

    //class UnsafeTest
    //{
    //    // Unsafe method: takes pointer to int:
    //    unsafe static void SquarePtrParam(int* p)
    //    {
    //        *p *= *p;
    //    }

    //    unsafe static void Main()
    //    {
    //        int i = 5;
    //        // Unsafe method: uses address-of operator (&):
    //        SquarePtrParam(&i);
    //        Console.WriteLine(i);
    //    }
    //}
    //// Output: 25 
    //#endregion

    class Program
    {
        class myclass
        {
            public static void Main(string[] args)
            {
                unsafe
                {
                    int iData = 10;
                    int* pData = &iData;
                    Console.WriteLine("Data is " + iData);
                    Console.WriteLine("Address is " + (int)pData);
                    Console.ReadLine();
                }
            }
        }
    }
}
