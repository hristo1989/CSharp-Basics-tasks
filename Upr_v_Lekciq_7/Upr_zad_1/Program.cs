using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upr_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 22, 32, 42, 25 };
            bool Symetric = true;
            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array [array.Length - i - 1])
                {
                    Symetric = false;
                    break;
                }
                
            }
            {
                
            }
        }

    }
}
