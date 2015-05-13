using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleace enter a nymber: ");
            int number = 0;
            int N = int.Parse(Console.ReadLine());
            for (; ; )
            { 
                if (number == N)
                {
                    break;
                }
                number++;
                Console.WriteLine(number);
            }
        }
    }
}
