using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromePermutation
{
    public class Checker
    {
        public bool IsPermutationOfPalindrome(string input)
        {
            var table = BuildCharacterFrequency(input);

            return CheckMaxOdd(table);
        }

        bool CheckMaxOdd(int[] table)
        {
            bool foundOdd = false;
            for(int i= 0; i < table.Length; i++)
            {
                if(table[i] % 2 == 1)
                {
                    if(foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }

            return true;
        }

        int GetCharacterNumber(char c)
        {
            int a = 'a';
            int z = 'z';
            int val = c;

            if(a <= val && val <=z)
            {
                return val - a;
            }

            return -1;
        }

        int[] BuildCharacterFrequency(string str)
        {
            int[] table = new int['z' - 'a' + 1];

            for(int i = 0;i < str.Length; i++)
            {
                int x = GetCharacterNumber(str[i]);
                if(x != -1)
                {
                    table[x]++;
                }
            }

            return table;
        }
    }
}
