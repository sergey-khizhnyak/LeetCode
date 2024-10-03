using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class MajorityElement
	{
		public static int MajorityElementFunc(int[] nums)
		{
			Array.Sort(nums);
			return nums[nums.Length / 2];
		}
	}
}
