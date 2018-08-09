using System;

/* Abstract classes are the way to achieve abstraction in C#. 
   Abstraction in C# is the process to hide the internal details and showing functionality only. 
   Abstract class and interface both can have abstract methods which are necessary for abstraction.
   An abstract method in C# is internally a virtual method so it can be overridden by the derived class. 
  
*/

namespace Abstract_Example
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle..!!!");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle..!!!");
        }
    }
    class TestAbstract
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.WriteLine();
        }
    }
}
