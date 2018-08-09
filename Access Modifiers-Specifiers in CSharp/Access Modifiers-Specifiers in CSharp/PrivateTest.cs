using System;

namespace Access_Modifiers_Specifiers_in_CSharp
{
    class PrivateTest
    {
        private string name = "PRIVATE C# Dev";

        private void Msg(string msg)
        {
            Console.WriteLine("Private Microsoft .Net Development" + msg);
        }
    }
}
