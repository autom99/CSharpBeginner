using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Example
{

    #region     
    /* 
    Sealed Method :
        When an instance method declaration includes a sealed modifier, that method is said to be a sealed method.
        A sealed method overrides an inherited virtual method with the same signature.
        A sealed method shall also be marked with the override modifier.
        Use of the sealed modifier prevents a derived class from further overriding the method.
    */        
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SealedClass sealedCls = new SealedClass();
    //        A a = new A();
    //        a.First();
    //        a.Second();
    //        int total = sealedCls.Add(4, 5);
    //        Console.WriteLine("Total = " + total.ToString());
    //        Console.Read();
    //    }
    //}
    ////Sealed class 
    //sealed class SealedClass
    //{
    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    ///* 
    // Sealed Method :
    //    When an instance method declaration includes a sealed modifier, that method is said to be a sealed method. 
    //    A sealed method overrides an inherited virtual method with the same signature. 
    //    A sealed method shall also be marked with the override modifier. 
    //    Use of the sealed modifier prevents a derived class from further overriding the method.
    //*/
    //class A
    //{
    //    public virtual void First()
    //    {
    //        Console.WriteLine("First Class A");
    //    }
    //    public virtual void Second()
    //    {
    //        Console.WriteLine("Second Class A");
    //    }
    //}
    //class B : A
    //{
    //    public sealed override void First()
    //    {
    //        Console.WriteLine("First Class B");
    //    }
    //    public override void Second()
    //    {
    //        Console.WriteLine("Second Class B");
    //    }
    //}
    //class C : B
    //{
    //    public override void Second()
    //    {
    //        Console.WriteLine("First Class C");
    //    }
    //}
    #endregion

    #region Practical demonstration of sealed class & sealed method

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            obj.Display();

            DerivedClass ob1 = new DerivedClass();
            ob1.Display();
            Console.ReadLine();
        }

        public sealed class BaseClass
        {
            //public void Display()
            //{
            //    Console.WriteLine("This is a sealed class which can't be further inherited");
            //}

            public void Display()
            {
                Console.WriteLine("Virtual method");
            }
        }

        #region this Derived class can;t inherit BaseClass because it is sealed
        //public class Derived : BaseClass
        //{
        //    // this Derived class can;t inherit BaseClass because it is sealed
        //} 
        #endregion

        #region Now the display method have been sealed and can't be overridden
        //public class DerivedClass : BaseClass
        //{
        //    // Now the display method have been sealed and can;t be overridden
        //    public override sealed void Display()
        //    {
        //        Console.WriteLine("Sealed method");
        //    }
        //}
        #endregion

        //public class ThirdClass : DerivedClass
        //{
        //    public override void Display()
        //    {
        //        Console.WriteLine("Here we try again to override display method which is not possible and will give error");
        //    }
        //}

        #region Override method w/o inherited class.
        private class DerivedClass
        {
            public void Display()
            {
                Console.WriteLine("Override method.");
            }
        } 
        #endregion
    }
    #endregion
}


