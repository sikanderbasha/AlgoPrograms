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
            Console.WriteLine("Enter 3 for Anagram Problem");
            Console.WriteLine("Enter 4 for Prime number Problem");
            Console.WriteLine("Enter 5 for Binary Search Problem");
            Console.WriteLine("Enter 5 for Merge sort Problem");
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
                case 3:
                    string first, second;                     
                    Console.WriteLine("Enter first string");
                    first = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    second = Console.ReadLine();
                    Anagram anagram = new Anagram();                    
                    if (anagram.Checkanagram(first, second) == true)
                    {
                        Console.WriteLine("Its a anagram.");
                    }
                    else
                    {
                        Console.WriteLine("Its not a anagram.");
                    }
                    Console.ReadLine();
                    break;
                case 4:
                    Primenumber prime = new Primenumber();
                    prime.Prime();
                    break;
                case 5:
                    Binarysearch binary = new Binarysearch();
                    Console.WriteLine("Enter a string :");
                    string input = Console.ReadLine();                   
                    binary.Binary(input);
                    break;
                case 6:
                    int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
                    int len = numbers.Length;
                    Console.WriteLine("Before Merge Sort:");
                    foreach (int item in numbers)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("After Merge Sort");
                    Mergesort Sort = new Mergesort();
                    Sort.Sort(numbers, 0, len - 1);
                    foreach (int item in numbers)
                    {
                        Console.Write(item + " ");
                    }
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Enter the correct option:");
                    break;
            }
        }

      
    }
}
