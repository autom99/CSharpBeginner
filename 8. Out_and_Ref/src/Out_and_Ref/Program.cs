using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Out_and_Ref
{
    public class Program
    {
        #region ref keyword: two way func calling as reference.
        ////Caller Func
        //public static void Main(string[] args)
        //{
        //    int OutSideVar = 20;
        //    SomeFunction(ref OutSideVar);

        //    Console.WriteLine(OutSideVar);
        //}
        ////Callee Func
        //static void SomeFunction(ref int InsideVar)
        //{
        //    InsideVar = InsideVar + 10;
        //}
        #endregion

        #region out keyword: only one way Callee to caller func calling as reference.
        //Caller Func
        public static void Main(string[] args)
        {
            int OutSideVar = 20;
            SomeFunction(out OutSideVar);

            Console.WriteLine(OutSideVar);
        }
        //Callee Func
        static void SomeFunction(out int InsideVar)
        {
            InsideVar = 0;
            InsideVar = InsideVar + 10;
        }
        #endregion
    }
}
