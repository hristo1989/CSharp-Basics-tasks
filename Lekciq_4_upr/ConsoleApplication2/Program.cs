using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking: Thist is my second program.");
            string a = "This is my second program.";
            Console.WriteLine("Check if the sentence contains the word: Hello");
            Console.WriteLine(a.Contains("Hello"));

            //string hello = "Hello";
            //Console.Write ("Enter a string");
            //string input = Console.ReadLine();
            //bool result = input.ToLower ().Equals(hello.ToLower());
            //Console.WriteLine("Result is: {0}", result);
        }
    }
}
