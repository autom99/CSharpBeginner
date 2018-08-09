using System;

/* Namespaces in C# are used to organize too many classes so that it can be easy to handle the application.
    In a simple C# program, we use System.Console where System is the namespace and Console is the class. 
    To access the class of a namespace, we need to use namespacename.classname. We can use using keyword so that we don't have to use complete name all the time.
    In C#, global namespace is the root namespace. 
    The global::System will always refer to the namespace "System" of .Net Framework.
*/

#region Simple Namespace example
//namespace CSharp_namespace_example
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello Namespace!");
//            Console.ReadLine();
//        }
//    }
//}

#endregion

#region C# namespace example: by fully qualified name [<namespace_name.Class_name>]

//namespace First
//{
//    public class Hello
//    {
//        public void sayHello() { Console.WriteLine("Hello First Namespace"); }
//    }
//}
//namespace Second
//{
//    public class Hello
//    {
//        public void sayHello() { Console.WriteLine("Hello Second Namespace"); }
//    }
//}
//public class TestNamespace
//{
//    public static void Main()
//    {
//        //make an object with <namespace_name.Class_name()> and call method of that <namespace>
//        First.Hello h1 = new First.Hello();
//        h1.sayHello(); //By obj Call method of namespace First

//        Second.Hello h2 = new Second.Hello();
//        h2.sayHello();

//        Console.ReadLine();
//    }
//}
#endregion

#region C# namespace example: by [<using>] keyword.

using First;
using Second;

namespace First
{
    public class Hello
    {
        public void sayHello() { Console.WriteLine("Hello Namespace"); }
    }
}
namespace Second
{
    public class Welcome
    {
        public void sayWelcome() { Console.WriteLine("Welcome Namespace"); }
    }
}
public class TestNamespace
{
    public static void Main()
    {
        Hello h1 = new Hello();
        h1.sayHello();

        Welcome w1 = new Welcome();
        w1.sayWelcome();

        Console.ReadLine();
    }
}
#endregion