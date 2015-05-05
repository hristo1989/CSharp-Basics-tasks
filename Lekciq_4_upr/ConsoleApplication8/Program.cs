using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            char result = input[2];
            Console.WriteLine("Result is : {0}", result);
        }
    }
}
