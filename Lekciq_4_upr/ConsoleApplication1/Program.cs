using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
        }
    }
}
