using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class BestTimeToBuyAndSellStock
	{
		public static int MaxProfit(int[] prices)
		{
			var min = prices[0];
			var profit = 0;
			foreach (var today in prices)
			{
				profit = Math.Max(profit, today - min);
				min = Math.Min(min, today);
			}
			return profit;
		}
	}
}
