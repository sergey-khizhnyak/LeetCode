namespace LeetCode
{
	public static class RomanToInteger
	{
		public static int RomanToInt(string s)
		{
			// III - 3 
			// IV - 4
			// IX - 9
			// XL - 40
			// XC - 90
			// CD - 400
			// CM - 900
			// LVIII - 58
			// MCMXCIV - 1994
			// MCDLXXVI - 1476
			// MCDL  - 1450 

			var dict = new Dictionary<string, int>()
			{
				{ "I", 1 },   { "V", 5 },    { "X", 10 },  { "L", 50 }, { "C", 100 },
				{ "D", 500 }, { "M", 1000 }, { "IV", 4 },  { "IX", 9 }, { "XL", 40 },
				{ "XC", 90 }, { "CD", 400 }, { "CM", 900 }	
			};

			int sum = 0;
			int i = 0;
			while (i < s.Length)
			{
				if (i < s.Length - 1)
				{
					string doubleSymbol = s.Substring(i, 2);
					if (dict.ContainsKey(doubleSymbol))
					{
						sum += dict[doubleSymbol];
						i += 2;
						continue;
					}
				}

				string singleSymbol = s.Substring(i, 1);
				sum += dict[singleSymbol];
				i += 1;
			}

			return sum;
		}
	}
}
