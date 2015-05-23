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
            Console.WriteLine("Enter number of numbers:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter an integer");
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    b += item;
                }
            }
            Console.WriteLine("The sum from all even numbers is: {0}", b); 
        }
    }
}
