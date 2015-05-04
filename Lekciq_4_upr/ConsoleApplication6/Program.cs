using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete realno chislo: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Vuvedete cqlo chislo: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x / y);
        }
    }
}
