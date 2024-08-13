using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class LongestCommonPrefix
	{
		// ["flower","flow","flight"]
		public static string FindLongestCommonPrefix(string[] strs)
		{
			// My Implementaion:
			//var shortest = strs.OrderBy(s => s.Length).FirstOrDefault();
			//var sb = new StringBuilder();

			//for (int i = 0; i < shortest.Length; i++)
			//{
			//	if (strs.All(s => s.StartsWith(shortest.Substring(0, i + 1))))
			//	{
			//		sb.Append(shortest[i]);
			//	}
			//}	
			//return sb.Length == 0 ? "" : sb.ToString();

			// LeetCode implementation:

			if (strs.Length == 0)
				return "";
			string prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix.Substring(0, prefix.Length - 1);
					if (prefix == "")
						return "";
				}

			return prefix;
		}
	}
}
