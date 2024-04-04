using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public static class CountWords
    {
        public static int CountWordsInSentence(string value)
        {
            int count = 0;
            bool inWord = false;
            for (int i = 0; i < value.Length; i++)
            {
                bool isWhiteSpaceOrPunctuation = Char.IsWhiteSpace(value[i]) || Char.IsPunctuation(value[i]);
                if (!inWord && !isWhiteSpaceOrPunctuation)
                    count++;
                inWord = !isWhiteSpaceOrPunctuation;
            }
            return count;
        }
    }
}
