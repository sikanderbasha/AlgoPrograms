using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPrograms
{
    internal class Anagram
    {
        public bool Checkanagram(string first, string second)
        {

            {
                if (first.Length != second.Length)
                {
                    return false;
                }
                
                char[] firstCharsArray = first.ToLower().ToCharArray();
                char[] secondCharsArray = second.ToLower().ToCharArray();
               
                Array.Sort(firstCharsArray);
                Array.Sort(secondCharsArray);
               
                for (int i = 0; i < firstCharsArray.Length; i++)
                {
                    if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
