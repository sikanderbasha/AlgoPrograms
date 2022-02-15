using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Enter 1 for Bubble Sort Problem");
            Console.WriteLine("Enter 2 for Insertion Sort Problem");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Bubblesort sort = new Bubblesort();
                    sort.Sort();
                    Console.ReadKey();
                    break;
                case 2:                   
                    Insertionsort insert = new Insertionsort();
                    insert.Sort();                  
                    break;
                default:
                    Console.WriteLine("Enter the correct option:");
                    break;
            }
        }

      
    }
}
