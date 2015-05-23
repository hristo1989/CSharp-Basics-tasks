using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you will enter: ");
            int lenght = int.Parse(Console.ReadLine());
            int min = Int32.MaxValue;
            int max = 0;
           
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                if (min > number)
                {
                    min = number;
                }
                if (max <number)
                {
                    max = number;
                }
            }
            Console.WriteLine("The lowest number is: {0}", min);
            Console.WriteLine("The highest number is: {0}", max);
        }
    }
}
