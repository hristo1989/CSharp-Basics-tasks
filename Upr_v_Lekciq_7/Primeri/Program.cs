using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "a", "A", "aaa", "AAAA", "aaaaa" };
            Console.WriteLine("Max element is: " + array.Max());
            Console.WriteLine("Min element is: " + array.Min());
        }
    }
}
