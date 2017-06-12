namespace StringReplacement
{
    public class Replacer
    {
        public bool IsReplaceable(string s1, string s2)
        {
            if(s1.Length == s2.Length)
            {
                return OnePlaceEdit(s1, s2);
            }
            else if(s1.Length + 1 == s2.Length)
            {
                return ReplaceInPlace(s1, s2);
            }
            else if (s1.Length -1 == s2.Length)
            {
                return ReplaceInPlace(s2, s1);
            }

            return false;
        }

        private bool OnePlaceEdit(string s1, string s2)
        {
            bool changed = false;

            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i])
                {
                    if(changed)
                    {
                        return false;
                    }
                    changed = true;
                }
            }

            return true;
        }

        private bool ReplaceInPlace(string s1, string s2)
        {
            var index1 = 0;
            var index2 = 0;

            while(index2 < s2.Length && index1 < s1.Length)
            {
                if(s1[index1] != s2[index2])
                {
                    if(index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
