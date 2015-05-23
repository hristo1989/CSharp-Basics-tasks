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
            int[] array = new int[10];
            {
                Console.WriteLine("Enter numbers of the array: ");
                int x = Int32.MinValue;
                int y = Int32.MaxValue;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        if (array[i] > x)
                        {
                            x = array[i];
                        }
                    } 
                    if (i % 2 !=0)
                    {
                        if (array [i] < y)
	                    {
                            y = array[i];
	                    }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Highest number of even index is: {0}", x);
                Console.WriteLine("Lowest number of obb index is: {0}", y);

            }
        }
    }
}
