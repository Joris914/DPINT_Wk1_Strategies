using System.Collections.Generic;

namespace DPINT_Wk1_Strategies.NumberConverters
{
	public class NumberConverterFactory
	{
		public IEnumerable<string> ConverterNames
		{
			get { return _converters.Keys; }
		}

		private Dictionary<string, INumberConverter> _converters;
		public NumberConverterFactory()
		{
			_converters = new Dictionary<string, INumberConverter>();
			_converters["Numerical"] = new NumericalNumberConverter();
			_converters["Hexadecimal"] = new HexadecimalNumberConverter();
			_converters["Binary"] = new BinaryNumberConverter();
			_converters["Roman"] = new RomanNumberConverter();
			_converters["Octal"] = new OctalNumberConverter();
		}

		public INumberConverter getConverter(string name)
		{
			_converters.TryGetValue(name, out INumberConverter value);
			return value;
		}
	}
}
