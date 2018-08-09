using System;

/* Variable or function declared protected internal can be accessed in the assembly in which it is declared.
 * It can also be accessed within a derived class in another assembly.*/

namespace Access_Modifiers_Specifiers_in_CSharp
{
    class ProtectedTestInternal
    {
        // String Variable declared as protected internal
        protected internal string strname;

        public void print()
        {
            Console.WriteLine("\nMy name is " + strname);
        }

        protected internal string name = "PROTECTED C# Dev";

        protected internal void Msg(string msg)
        {
            Console.WriteLine("Protected Microsoft .Net Development" + msg);
        }
    }
}
