using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Using foreach");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            {
                Console.WriteLine("Using for");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
