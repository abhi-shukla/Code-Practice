using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCheck
{
    public class Class1
    {
        public bool IsUnique(string str) // O(n) or O(c) since n=128
        {
            if(str.Length > 128)
            {
                return false;
            }

            bool[] charSet = new bool[128];
            for(int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if(charSet[val])
                {
                    return false;
                }
                charSet[val] = true;
            }

            return true;
        }

        // for without another data structure compare each charter to every other character
    }
}
