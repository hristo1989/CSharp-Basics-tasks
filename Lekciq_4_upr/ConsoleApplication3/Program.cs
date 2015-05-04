using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("ha = ");
            int ha = int.Parse(Console.ReadLine());
            Console.WriteLine((a * ha) / 2);

        }
    }
}
