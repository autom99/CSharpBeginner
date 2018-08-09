using System;

namespace Polymorphism_Static_Binding
{
    /*"Polymorphism" is the combination of "poly" + "morphs" which means many forms. It is a greek word. 
     **There are two types of polymorphism in C#: 
            1.compile time polymorphism 
            2.runtime polymorphism. 
     *****Compile time polymorphism is achieved by method overloading and operator overloading in C#.It is also known as static binding or early binding. 
     *****Runtime polymorphism in achieved by method overriding which is also known as dynamic binding or late binding.
     */

    class Program
    {
        #region C# Runtime Polymorphism Example

        //public class Animal
        //{
        //    public virtual void eat()
        //    {
        //        Console.WriteLine("eating...");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public override void eat()
        //    {
        //        Console.WriteLine("eating bread...");
        //    }

        //}
        //public class TestPolymorphism
        //{
        //    public static void Main()
        //    {
        //        Animal a = new Dog();
        //        a.eat();
        //        Console.WriteLine();
        //    }
        //} 
        #endregion

        #region C# Runtime Polymorphism Example 2

        //public class Shape
        //{
        //    public virtual void draw()
        //    {
        //        Console.WriteLine("drawing...");
        //    }
        //}
        //public class Rectangle : Shape
        //{
        //    public override void draw()
        //    {
        //        Console.WriteLine("drawing rectangle...");
        //    }

        //}
        //public class Circle : Shape
        //{
        //    public override void draw()
        //    {
        //        Console.WriteLine("drawing circle...");
        //    }

        //}
        //public class TestPolymorphism
        //{
        //    public static void Main()
        //    {
        //        Shape s;
        //        s = new Shape();
        //        s.draw();
        //        s = new Rectangle();
        //        s.draw();
        //        s = new Circle();
        //        s.draw();
        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Runtime Polymorphism with Data Members

        public class Animal
        {
            public string color = "white";
        }
        public class Dog : Animal
        {
            public new string color = "black";
        }
        public class TestSealed
        {
            public static void Main()
            {
                Animal d = new Dog();
                Console.WriteLine(d.color);
                Console.ReadLine();
            }
        }
        #endregion
    }
}
