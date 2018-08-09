using System;

/* C# Public Access Specifier. It makes data accessible publicly. It does not restrict data to the declared block.*/
namespace Access_Modifiers_Specifiers_in_CSharp
{
    class PublicTest
    {
        public string name = "PUBLIC C# Dev";
        public void Msg(string msg)
        {
            Console.WriteLine("public Microsoft.Net Development " + msg);
        }
    }
}
