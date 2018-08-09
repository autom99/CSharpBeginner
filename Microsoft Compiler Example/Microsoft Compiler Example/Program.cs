using System;

/* https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/numbers-in-csharp
 * https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/numbers-in-csharp-local */

namespace Microsoft_Compiler_Numbers_in_CSharp_Example //Numbers in C#
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18, b = 6;

            int add = a + b;
            Console.WriteLine("Addition of a & b is : " + add);

            int sub = a - b;
            Console.WriteLine("Substraction of a & b is : " + sub);

            int mul = a * b;
            Console.WriteLine("Multiplication of a & b is : " + mul);

            int div = a / b;
            Console.WriteLine("Division of a & b is : " + div);

            int mod = a % b;
            Console.WriteLine("Modulo of a & b is : " + mod);

            int a1 = 5, b1 = 4, c1 = 2;
            int d = a1 + b1 * c1;
            Console.WriteLine("a1 + b1 * c1 = " + d);

            int a2 = 5;
            int b2 = 4;
            int c2 = 2;
            int d1 = (a2 + b2) * c2;
            Console.WriteLine("(a2 + b2) * c2 = " + d1);

            int d2 = (a2 + b2) - 6 * c2 + (12 * 4) / 3 + 12;
            Console.WriteLine("(a2 + b2) - 6 * c2 + (12 * 4) / 3 + 12 = " + d2);

            int a3 = 7;
            int b3 = 4;
            int c3 = 3;
            int d3 = (a3 + b3) / c3;
            Console.WriteLine("(a3 + b3) / c3 = " + d3);

            int a4 = 7;
            int b4 = 4;
            int c4 = 3;
            int d4 = (a4 + b4) / c4;
            Console.WriteLine($"quotient (a4 + b4) / c4 : {d4}");

            int e = (a4 + b4) % c4;
            Console.WriteLine($"remainder (a4 + b4) % c4: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double maxDob = double.MaxValue;
            double minDob = double.MinValue;
            Console.WriteLine($"The range of double is {minDob} to {maxDob}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal minDec = decimal.MinValue;
            decimal maxDec = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minDec} to {maxDec}");

            double a5 = 1.0;
            double b5 = 3.0;
            Console.WriteLine(a5 / b5);

            decimal c6 = 1.0M;
            decimal d6 = 3.0M;
            Console.WriteLine(c6 / d6);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Math.PI * radius * radius = {area}");

            Console.ReadKey();

        }
    }
}
