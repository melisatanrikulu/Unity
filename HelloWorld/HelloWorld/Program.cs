using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            NewClass newObj = new NewClass(); // can insantiate nonstatic classes, Console is a static class, so it cannot be instantiated
            newObj.first = 20;
            newObj.second = 40;

            Console.WriteLine(newObj.first + newObj.second);
            Console.WriteLine(newObj.getSum()); // calls a function of the instance object

            // Math class
            Console.WriteLine(Math.Pow(10f, 2f));
            Console.WriteLine(Math.Min(5, 7));
            Console.WriteLine(Math.Abs(-25.4));

            Console.ReadLine();
        }

        class NewClass
        {
            public int first; // if this variable is private, it cannot be seen from the outside of the class
            public int second;

            public int getSum() // a function that returns an integer and has no parameter
            {
                return first + second;
            }
        }
    }
}
