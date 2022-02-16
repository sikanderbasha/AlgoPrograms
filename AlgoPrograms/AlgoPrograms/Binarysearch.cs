using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPrograms
{
    internal class Binarysearch
    {
        public void Binary(string input)
        {
            string[] arr = { "first", "second", "third", "fourth" };
            int min = 0, mid = 0, result = -1;
            int max = arr.Length - 1;          
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(arr[i]);
            }

            while (min <= max)
            {
                mid = min + (min - 1) / 2;

                if (input.Equals(arr[mid]))
                {
                    result = 0;
                }

                if (result == 0)
                {
                    Console.WriteLine("match found");
                }

                int val = Convert.ToInt32(input.CompareTo(arr[mid]));

                if (val == 1)
                {
                    min = mid + 1;
                    result = 1;
                }
                else
                {
                    max = mid - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("String is present");
            }
            else if (result == 1)
            {
                Console.WriteLine("String is not present");
            }

        }
    }
}
