using System;
using System.Collections.Generic; //for using List.

/*******************************  https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/branches-and-loops *****************************/

namespace Branches_and_loops
{

    class Program
    {
        static void Main(string[] args)
        {
            #region if-else
            int a = 5;
            int b = 3;
            int c = 4;

            if (a + b > 10) // 5 +3 > 10 
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            if ((a + b + c > 10) && (a > b)) //5 + 3 + 4 > 10 && 5 > 3
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b)) //5 + 3 + 4 > 10 || 5 > 3
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
            #endregion

            #region while & Do-while
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            #endregion

            #region for loop
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");

            #endregion

            #region foreach
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");
            #endregion

            Console.ReadKey();
        }
    }
}
