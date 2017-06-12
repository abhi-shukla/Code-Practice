namespace ReplaceTheSpace
{
    public class Replacer
    {
        public string ReplaceSpace(string str)
        {
            str = str.Trim();

            var spaceCount = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if(char.IsWhiteSpace(str[i]))
                {
                    spaceCount++;
                }
            }

            if (spaceCount == 0)
                return str;

            var newCharacterCount = spaceCount * 2 + str.Length;
            var newStringArray = new char[newCharacterCount];
            var originalStringPoint = str.Length - 1;

            for(int i = newCharacterCount -1; i >=0; i--)
            {
                if(char.IsWhiteSpace(str[originalStringPoint]))
                {
                    newStringArray[i] = '0';
                    newStringArray[i - 1] = '2';
                    newStringArray[i - 2] = '%';

                    i = i - 2;
                }
                else
                {
                    newStringArray[i] = str[originalStringPoint];
                }

                originalStringPoint--;
            }

            return new string(newStringArray);
        }
    }
}
