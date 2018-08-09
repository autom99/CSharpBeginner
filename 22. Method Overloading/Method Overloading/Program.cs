using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    /* C# Method Overloading
       *Having two or more methods with SAME NAME but DIFFERENT in parameters, is known as Method Overloading in C#.
       *The advantage of method overloading is that it increases the readability of the program because you don't need to use different names for same action.
       *You can perform method overloading in C# by two ways:
            --1. By changing number of arguments
            --2. By changing data type of the arguments   
     */

    #region C# Method Overloading Example: By changing no. of arguments
    //public class Cal
    //{
    //    public static int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public static int add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }
    //}
    //public class TestMemberOverloading
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine(Cal.add(12, 23));
    //        Console.WriteLine(Cal.add(12, 23, 25));
    //    }
    //}
    #endregion

    #region C# Member Overloading Example: By changing data type of arguments
    //public class Cal
    //{
    //    public static int add(int a, int b) //two int type Parameters method  
    //    {
    //        return a + b;
    //    }
    //    public static float add(float c, float d)  //two float type Parameters with same method same as above  
    //    {
    //        return c + d;
    //    }
    //    public static float add(float a, float b, float c, float d)  //four float type Parameters with same method same as above two method 
    //    {
    //        return a + b + c + d;
    //    }
    //}
    //public class TestMemberOverloading
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine(Cal.add(12, 23));
    //        Console.WriteLine(Cal.add(12.4f, 21.3f));
    //        Console.WriteLine(Cal.add(1.2f, 2.5f, 1.3f, 2.5f));
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Simple Program of Method/Function Overloading 
    //class shape
    //{
    //    public void Area(int side)
    //    {
    //        int squarearea = side * side;
    //        Console.WriteLine("The Area of Square is :" + squarearea);
    //    }
    //    public void Area(int length, int breadth)
    //    {
    //        int rectarea = length * breadth;
    //        Console.WriteLine("The Area of Rectangle is :" + rectarea);
    //    }
    //    public void Area(double radius)
    //    {
    //        double circlearea = 3.14 * radius * radius;
    //        Console.WriteLine("The Area of Circle is :" + circlearea);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        shape s = new shape();
    //        s.Area(10);
    //        s.Area(10, 20);
    //        s.Area(10.8);
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region MyRegion
    class Method_overloading
    {
        public int Addition(int a, int b)
        {
            int x;
            return x = a + b;
        }
        public int Addition(int a, int b, int c)
        {
            int y;
            return y = a + b + c;
        }
        public float Addition(float a, float b)
        {
            float u;
            return u = a + b;
        }
        public float Addition(float a, float b, float c)
        {
            float v;
            return v = a + b + c;
        }
    }
    //Now you can use those Addition method four types  
    class hub
    {
        public static void Main(String[] args)
        {
            Method_overloading mthover = new Method_overloading();
            Console.WriteLine("Addition of two integers::::::::::::::::" + mthover.Addition(2, 5));
            Console.WriteLine("Addition of two double type values::::::" + mthover.Addition(0.40f, 0.50f));
            Console.WriteLine("Addition of three integers::::::::::::::" + mthover.Addition(2, 5, 5));
            Console.WriteLine("Addition of three double type values::::" + mthover.Addition(0.40f, 0.50f, 0.60f));
            Console.ReadLine();
        }
    }
    #endregion
}
