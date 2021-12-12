using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static int a;
        static float b;
        static bool c;
        static string d;

        static void Main(string[] args)
        {
            var total = true; // needs to be initialized, can be assigned to any type and the type cannot change

            a = 1;
            b = 1.1f; // unsigned integers, long, float, double, decimal // u,l,f,d,m, 
            // The range changes
            c = true;
            d = "more than 1 characters";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(4.0m);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(@"C:\Users\HP\Desktop"); // Escape character is seen as a part of the string (called verbatim)
            // \n, \t and all such escape characters are read as strings now

            // String concatenation
            string hello = "Hello ";
            string helloWorld = hello + "World!";

            string ex_one = $"{hello} World!"; // Uses variables in strings
            string ex_two = $@"C:\Users\HP\Desktop\{helloWorld}.pdf"; // Uses verbatim

            Console.WriteLine(ex_one);
            Console.WriteLine(ex_two);

            Console.ReadLine();
        }
    }
}
