﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class IndexOfFirstOccurrenceInString
	{
		public static int StrStr(string haystack, string needle)
		{
			// return haystack.IndexOf(needle);

			int m = needle.Length;
			int n = haystack.Length;

			for (int windowStart = 0; windowStart <= n - m; windowStart++)
			{
				for (int i = 0; i < m; i++)
				{
					if (needle[i] != haystack[windowStart + i])
					{
						break;
					}

					if (i == m - 1)
					{
						return windowStart;
					}
				}
			}

			return -1;
		}
	}
}
