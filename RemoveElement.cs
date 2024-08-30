using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class RemoveElement
	{
		// [3,2,2,3], val = 3
		public static int RemoveElementFunc(int[] nums, int val)
		{
			int writerIndex = 0;
			for (int readerIndex = 0; readerIndex < nums.Length; readerIndex++)
			{
				if (nums[readerIndex] != val)
				{
					nums[writerIndex] = nums[readerIndex];
					writerIndex++;
				}
			}

			return writerIndex;
		}
	}
}
