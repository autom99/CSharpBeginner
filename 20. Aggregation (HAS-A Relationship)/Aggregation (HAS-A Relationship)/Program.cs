using System;

namespace Aggregation__HAS_A_Relationship_
{
    /* In C#, aggregation is a process in which one class defines another class as any entity reference. 
     * It is another way to reuse the class. It is a form of association that represents HAS-A relationship.
      ******************--------------------C# Aggregation Example----------------------***************************
     * Let's see an example of aggregation where Employee class has the reference of Address class as data member. 
     * In such way, it can reuse the members of Address class.
    */
    public class Address
    {
        public string addressLine, city, state;

        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }

    public class Employee
    {
        int id;
        string name;

        public Address address; //Employee HAS-A Address  

        public Employee(int id,string name,Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + address.addressLine + " " + address.city + " " + address.state);
        }
    }

    public class TestAggregation
    {
        public static void Main(string[] args)
        {
            Address address = new Address("G-13, Sec-3", "Noida", "UP");
            Employee employee = new Employee(1, "Sonoo", address);
            employee.display();
            Console.ReadLine(); 
        }
    }
}
