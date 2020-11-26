using System;

namespace DPINT_Wk1_Strategies.NumberConverters
{
	class HexadecimalNumberConverter : INumberConverter
	{
		public string ToLocalString(int number)
		{
			return Convert.ToString(number, 16).ToUpper();
		}

		public int ToNumerical(string text)
		{
			return Convert.ToInt32(text, 16);
		}
	}
}
