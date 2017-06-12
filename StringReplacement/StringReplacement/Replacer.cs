using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacement
{
    public class Replacer
    {
        public bool IsReplaceable(string s1, string s2)
        {
            if(s1.Length == s2.Length)
            {
                return ReplaceInPlace(s1, s2);
            }
            else if(s1.Length + 1 == s2.Length)
            {
                return OnePlaceEdit(s1, s2);
            }
            else if (s1.Length -1 == s2.Length)
            {
                return OnePlaceEdit(s2, s1);
            }

            return false;
        }

        private bool OnePlaceEdit(string s1, string s2)
        {
            
        }

        private bool ReplaceInPlace(string s1, string s2)
        {
            
        }
    }
}
