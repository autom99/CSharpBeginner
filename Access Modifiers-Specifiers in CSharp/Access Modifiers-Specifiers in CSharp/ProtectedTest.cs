using System;

/* C# Protected Access Specifier. Compile time error 'ProtectedTest.name' is inaccessible due to its protection level.
    It is accessible within the class and has limited scope.
    It is also accessible within sub class or child class, in case of inheritance.
*/

namespace Access_Modifiers_Specifiers_in_CSharp
{
    class ProtectedTest
    {
        protected string name = "PROTECTED C# Dev";
        protected void Msg(string msg)
        {
            Console.WriteLine("Protected Microsoft .Net Development " + msg);
        }
    }
}
