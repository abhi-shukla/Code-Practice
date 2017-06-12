using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation
{
    public class Checker
    {
        public bool ArePermutationsV1(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }

            var container = new Dictionary<char, int>();

            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i]) continue;

                if(container.ContainsKey(s1[i]))
                {
                    var val = container[s1[i]];
                    container[s1[i]] = ++val;
                }
                else
                {
                    container.Add(s1[i], 1);
                }

                if (container.ContainsKey(s2[i]))
                {
                    var val = container[s2[i]];
                    container[s2[i]] = --val;
                }
                else
                {
                    container.Add(s2[i], -1);
                }
            }

            var res = container.Values.Select(s => s).Where(x => x < 0);
            if(res.Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}
