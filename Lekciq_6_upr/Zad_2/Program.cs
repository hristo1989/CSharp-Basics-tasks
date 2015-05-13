using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
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
                else if (number % 3 != 0 && number % 7 != 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
