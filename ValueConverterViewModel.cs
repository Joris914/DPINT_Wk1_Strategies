using DPINT_Wk1_Strategies.NumberConverters;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DPINT_Wk1_Strategies
{
	public class ValueConverterViewModel : ViewModelBase
	{
		private string _fromText;
		public string FromText
		{
			get { return _fromText; }
			set
			{
				_fromText = value;
				RaisePropertyChanged("FromText");
				this.ConvertNumbers();
			}
		}

		private string _toText;
		public string ToText
		{
			get { return _toText; }
			set
			{
				_toText = value;
				RaisePropertyChanged("ToText");
			}
		}

		private string _fromConverterName;
		public string FromConverterName
		{
			get { return _fromConverterName; }
			set
			{
				_fromConverterName = value;
				RaisePropertyChanged("FromConverterName");
				FromConverter = Factory.getConverter(value);
				this.ConvertNumbers();
			}
		}

		private string _toConverterName;
		public string ToConverterName
		{
			get { return _toConverterName; }
			set
			{
				_toConverterName = value;
				RaisePropertyChanged("ToConverterName");
				ToConverter = Factory.getConverter(value);
				this.ConvertNumbers();
			}
		}

		public INumberConverter _fromConverter;
		public INumberConverter FromConverter
		{
			get { return _fromConverter; }
			set
			{
				_fromConverter = value;
				RaisePropertyChanged("FromConverter");
				this.ConvertNumbers();
			}
		}
		public INumberConverter _toConverter;
		public INumberConverter ToConverter
		{
			get { return _toConverter; }
			set
			{
				_toConverter = value;
				RaisePropertyChanged("ToConverter");
				this.ConvertNumbers();
			}
		}

		public ObservableCollection<string> ConverterNames { get; set; }
		public ICommand ConvertCommand { get; set; }
		public NumberConverterFactory Factory { get; set; }


		public ValueConverterViewModel()
		{
			Factory = new NumberConverterFactory();
			ConverterNames = new ObservableCollection<string>();
			foreach (string name in Factory.ConverterNames)
			{
				ConverterNames.Add(name);
			}

			FromConverter = Factory.getConverter("Numerical");
			ToConverter = Factory.getConverter("Numerical");
			FromConverterName = "Numerical";
			ToConverterName = "Numerical";

			FromText = "0";
			ToText = "0";

			ConvertCommand = new RelayCommand(ConvertNumbers);
		}

		private void ConvertNumbers()
		{
			try
			{
				int number = _fromConverter.ToNumerical(FromText);
				ToText = _toConverter.ToLocalString(number);
			}
			catch
			{
				ToText = "Error";
			}
		}
	}
}
