using System;

namespace DPINT_Wk1_Strategies.NumberConverters
{
	public class OctalNumberConverter : INumberConverter
	{
		public string ToLocalString(int number)
		{
			return Convert.ToString(number, 8);
		}

		public int ToNumerical(string text)
		{
			return Convert.ToInt32(text, 8);
		}
	}
}
