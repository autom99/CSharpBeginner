using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{

    #region Tutorialspoint Example
    //class Box
    //{
    //    private double length;   // Length of a box
    //    private double breadth;  // Breadth of a box
    //    private double height;   // Height of a box

    //    public double getVolume()
    //    {
    //        return length * breadth * height;
    //    }
    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public void setBreadth(double bre)
    //    {
    //        breadth = bre;
    //    }
    //    public void setHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    // Overload + operator to add two Box objects.
    //    public static Box operator +(Box b, Box c)
    //    {
    //        Box box = new Box();
    //        box.length = b.length + c.length;
    //        box.breadth = b.breadth + c.breadth;
    //        box.height = b.height + c.height;
    //        return box;
    //    }
    //}
    //class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //        Box Box1 = new Box();   // Declare Box1 of type Box
    //        Box Box2 = new Box();   // Declare Box2 of type Box
    //        Box Box3 = new Box();   // Declare Box3 of type Box
    //        double volume = 0.0;    // Store the volume of a box here

    //        // box 1 specification
    //        Box1.setLength(6.0);
    //        Box1.setBreadth(7.0);
    //        Box1.setHeight(5.0);

    //        // box 2 specification
    //        Box2.setLength(12.0);
    //        Box2.setBreadth(13.0);
    //        Box2.setHeight(10.0);

    //        // volume of box 1
    //        volume = Box1.getVolume();
    //        Console.WriteLine("Volume of Box1 : {0}", volume);

    //        // volume of box 2
    //        volume = Box2.getVolume();
    //        Console.WriteLine("Volume of Box2 : {0}", volume);

    //        // Add two object as follows:
    //        Box3 = Box1 + Box2;

    //        // volume of box 3
    //        volume = Box3.getVolume();
    //        Console.WriteLine("Volume of Box3 : {0}", volume);
    //        Console.ReadKey();
    //    }
    //} 
    #endregion

    #region C-sharpcorner
    class Program
    {
        int x, y, z;
        public Program()
        {
            x = y = z = 0;
        }

        public Program(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        //Operator overloading with + two obj Program obj1 & obj2
        public static Program operator +(Program obj1, Program oj2)
        {
            Program result = new Program();
            result.x = obj1.x + oj2.x;
            result.y = obj1.y + oj2.y;
            result.z = obj1.z + oj2.z;
            return result;
        }

        public static Program operator -(Program obj1, Program oj2)
        {
            Program result = new Program();
            result.x = obj1.x - oj2.x;
            result.y = obj1.y - oj2.y;
            result.z = obj1.z - oj2.z;
            return result;
        }

        public void show()
        {
            Console.WriteLine(x + "," + y + "," + z);
        }

        static void Main(string[] args)
        {
            Program objA = new Program(1, 2, 3);
            Program objB = new Program(25, 22, 10);
            Program objC;

            Console.WriteLine("The value of objA: ");
            objA.show();
            Console.WriteLine();

            Console.WriteLine("The value of objB: ");
            objB.show();
            Console.WriteLine();

            objC = objA + objB;
            Console.WriteLine("Result of objA + objB");
            objC.show();
            Console.WriteLine();

            objC = objA + objB + objC;
            Console.WriteLine("adding objA, onjB and objC");
            objC.show();
            Console.WriteLine();

            objC = objC - objA;
            Console.WriteLine("Subtracting objC - objA");
            objC.show();
            Console.WriteLine();

            objC = objC - objB;
            Console.WriteLine("Subtracting objC - objB");
            objC.show();
            Console.WriteLine();
            Console.Read();
        }
    }
    #endregion
}
