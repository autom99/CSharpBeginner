using System;

//The internal keyword is used to specify the internal access specifier for the variables and functions.
//This specifier is accessible only within files in the same assembly.
namespace Access_Modifiers_Specifiers_in_CSharp
{
    class InternalTest
    {
        internal string name = "INTERNAL C# Dev";

        internal void Msg(string msg)
        {
            Console.WriteLine("Internal Microsoft .Net Development " + msg);
        }
    }
}
