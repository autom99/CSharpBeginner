using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    /* ABOUT STATIC
     In C#, static is a keyword or modifier that belongs to the type not instance. 
     So instance is not required to access the static members. 
     In C#, static can be field, method, constructor, class, properties, operator and event.

      *Advantage of C# static keyword:
        Memory efficient: Now we don't need to create instance for accessing the static members, so it saves memory. 
        Moreover, it belongs to the type, so it will not get memory each time when instance is created.

       Refer link: https://www.javatpoint.com/c-sharp-static
     */

    #region C# static field example 1
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Account a1 = new Account(101, "Sonoo");
    //        Account a2 = new Account(102, "Mahesh");
    //        a1.display();
    //        a2.display();
    //    }
    //}

    //public class Account
    //{
    //    public int accno;
    //    public String name;
    //    public static float rateOfInterest = 8.8f;
    //    public Account(int accno, String name)
    //    {
    //        this.accno = accno;
    //        this.name = name;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
    //    }
    //} 
    #endregion

    #region C# static field example 2: changing static field
    //public class Account
    //{
    //    public int accno;
    //    public String name;
    //    public static float rateOfInterest = 8.8f;
    //    public Account(int accno, String name)
    //    {
    //        this.accno = accno;
    //        this.name = name;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
    //    }
    //}
    //class TestAccount
    //{
    //    public static void Main(string[] args)
    //    {
    //        Account.rateOfInterest = 10.5f;//changing value  
    //        Account a1 = new Account(101, "Sonoo");
    //        Account a2 = new Account(102, "Mahesh");
    //        a1.display();
    //        a2.display();

    //    }
    //}
    #endregion

    #region C# static field example 3: Counting Objects
    //public class Account
    //{
    //    public int accno;
    //    public String name;
    //    public static int count = 0;
    //    public Account(int accno, String name)
    //    {
    //        this.accno = accno;
    //        this.name = name;
    //        count++;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine(accno + " " + name);
    //    }
    //}
    //class TestAccount
    //{
    //    public static void Main(string[] args)
    //    {
    //        Account a1 = new Account(101, "Sonoo");
    //        Account a2 = new Account(102, "Mahesh");
    //        Account a3 = new Account(103, "Ajeet");
    //        a1.display();
    //        a2.display();
    //        a3.display();
    //        Console.WriteLine("Total Objects are: " + Account.count);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# static class example
    //public static class MyMath
    //{
    //    public static float PI = 3.14f;
    //    public static int cube(int n) { return n * n * n; }
    //}
    //class TestMyMath
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Value of PI is: " + MyMath.PI);
    //        Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region C# Static Constructor example
    public class Account
    {
        public int id;
        public String name;
        public static float rateOfInterest = 10.5f;
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 10.25f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadLine();
        }
    } 
    #endregion
}
