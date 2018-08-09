using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * 
 Following are few properties of Abstract class:

1. Abstract class can HAVE constructor even though it cannot be initiated, this constructor can be used to initiate common properties, e.g., GUID for each derived class.
2. Abstract class constructor is automatically called by derived class constructor (Parent class constructor is called first followed by child class constructor)
3. Since Abstract class constructor can only be called by derived class, constructor access modifier as Public does not make sense, it should be Protected.
4. Abstract function can be called from Abstract class constructor, whenever instance of derived class is created, overridden abstract method in derived class would be called.
 * 
 */

#region Employee Abstract Class Example

//namespace AbstractClassExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /* BaseEmployee Object can not be created since this is declared as Abstract
//            Following LOCs will return compilation error if uncommented.*/

//            BaseEmployee baseEmployee = new BaseEmployee();
//            baseEmployee.EmployeeID = "EMP001";
//            baseEmployee.EmployeeAddress = "3400 Lee Highway, VA 22031";
//            baseEmployee.EmployeeName = "John Doe";

//            //Base Employee Calculate Salary can be called that shouldn't be accessible
//            var baseSalary = baseEmployee.CalculateSalary(34);

//            //Full Time and Contract Employees objects are successfully created.
//            BaseEmployee fullTimeEmployee = new FullTimeEmployee();
//            var fteSalary = fullTimeEmployee.CalculateSalary(40);

//            BaseEmployee contractEmployee = new ContractEmployee();
//            var CteSalary = contractEmployee.CalculateSalary(40);
//            Console.ReadLine();
//        }
//    }

//    public class BaseEmployee
//    //public abstract class BaseEmployee
//    {
//        public string EmployeeID { get; set; }
//        public string EmployeeName { get; set; }
//        public string EmployeeAddress { get; set; }

//        public virtual double CalculateSalary(int hoursWorked)
//        {
//            throw new NotImplementedException();
//        }
//        //public abstract double CalculateSalary(int hoursWorked);
//    }

//    public class FullTimeEmployee : BaseEmployee
//    {
//        public override double CalculateSalary(int hoursWorked)
//        {
//            return hoursWorked * 60.00 + 3700;
//        }
//    }

//    public class ContractEmployee : BaseEmployee
//    {
//        public override double CalculateSalary(int hoursWorked)
//        {
//            return hoursWorked * 65.00;
//        }
//    }
//}

#endregion

#region

//namespace AbstractClassExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Derived class from Abstract Class Output  
//            getShipping g = new getShipping();
//            Console.WriteLine(g.shipmentDetails());
//            Console.WriteLine(g.caluculate());
//            Console.ReadLine();
//        }
//    }

//    public abstract class shipping
//    {
//        public string delivery { get; set; }
//        public abstract string shipmentDetails();
//        public bool caluculate()
//        {
//            return true;
//        }
//    }

//    //inherited abstract class.
//    public class getShipping : shipping
//    {
//        //Override method of abstract class to use in derived class.
//        public override string shipmentDetails()
//        {
//            return "Shipped";
//        }
//    }
//}
#endregion

#region Employee using common interface AbstractClassExample 
/*
 *  A common interface for the Employee classes, and have both employees inherit from the abstract class. 
 That way if there is any common implementation you can write it once in the abstract class, 
 and extend the functionality as necessary in the child classes. 
 Since all classes share the same interface you can treat them the same and code against that interface rather than against the concrete class, which is always nice if you are using say a mok framework for unit testing etc... for example
 * * 
 */

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee ftime = new FullTimeEmployee();
            ftime.Name = "Full Time";
            IEmployee ptime = new PartTimeEmployee();
            ftime.Name = "Part Time";

            IList<IEmployee> employes = new List<IEmployee>();
            employes.Add(ftime);
            employes.Add(ptime);

            foreach (var e in employes)
            {
                Console.WriteLine("Employee {0}", e.Name);
                Console.WriteLine(e.EmployeeID);
                Console.WriteLine(e.CalculateSalary());
            }

            //this will not be allowed by the compiler if uncomented obviously. Can't create an instance of abstract/interface.
            //IEmployee impossible = new Employee();
            Console.ReadLine();
        }
    }

    //Simple interface with CalculateSalary()-"Non-Abstarct method" declaration.
    public interface IEmployee
    {
        string EmployeeID { get; set; }
        string Name { get; set; }
        double HourlyRate { get; set; }
        //virtually call to abstract class Employee.
        double CalculateSalary();
    }

    public abstract class Employee : IEmployee
    {
        private const int HOURSPERWEEK = 40;

        //Constructor of Abstract class.
        public Employee()
        {
            GenerateEmployeeID();
            HourlyRate = 0.00;
        }

        public abstract string EmployeeID { get; set; }

        public abstract string Name { get; set; }

        public abstract double HourlyRate { get; set; }

        public virtual double CalculateSalary()
        {
            double salery = 0.00;
            //some more common code to calcualte the salary
            salery = HourlyRate != 0.00 ? (HourlyRate * HOURSPERWEEK) : 0.00;
            return salery;
        }

        protected abstract void GenerateEmployeeID();
        //some common method to be impelmeted by all inherting classes but does not nee to be part of the public interface
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            this.Name = string.Empty;
            this.HourlyRate = 95.00;
        }

        public override string EmployeeID { get; set; }

        public override string Name { get; set; }

        public override double HourlyRate { get; set; }

        protected override void GenerateEmployeeID()
        {
            Random r = new Random(1);
            this.EmployeeID = string.Format("FT{0}", r.Next());
        }
    }

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            this.HourlyRate = 45.00;
        }
        public override string EmployeeID { get; set; }

        public override string Name { get; set; }

        public override double HourlyRate { get; set; }

        protected override void GenerateEmployeeID()
        {
            this.EmployeeID = string.Format("PT{0}", Guid.NewGuid());
        }

        public override double CalculateSalary()
        {
            //implement some code specifc to part timers 
            HourlyRate = HourlyRate != null ? (HourlyRate / 2) : 0.00;

            //base.Method-name() jump to BASE CLASS method.
            return base.CalculateSalary();
        }
    }
}
#endregion