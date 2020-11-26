namespace DPINT_Wk1_Strategies.NumberConverters
{
	public interface INumberConverter
	{
		string ToLocalString(int number);
		int ToNumerical(string text);
	}
}
