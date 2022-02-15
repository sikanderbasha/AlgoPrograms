using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPrograms
{
    internal class Insertionsort
    {
      public void Sort()
        {
            int[] arr = new int[6] { 3, 21, 6, 13, 1, 12 };
            int a = 6, i, j, val;           
            Console.WriteLine("Initial array : ");
            for (i = 0; i < a; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (i = 1; i < a; i++)
            {
                val = arr[i];
                for (j = i - 1; j >= 0;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Sorted Array : ");
            for (i = 0; i < a; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

    }
}
