using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Example: Array Helper class
            //// defining array with size 5. add values later on
            //int[] intArray1 = new int[5];

            //// defining array with size 5 and adding values at the same time
            //int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            //// defining array with 5 elements which indicates the size of an array
            //int[] intArray3 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(intArray2[0]);
            //Console.WriteLine(intArray3[0]);

            //int[] intArray = new int[5] { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            //string[] strArray1, strArray2;

            //strArray1 = new string[5]{ "1st Element",
            //               "2nd Element",
            //               "3rd Element",
            //               "4th Element",
            //               "5th Element"
            //              };


            //strArray2 = new string[]{ "1st Element",
            //               "2nd Element",
            //               "3rd Element",
            //               "4th Element",
            //               "5th Element"
            //              };

            //Console.WriteLine(strArray1[0]);
            //Console.WriteLine(strArray2[0]);

            //Array array = Array.CreateInstance(typeof(int), new int[1] { 5 }, new int[1] { 1 });

            //array.SetValue(1, 1);
            //array.SetValue(2, 2);
            //array.SetValue(3, 3);
            //array.SetValue(4, 4);
            //array.SetValue(5, 5);

            //for (int i = 1; i <= array.Length; i++)
            //{
            //    Console.WriteLine("Array value {0} at position {1}", array.GetValue(i), i);
            //}

            //Console.ReadLine();

            #endregion

            #region A jagged array is an array of an array. Jagged arrays store arrays instead of any other data type value directly.

            int[][] intJaggedArray = new int[10][];

            intJaggedArray[0] = new int[3] { 1, 2, 3 };

            intJaggedArray[1] = new int[2] { 4, 5 };

            intJaggedArray[2] = new int[1] { 1 };

            Console.Write("intJaggedArray[0][0] is : ");
            Console.Write(intJaggedArray[0][0] + "\n"); // 1

            Console.Write("intJaggedArray[0][2] is : ");
            Console.Write(intJaggedArray[0][2] + "\n"); // 3

            Console.Write("intJaggedArray[1][1] is : ");
            Console.Write(intJaggedArray[1][1] + "\n"); // 5

            Console.Write("intJaggedArray[2][0] is : ");
            Console.Write(intJaggedArray[2][0]); // 1
            Console.ReadKey();

            #endregion
        }
    }
}
