using System;

namespace DPINT_Wk1_Strategies.NumberConverters
{
	class NumericalNumberConverter : INumberConverter
	{
		public string ToLocalString(int number)
		{
			return number.ToString();
		}

		public int ToNumerical(string text)
		{
			return Int32.Parse(text);
		}
	}
}
