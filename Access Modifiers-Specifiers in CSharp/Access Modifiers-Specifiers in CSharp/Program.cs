/* ABOUT C# Access Modifiers / Specifiers
C# Access modifiers or specifiers are the keywords that are used to specify accessibility or scope of variables and functions in the C# application.

C# provides five types of access specifiers.

Public
Protected
Internal
Protected internal
Private
We can choose any of these to protect our data. Public is not restricted and Private is most restricted. The following table describes about the accessibility of each.

****Access Specifier********++++++++++******Description***********************************************************
    
    Public: It specifies that access is not restricted.
    Protected:	It specifies that access is limited to the containing class or in derived class.
    Internal:   It specifies that access is limited to the current assembly.
    protected internal:	It specifies that access is limited to the current assembly or types derived from the containing class.
    Private:	It specifies that access is limited to the containing type.
*****************************************************************************************************************************


*/

using System;

namespace Access_Modifiers_Specifiers_in_CSharp
{

    #region C# Protected Access Specifier Here, we are accessing protected members within child class by inheritance.
    //class Program : ProtectedTest
    //{
    //    static void Main(string[] args)
    //    {
    //        Program program = new Program();

    //        // Accessing protected variable  
    //        Console.WriteLine("Hello " + program.name);

    //        // Accessing protected function  
    //        program.Msg("Swami Ayyer");

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    class Program
    {
        private string name = "PRIVATE C# Dev";

        private void Msg(string msg)
        {
            Console.WriteLine("Private Microsoft .Net Development" + msg);
        }

        static void Main(string[] args)
        {
            /*--------------------------- public Class PublicTest--------------------------------------*/
            PublicTest publicTest = new PublicTest();

            // Accessing public function  
            publicTest.Msg(" @public class property Msg method testing.");

            // Accessing public variable  
            Console.WriteLine(publicTest.name);

            Console.WriteLine();

            /*----------------------------- internal Class InternalTest-----------------------------------*/
            InternalTest interTest = new InternalTest();

            // Accessing internal function  
            interTest.Msg(" @internal class property Msg method testing.");
            // Accessing internal variable  
            Console.WriteLine(interTest.name);

            Console.WriteLine();

            /*--------------------------- protected internal Class ProtectedTestInternal----------------------*/
            ProtectedTestInternal protectedInternal = new ProtectedTestInternal();

            // Accessing protected internal function  
            protectedInternal.Msg(" @Protected internal class property Msg method testing.");

            // Accessing protected internal variable  
            Console.WriteLine(protectedInternal.name);

            Console.Write("Enter your strname:\t");

            // Accepting value in protected internal variable
            protectedInternal.strname = Console.ReadLine();
            protectedInternal.print();
            Console.ReadLine();

            Console.WriteLine();

            /*------------------------- Private Class PrivateTest----------------------*/
            PrivateTest privateTest = new PrivateTest();

            //Accessing private variable  
            //Compile time error:'PrivateTest.name' is inaccessible due to its protection level.
            //Console.WriteLine("PRIVATE class property name testing :" + privateTest.name);

            // Accessing private function  
            //privateTest.Msg("PRIVATE class property Msg method testing.");
            //Compile time error:'PrivateTest.Msg' is inaccessible due to its protection level.


            /*-----------------------------For Access Private -------------------------*/
            Program program = new Program();

            program.Msg(" @private class property Msg method testing.");
            Console.WriteLine(program.name);

            Console.ReadLine();
        }
    }







}





