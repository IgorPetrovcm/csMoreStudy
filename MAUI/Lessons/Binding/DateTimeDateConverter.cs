using System.Globalization;

namespace Binding
{
	internal class DateTimeDateConverter : IValueConverter
	{
		public object Convert(object value, Type targerType, object parameter, CultureInfo culture)
		{
			DateTime dateTime = (DateTime)value;

			return dateTime.ToString("dd.MM.yyyy");
		}

		public object ConvertBack(object value, Type targerType, object parameter, CultureInfo culture)
		{
			return DateTime.Parse(value.ToString());
		}
	}
}
