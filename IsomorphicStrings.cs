using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class IsomorphicStrings
	{
		public static bool IsIsomorphic(string s, string t)
		{
			if (s.Length != t.Length)
				return false;

			var mappings = new Dictionary<char, char>();

			for (int i = 0; i < s.Length; i++)
			{
				if (!mappings.ContainsKey(s[i]))
				{
					if (mappings.ContainsValue(t[i])) return false;
					mappings.Add(s[i], t[i]);
				}
				else
				{
					if (t[i] != mappings[s[i]])
						return false;
				}
			}

			return true;

		}
	}
}

//var dict = new Dictionary<char, char>();
//for (int i = 0; i < s.Length; i++)
//{
//	if (dict.ContainsKey(s[i]))
//	{
//		if (t[i] != dict[s[i]]) return false;
//	}
//	else
//	{
//		if (dict.ContainsValue(t[i])) return false;
//		dict.Add(s[i], t[i]);
//	}
//}
//return true;
