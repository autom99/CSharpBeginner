using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Example
{
    /*ABOUT STRUCTURE
     * 
     In C#, classes and structs are blueprints that are used to create instance of a class. 
     Structs are used for lightweight objects such as Color, Rectangle, Point etc.
     Unlike class, structs in C# are value type than reference type. 
     It is useful if you have data that is not intended to be modified after creation of struct.

     Note: Struct doesn't support inheritance. But it can implement interfaces.
    */

    #region C# Struct Example
    //public struct Rectangle
    //{
    //    public int width, height;
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle rect = new Rectangle();
    //        rect.height = 12;
    //        rect.width = 12;
    //        Console.WriteLine("Area of Rectangle is: " + (rect.width * rect.height));
    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region C# Struct Example: Using Constructor and Method
    public struct Rectangle
    {
        public int width, height;
        public Rectangle(int w, int h)     //Parameterized Constructor 
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()      //Method in class
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
    public class TestStructs
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(5, 6);
            r.areaOfRectangle();
        }
    } 
    #endregion
}
