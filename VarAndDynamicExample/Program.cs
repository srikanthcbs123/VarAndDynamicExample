using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAndDynamicExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chatgpt url:https://chatgpt.com/share/6737f53b-576c-8010-84e2-11655f41d50f
            //In C#, var and dynamic are two different types used to define variables.
            //Var check the datatype of assigning value at compiletime.if any error caught at compiletime

            //Dynamic check the datatype of assiging the value at runtime.if any error caught at runtime

            //var will check the type at compile time  and its type is fixed and errors are caught at compiletime.
            //dynamic will not check the type at compile time .if any error occured in runtime  you need to handle very carefully.

            #region VarUsage
            var number = 10;       // Compiler infers the type as int
            Console.WriteLine(number.GetType()); // Output: System.Int32

           //  number = "Hello";   // Compile-time error: Cannot assign string to an int

            #endregion


            #region DynamicUsage

            dynamic data = 10;     // Runtime type is int
            Console.WriteLine(data.GetType()); // Output: System.Int32

            data = "Hello";        // Runtime type changes to string
            Console.WriteLine(data.GetType()); // Output: System.String

            #endregion
        }
    }
}
