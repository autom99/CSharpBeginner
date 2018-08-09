using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    /*If derived class defines same method as defined in its base class, it is known as method overriding in C#. 
     *It is used to achieve runtime polymorphism. 
     *It enables you to provide specific implementation of the method which is already provided by its base class.
     *To perform method overriding in C#, you need to use VIRTUAL keyword with base class method and override keyword with derived class method.
     ---------++++++++-------------------------------C# Method Overriding Example---------------------------------++++++++++++++---------------
     *Let's see a simple example of method overriding in C#. In this example, we are overriding the eat() method by the help of override keyword.
     */

    #region Method Overriding Example
    public class Animal
    {
        public virtual void eat() //VIRTUAL keyword with base class method
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat() //OVERRIDE keyword with derived class method
        {
            base.eat();
            Console.WriteLine("Eating bread...");
        }
    }
    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadKey();
        }
    } 
    #endregion
}
