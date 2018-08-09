using System;
using System.IO;
using System.Threading;

/* Refer msn doc link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/ */

namespace Operator_Example
{
    public class Program
    {
        static Type _type = typeof(char);

        public static void Main(string[] args)
        {
            #region Simple + Operator 
            //string message1 = "Hello";
            //string message2 = message1 + " World!!";
            //Console.WriteLine(message2);

            //int i = 10, j = 20;
            //int sum = i + j;
            //Console.WriteLine("{0} + {1} = {2} \n", i, j, sum); 
            #endregion

            #region "+" "-" "*" "%" Operator
            //Console.WriteLine(+5);        // unary plus
            //Console.WriteLine(5 + 5);     // addition
            //Console.WriteLine(5 + .5);    // addition
            //Console.WriteLine("5" + "5"); // string concatenation
            //Console.WriteLine(5.0 + "5"); // string concatenation// note automatic conversion from double to string 

            //int a = 5;
            //Console.WriteLine(-a);
            //Console.WriteLine(a - 1);
            //Console.WriteLine(a - .5);

            //Console.WriteLine(5 * 2);
            //Console.WriteLine(-.5 * .2);
            //Console.WriteLine(-.5m * .2m); // decimal type

            //Console.WriteLine("\nDividing 7 by 3.");
            //// Integer quotient is 2, remainder is 1.
            //Console.WriteLine("Integer quotient:           {0}", 7 / 3);
            //Console.WriteLine("Negative integer quotient:  {0}", -7 / 3);
            //Console.WriteLine("Remainder:                  {0}", 7 % 3);
            //// Force a floating point quotient.
            //float dividend = 7;
            //Console.WriteLine("Floating point quotient:    {0}", dividend / 3);

            //Console.WriteLine("\nDividing 8 by 5.");
            //// Integer quotient is 1, remainder is 3.
            //Console.WriteLine("Integer quotient:           {0}", 8 / 5);
            //Console.WriteLine("Negative integer quotient:  {0}", 8 / -5);
            //Console.WriteLine("Remainder:                  {0}", 8 % 5);
            //// Force a floating point quotient.
            //Console.WriteLine("Floating point quotient:    {0}", 8 / 5.0);

            //Console.WriteLine(5 % 2);       // int
            //Console.WriteLine(-5 % 2);      // int
            //Console.WriteLine(5.0 % 2.2);   // double
            //Console.WriteLine(5.0m % 2.2m); // decimal
            //Console.WriteLine(-5.2 % 2.0);  // double

            //Console.WriteLine(!true);
            //Console.WriteLine(!false);

            #endregion

            #region Pre-Post-Increment,Decrement,Precedent
            //int x = 10;
            //Console.Write("Old value of x is : {0} \n", x);

            //Console.Write("7 + 3 * 2 is : ");
            //Console.WriteLine(7 + 3 * 2);

            //++x; //x = x+1
            //Console.Write("New value of ++x is : {0} \n", x);

            //--x; //x = x-1
            //Console.Write("New value of --x is : {0} \n", x);

            //x++;
            //Console.Write("New value of x++ is : {0} \n", x);

            //x--;
            //Console.Write("New value of x-- is : {0} \n", x); 
            #endregion

            #region For as Infinite loop 
            //for (;;)
            //{
            //    Console.WriteLine("Hey! I am Trapped");
            //} 
            #endregion

            #region Increment-Decrement operator difference

            //int varTest = 5;

            //if (++varTest == 6)
            //{
            //    Console.WriteLine("This will be executed.");
            //}
            //if (varTest++ == 7)
            //{
            //    Console.WriteLine("This won't.");
            //}
            #endregion

            #region Ternury Operator '?'
            //int x = 1;
            //string s = x.ToString() + " ";
            //s += (x == 1 ? "Male" : "Female");
            //Console.WriteLine(s);

            //int varX = 20, varY = 10;
            //var result = varX > varY ? varX : varY;
            //Console.WriteLine(result);
            #endregion

            #region Ternary operator replaces if statement
            //int varA = 20, varB = 10;
            //int varResult = 0;

            //if (varA > varB)
            //    varResult = varA;
            //else if (varA < varB)
            //    varResult = varB;
            //Console.WriteLine(varResult); 
            #endregion

            #region Checked-Unchecked Example

            ////By default: UNCHECKED 
            //byte b = 255;
            //b++;
            //Console.WriteLine(b.ToString());

            //int val = int.MaxValue;
            //Console.WriteLine(val + 2);

            //// The following example causes compiler error CS0220 because 2147483647
            //// is the maximum value for integers. 
            ////int i1 = 2147483647 + 10;

            //// The following example, which includes variable ten, does not cause
            //// a compiler error.
            //int ten = 10;
            //unchecked
            //{
            //    int i2 = 2147483647 + ten;
            //    // By default, the overflow in the previous statement also does
            //    // not cause a run-time exception. The following line displays 
            //    // -2,147,483,639 as the sum of 2,147,483,647 and 10.
            //    Console.WriteLine(i2);
            //}

            //try
            //{
            //    int[] arr = new int[5];
            //    arr[10] = 25;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region Simple is Operator
            //object i = 10;
            //if (i is int)
            //{
            //    Console.WriteLine("i is int");
            //}
            #endregion

            #region is,As Operator Real time Example

            //#region Class:Student-Employee for "is" Operator
            ////Class:Student-Employee for "is" Operator
            //Student stuObj = new Student();
            //stuObj.stuNo = 1;
            //stuObj.Name = "Praveen";
            //stuObj.Age = 15;

            //Employee EMPobj = new Employee();
            //EMPobj.EmpNo = 20;
            //EMPobj.Name = "Rajesh";
            //EMPobj.Salary = 100000;
            //EMPobj.Age = 25;

            ////"is" operator checked in object
            //System.Console.WriteLine("Empobj is a Student ?: {0}", CheckAndConvertobject(EMPobj));
            //System.Console.WriteLine("StuObj is a Student ?: {0}", CheckAndConvertobject(stuObj));
            //#endregion

            //#region Class:ClassA-ClassB for As Operatoron
            //object[] objArray = new object[6];
            //objArray[0] = new ClassA();
            //objArray[1] = new ClassB();
            //objArray[2] = "hello";
            //objArray[3] = 123;
            //objArray[4] = 123.4;
            //objArray[5] = null;

            //for (int i = 0; i < objArray.Length; ++i)
            //{
            //    //"As" operator checked in object.
            //    string s = objArray[i] as string;
            //    Console.Write("{0}:", i);
            //    if (s != null)
            //    {
            //        Console.WriteLine("'" + s + "'");
            //    }
            //    else
            //    {
            //        Console.WriteLine("not a string");
            //    }
            //} 
            //#endregion

            #endregion

            #region sizeof Example

            ////string b = "SizeOfString"; //Properties in Project-Check unsafe mode for Non-primitive data type size display.
            //Console.WriteLine("***************** Basic type sizes *******************");
            //Console.WriteLine("Size of int is :" + sizeof(int)); //4
            //Console.WriteLine("Size of char is :" + sizeof(char));
            //Console.WriteLine("Size of float is :" + sizeof(float));
            //Console.WriteLine("Size of long is :" + sizeof(long));
            //Console.WriteLine("Size of double is :" + sizeof(double));
            //Console.WriteLine("Size of uint is :" + sizeof(uint));
            //Console.WriteLine("Size of decimal is :" + sizeof(decimal));
            //Console.WriteLine("Size of bool is :" + sizeof(bool));
            //Console.WriteLine("Size of byte is :" + sizeof(byte));
            //Console.WriteLine("Size of Int16 is :" + sizeof(Int16));
            //Console.WriteLine("Size of Int32 is :" + sizeof(Int32));
            //Console.WriteLine("Size of Int64 is :" + sizeof(Int64)); 

            #endregion

            //int i = 0;
            //System.Type type = i.GetType();

            Console.WriteLine(_type); //System.char
            Console.WriteLine(typeof(int)); // Value type
            Console.WriteLine(typeof(byte)); // Value type
            Console.WriteLine(typeof(Stream)); // Class type
            Console.WriteLine(typeof(TextWriter)); // Class type
            Console.WriteLine(typeof(Array)); // Class type
            Console.WriteLine(typeof(int[])); // Array reference type
            Console.WriteLine(typeof(Thread)); //System.Threading.Thread

            int userInput;

            Console.WriteLine(@"""Press any key to continue...""");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.WriteLine("Ascii Value = {0}", userInput);
            Console.ReadKey();

        }

        #region Class:ClassA-ClassB for As Operator
        ////Class:ClassA-ClassB for As Operator
        //class ClassA { }

        //class ClassB { }
        #endregion

        #region Class:Student-Employee for is Operator
        //Class:Student-Employee for is Operator
        //Sample Student Class
        //class Student
        //{
        //    public int stuNo { get; set; }
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}

        //Sample Employee Class
        class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
        }
        #endregion

        #region Use of "is" operator :Method for checking object type "is"
        ////Use of "is" operator :Method for checking object type "is"
        //public static string CheckAndConvertobject(dynamic obj)
        //{
        //    //If obj is Type student it asign value to Stuobj else it asign null
        //    Student stuobj = obj as Student;
        //    if (stuobj != null)
        //        return "This is a Student and his name is " + stuobj.Name;

        //    return "Not a Student,May be Employee?";
        //} 
        #endregion
    }
}
