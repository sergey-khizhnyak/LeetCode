using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class ContainsDuplicate
	{
		public static bool ContainsDuplicateFunc(int[] nums)
		{
			return nums.Length - nums.Distinct().ToArray().Length > 0;
		}
	}
}
