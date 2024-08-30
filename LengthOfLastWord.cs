using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class LengthOfLastWord
	{

		//s = s.Trim();  // trim the trailing spaces in the string
	   // return s.Length - s.LastIndexOf(" ") - 1;

		public static int LengthOfLastWordFunc(string s)
		{
			bool chracterHit = false;
			string lastWord = string.Empty;
			for (int i = s.Length - 1; i >= 0 ; i--)
			{
				if (s[i] == ' ')
				{
					if (!chracterHit)
						continue;
					return lastWord.Length;
				}
				chracterHit = true;
				lastWord += s[i];
			}
			return lastWord.Length;
		}
	}
}
