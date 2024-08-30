using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class RemoveDuplicates
	{
		public static int RemoveDuplicatesFunc(int[] nums)
		{
			int writeIndex = 1;
			for (int readerIndex = 1; readerIndex < nums.Length; readerIndex++)
			{
				// We skip to next index if we see a duplicate element
				if (nums[readerIndex - 1] != nums[readerIndex])
				{
					/* Storing the unique element at insertIndex index and
					   incrementing the insertIndex by 1 */
					nums[writeIndex] = nums[readerIndex];
					writeIndex++;
				}
			}

			return writeIndex;
		}
	}
}
