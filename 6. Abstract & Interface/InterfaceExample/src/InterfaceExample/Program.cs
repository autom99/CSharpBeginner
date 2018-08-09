using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExample
{
    /*  When we need an interface?
        Suppose we have an event in our company for which we have different type of persons to register.
        Guest: with no fee but special treatment
        Employee: with no fee
        Outsiders: need to pay fee
        Now we can create IPerson interface with a method Save and derive three classes Guest, Employee and Outsiders 

        Note: Interface methods are public and abstract by default. You cannot explicitly use public and abstract keywords for an interface method.
    */

    #region
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var personList = new List<IPerson>();
    //        personList.Add(new Guest { Name = "Guest 1" });
    //        personList.Add(new Employee { Name = "Employee 1" });
    //        personList.Add(new Outsiders { Name = "Outsider 1" });

    //        foreach (var person in personList)
    //        {
    //            person.Save();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //public interface IPerson
    //{

    //    int Save();
    //}

    //public class Guest : IPerson
    //{
    //    public String Name { get; set; }

    //    public int id { get; }

    //    public int Save()
    //    {
    //        // Save as guest for the event
    //        // Add Special treatment
    //        return id;
    //    }
    //}

    //public class Employee : IPerson
    //{
    //    public String Name { get; set; }
    //    public int id { get; }

    //    public int Save()
    //    {
    //        // Save for the event
    //        return id;
    //    }
    //}

    //public class Outsiders : IPerson
    //{
    //    public String Name { get; set; }
    //    public int id { get; }

    //    public int Save()
    //    {
    //        // Take the fee before saving it.
    //        // Save outsider for event

    //        return id;
    //    }
    //}
    #endregion

    #region Two instance & single class
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IStore IObjStore = new Document();
    //        ICompress IObjCompress = new Document();
    //        IObjStore.Read();
    //        IObjStore.Write();
    //        IObjCompress.Compress();
    //        IObjCompress.Decompress();

    //        Console.ReadKey();
    //    }
    //}
    //interface IStore
    //{
    //    void Read();
    //    void Write();
    //}

    //interface ICompress
    //{
    //    void Compress();
    //    void Decompress();
    //}

    //public class Document : IStore, ICompress
    //{
    //    public void Read()
    //    {
    //        Console.WriteLine("Executing Document's Read Method for IStore");
    //    }
    //    public void Write()
    //    {
    //        Console.WriteLine("Executing Document's Write Method for IStore");
    //    }
    //    public void Compress()
    //    {
    //        Console.WriteLine("Executing Document's Compress Method for ICompress");
    //    }
    //    public void Decompress()
    //    {
    //        Console.WriteLine("Executing Document's Decompress Method for ICompress");
    //    }
    //}
    #endregion

    #region interface Example
    public interface Drawable
    {
        void draw();
    }
    //public interface Drawable
    //{
    //    public abstract void draw();//Compile Time Error  
    //}
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;

            d = new Rectangle();
            d.draw();

            d = new Circle();
            d.draw();

            Console.ReadLine();
        }
    }
    #endregion
}
