using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter a number for 'b', (b > a): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a > b)
            {
                Console.WriteLine("The condition is not met!");
            }

            else
            {
                Console.WriteLine("The numbers between 'b' and 'a' that are devidet on 3 without reside.");
                for (int i = a; a <= b; a++)
                {
                    if (a % 3 == 0)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }   
    }
}
