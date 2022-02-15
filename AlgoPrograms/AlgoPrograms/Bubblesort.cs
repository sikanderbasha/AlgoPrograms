using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPrograms
{
    internal class Bubblesort
    {     
           public void Sort()
            {
                int[] arr = { 6, 23, 47, 25, 73, 7 };
                int temp;
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted array :");
                foreach (int val in arr)
                Console.WriteLine(val);
                Console.ReadKey();
            }
        }
    }

