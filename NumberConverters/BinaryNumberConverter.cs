using System;

namespace DPINT_Wk1_Strategies.NumberConverters
{
	class BinaryNumberConverter : INumberConverter
	{
		public string ToLocalString(int number)
		{
			return Convert.ToString(number, 2);
		}

		public int ToNumerical(string text)
		{
			return Convert.ToInt32(text, 2);
		}
	}
}
