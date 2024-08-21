﻿using System;
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
			int insertIndex = 1;
			for (int i = 1; i < nums.Length; i++)
			{
				// We skip to next index if we see a duplicate element
				if (nums[i - 1] != nums[i])
				{
					/* Storing the unique element at insertIndex index and
					   incrementing the insertIndex by 1 */
					nums[insertIndex] = nums[i];
					insertIndex++;
				}
			}

			return insertIndex;
		}
	}
}
