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
            Console.WriteLine("Hello World!");
            Console.Write("A line");
            Console.Write(", Not a new line");

            Console.WriteLine("This is a line");
            Console.WriteLine("This is also a line");

            Console.Write("\nThis is a line");
            Console.Write("\nThis is the last line");
            Console.ReadLine();
        }
    }
}
