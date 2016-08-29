using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            String someString = "Hello World";
            Console.WriteLine(someString);

            doStuff(ref someString);
            Console.WriteLine(someString);

            doStuff(someString);
            Console.WriteLine(someString);

            Console.Read();
        }

        /**
         * Using ref means that the reference to the variable is passed to the
         * function instead of the value
         **/
        static void doStuff(ref string someString)
        {
            someString = "Got changed";
        }

        /**
         * Value is passed instead of reference
         **/
        static void doStuff(string someString)
        {
            someString = "Got changed again";
        }
    }
}
