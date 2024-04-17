using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var brackets = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (brackets.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    var symbol = brackets.FirstOrDefault(x => x.Value == c).Key;
                    if (stack.TryPeek(out char result) && result == symbol)
                    {
                        stack.Pop();
                    }
                    else
                    { 
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
