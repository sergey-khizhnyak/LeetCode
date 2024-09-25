using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class ValidPalindrome
	{
		// "A man, a plan, a canal: Panama"
		public static bool IsPalindromeFunc(string s)
		{
			string filteredString = String.Empty;
			foreach (char ch in s)
			{
				if (Char.IsLetterOrDigit(ch))
				{
					filteredString += Char.ToLower(ch);
				}
			}

			char[] reversedChars = filteredString.ToCharArray();
			Array.Reverse(reversedChars);
			string reversedString = new string(reversedChars);
			return filteredString == reversedString;
		}
	}
}
