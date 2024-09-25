using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
	public static class HappyNumber
	{
		public static bool IsHappy(int n)
		{
			HashSet<int> set = new HashSet<int>();

			while (n != 1)
			{
				string str = n.ToString();
				int sum = 0;

				foreach (char c in str)
				{
					int digit = c - '0';
					sum += digit * digit;
				}

				if (set.Contains(sum))
					return false;

				set.Add(sum);
				n = sum;
			}

			return true;
		}
	}
}
