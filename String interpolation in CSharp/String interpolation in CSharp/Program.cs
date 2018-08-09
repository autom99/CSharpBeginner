using System;
using System.Collections.Generic;

/*************$$$$$$$$$$$$$$$$$$$$$$$$ https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/interpolated-strings $$$$$$$$$$$$$$$$$$$$$$$$******************/

namespace String_interpolation_in_CSharp
{
    public enum Unit { item, kilogram, gram, dozen };

    public class Program
    {
        public string Name { get; }

        public Program(string Name)
        {
            this.Name = Name;
        }

        public override string ToString() => Name;

        static void Main(string[] args)
        {
            var varname = "<name>";
            Console.WriteLine($"Hello, {varname}. It's a pleasure to meet you!");

            var msg = $".NET Version: {Environment.Version}";
            Console.WriteLine(msg);

            var item = new Program("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");

            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var items in inventory)
                Console.WriteLine($"|{items.Key,-25}|{items.Value,10}|");

            Console.ReadKey();
        }
    }
}
