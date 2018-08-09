using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    /**In C#, inheritance is a process in which one object acquires all the properties and behaviors of its parent object automatically. 
     * In such way, you can reuse, extend or modify the attributes and behaviors which is defined in other class.
     * In C#, the class which inherits the members of another class is called derived class and the class whose members are inherited is called base class. 
     * The derived class is the specialized class for the base class.
     ---------------------------------------------------Advantage of C# Inheritance---------------------------------------------------------------------------------
    **Code reusability: Now you can reuse the members of your parent class. So, there is no need to define the member again. So less code is required in the class.
    */

    #region C# Single Level Inheritance Example: Inheriting Fields

    //public class Employee
    //{
    //    public float salary = 100000;
    //}
    //public class Programmer : Employee
    //{
    //    public float bonus = 50000;
    //}
    //class TestInheritance
    //{
    //    public static void Main(string[] args)
    //    {
    //        Programmer p1 = new Programmer();

    //        Console.WriteLine("Salary: " + p1.salary);
    //        Console.WriteLine("Bonus: " + p1.bonus);
    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region C# Single Level Inheritance Example: Inheriting Methods
    //public class Animal
    //{
    //    public void eat() { Console.WriteLine("Eating..."); }
    //}
    //public class Dog : Animal
    //{
    //    public void bark() { Console.WriteLine("Barking..."); }
    //}
    //class TestInheritance2
    //{
    //    public static void Main(string[] args)
    //    {
    //        Dog d1 = new Dog();
    //        d1.eat();
    //        d1.bark();
    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region C# Multi Level Inheritance Example
    /*When one class inherits another class which is further inherited by another class, it is known as multi level inheritance in C#. 
     *Inheritance is transitive so the last derived class acquires all the members of all its base classes.
     * Note: Multiple inheritance is not supported in C# through class.
    */
    //public class Animal
    //{
    //    public void eat() { Console.WriteLine("Eating..."); }
    //}
    //public class Dog : Animal
    //{
    //    public void bark() { Console.WriteLine("Barking..."); }
    //}
    //public class BabyDog : Dog
    //{
    //    public void weep() { Console.WriteLine("Weeping..."); }
    //}
    //class TestInheritance2
    //{
    //    public static void Main(string[] args)
    //    {
    //        BabyDog d1 = new BabyDog();
    //        d1.eat();
    //        d1.bark();
    //        d1.weep();
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Single inheritance 
    //public class Accountcreditinfo //base class    
    //{
    //    public string Credit()
    //    {
    //        return "balance is credited";
    //    }
    //}
    //public class debitinfo : Accountcreditinfo //derived class    
    //{
    //    public string debit()
    //    {
    //        Credit(); //derived class method    
    //        return "balance is debited";
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        debitinfo debitObj = new debitinfo();
    //        Console.WriteLine(debitObj.debit());
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Example of Guru99 Tutorial
    //class Tutorial
    //{
    //    protected int TutorialID;
    //    protected string TutorialName;

    //    public void SetTutorial(int pID, string pName)
    //    {
    //        TutorialID = pID;
    //        TutorialName = pName;
    //    }

    //    public String GetTutorial()
    //    {
    //        return TutorialName;
    //    }
    //}
    //class Guru99Tutorial : Tutorial
    //{
    //    public void RenameTutorial(String pNewName)
    //    {
    //        TutorialName = pNewName;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Guru99Tutorial pTutor = new Guru99Tutorial();

    //        pTutor.RenameTutorial(".Net by Guru99");

    //        Console.WriteLine(pTutor.GetTutorial());

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Hierarchical type INHERITANCE
    //class Program
    //{
    //    class Principal
    //    {
    //        public void Monitor()
    //        {
    //            Console.WriteLine("Principle method call Monitor");
    //        }
    //    }
    //    class Teacher : Principal
    //    {
    //        public void Teach()
    //        {
    //            Console.WriteLine("Teacher method call Teach");
    //        }
    //    }
    //    class Student : Principal
    //    {
    //        public void Learn()
    //        {
    //            Console.WriteLine("Student method call Learn");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Principal principle = new Principal();
    //        principle.Monitor();

    //        Teacher teacher = new Teacher();
    //        teacher.Monitor();
    //        teacher.Teach();

    //        Student student = new Student();
    //        student.Monitor();
    //        student.Learn();

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Hierarchical type INHERITANCE
    //public class Program
    //{
    //    class A  //base class    
    //    {
    //        public string msg()
    //        {
    //            return "this is A class Method";
    //        }
    //    }
    //    class B : A
    //    {
    //        public string info()
    //        {
    //            msg();
    //            return "this is B class Method";
    //        }
    //    }
    //    class C : A
    //    {
    //        public string getinfo()
    //        {
    //            msg();
    //            return "this is C class Method";
    //        }
    //    }
    //    class D : A
    //    {
    //        public string getInfo()
    //        {
    //            msg();
    //            return "This is D class Method";
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        D d = new D();
    //        Console.WriteLine(d.getInfo());
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Example Hierarchical type INHERITANCE
    //class HeadOffice
    //{
    //    public string HeadOfficeAddress()
    //    {
    //        return "Head Office Address";
    //        //Console.WriteLine("Head Office Address");
    //    }
    //}
    //class BranchOffice1 : HeadOffice
    //{
    //    public string BranchOffice1Address()
    //    {
    //        return "Branch Office 1 Address";  
    //        //Console.WriteLine("Branch Office Address");
    //    }
    //}
    //class BranchOffice2 : HeadOffice
    //{
    //    public string BranchOffice2Address()
    //    {
    //        return "Branch Office 2 Address";
    //        //Console.WriteLine("Branch Office Address");
    //    }
    //}
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        BranchOffice2 bo2 = new BranchOffice2();
    //        Console.WriteLine(bo2.BranchOffice2Address());
    //        Console.WriteLine(bo2.HeadOfficeAddress());

    //        BranchOffice1 bo1 = new BranchOffice1();
    //        Console.WriteLine(bo1.BranchOffice1Address());
    //        Console.WriteLine(bo1.HeadOfficeAddress());
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Multilevel inheritance
    //public class Person
    //{
    //    public string persondet()
    //    {
    //        return "this is the person class";
    //    }
    //}
    //public class Bird : Person
    //{
    //    public string birddet()
    //    {
    //        persondet();
    //        return "this is the birddet Class";
    //    }
    //}
    //public class Animal : Bird
    //{
    //    public string animaldet()
    //    {
    //        persondet();
    //        birddet();
    //        return "this is the Animal Class";
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Person person = new Person();
    //        Console.WriteLine(person.persondet());
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Hybrid inheritance Example
    //class HeadOffice
    //{
    //    public string HeadOfficeAddress()
    //    {
    //        return "Head Office Address";    //Console.WriteLine("Head Office Address");
    //    }
    //}
    //class BranchOffice1 : HeadOffice
    //{
    //    public string BranchOffice1Address()
    //    {
    //        return "Branch Office 1 Address";  //Console.WriteLine("Branch Office Address");
    //    }
    //}
    //class BranchOffice2 : HeadOffice
    //{
    //    public string BranchOffice2Address()
    //    {
    //        return "Branch Office 2 Address";   //Console.WriteLine("Branch Office Address");
    //    }
    //}
    //class Employee : BranchOffice2
    //{
    //    public string NameofEmployee()
    //    {
    //        return "Name of the Employee";  //Console.WriteLine("Name of the Employee");
    //    }
    //    public string Salary()
    //    {
    //        return "Salary of the Employee"; //Console.WriteLine("Salary of the Employee");
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        BranchOffice2 bo2 = new BranchOffice2();
    //        Console.WriteLine(bo2.BranchOffice2Address());
    //        Console.WriteLine(bo2.HeadOfficeAddress());

    //        BranchOffice1 bo1 = new BranchOffice1();
    //        Console.WriteLine(bo1.BranchOffice1Address());
    //        Console.WriteLine(bo1.HeadOfficeAddress());

    //        Employee emp = new Employee();
    //        Console.WriteLine(emp.NameofEmployee());
    //        Console.WriteLine(emp.Salary());
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Multiple inheritance using interface Example
    //interface calc1
    //{
    //    int add(int a, int b);
    //}
    //interface calc2
    //{
    //    int sub(int x, int y);
    //}
    //interface calc3
    //{
    //    int mul(int r, int s);
    //}
    //interface calc4
    //{
    //    int div(int c, int d);
    //}
    //class Calculation : calc1, calc2, calc3, calc4
    //{
    //    public int result1;
    //    public int add(int a, int b)
    //    {
    //        return result1 = a + b;
    //    }
    //    public int result2;
    //    public int sub(int x, int y)
    //    {
    //        return result2 = x - y;
    //    }
    //    public int result3;
    //    public int mul(int r, int s)
    //    {
    //        return result3 = r * s;
    //    }
    //    public int result4;
    //    public int div(int c, int d)
    //    {
    //        return result4 = c / d;
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Calculation c = new Calculation();
    //            c.add(8, 2);
    //            c.sub(20, 10);
    //            c.mul(5, 2);
    //            c.div(20, 10);
    //            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
    //            Console.WriteLine("Addition: " + c.result1);
    //            Console.WriteLine("Substraction: " + c.result2);
    //            Console.WriteLine("Multiplication :" + c.result3);
    //            Console.WriteLine("Division: " + c.result4);
    //            Console.ReadKey();
    //        }
    //    }
    //}
    #endregion
}