using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example
{
   /* ABOUT C# ENUM: 
     Enum in C# is also known as enumeration. It is used to store a set of named constants such as season, days, month, size etc. 
     The enum constants are also known as enumerators. Enum in C# can be declared within or outside class and structs.
     Enum constants has default values which starts from 0 and incremented to one by one. But we can change the default value.

        Refer link: https://www.javatpoint.com/c-sharp-enum

*Points to remember:
    enum has fixed set of constants
    enum improves type safety
    enum can be traversed       
    */

    #region C# Enum Example
    //class Program
    //{
    //    public enum Season { WINTER, SPRING, SUMMER, FALL };

    //    static void Main(string[] args)
    //    {
    //        int x = (int)Season.WINTER;
    //        int y = (int)Season.SUMMER;
    //        Console.WriteLine("WINTER = {0}", x);
    //        Console.WriteLine("SUMMER = {0}", y);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# enum example changing start index
    //public class EnumExample
    //{
    //    public enum Season { WINTER = 10, SPRING, SUMMER, FALL } //Starting index is "10".

    //    public static void Main()
    //    {
    //        int x = (int)Season.WINTER;
    //        int y = (int)Season.SUMMER;
    //        Console.WriteLine("WINTER = {0}", x);
    //        Console.WriteLine("SUMMER = {0}", y);
    //    }
    //}
    #endregion

    #region C# enum example for Days
    //public class EnumExample1
    //{
    //    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    //    public static void Main()
    //    {
    //        int x = (int)Days.Sun;
    //        int y = (int)Days.Mon;
    //        int z = (int)Days.Sat;
    //        Console.WriteLine("Sun = {0}", x);
    //        Console.WriteLine("Mon = {0}", y);
    //        Console.WriteLine("Sat = {0}", z);
    //    }
    //}
    #endregion

    #region C# enum example: traversing all values using getNames()
    //public class EnumExample2
    //{
    //    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    //    public static void Main()
    //    {
    //        foreach (string s in Enum.GetNames(typeof(Days)))
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
    #endregion

    #region C# enum example: traversing all values using getValues()
    public class EnumExample3
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main()
        {
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
    #endregion
}
