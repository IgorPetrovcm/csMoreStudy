using Avalonia.Controls;
using Avalonia.Controls.Platform;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace Calculator
{
	public partial class MainWindow : Window
	{
		private List<int> _values;

		private Queue<Func<int, int, int>> _operations;

		private Dictionary<string, Func<int, int, int>> _listOperations;

		public MainWindow()
		{
			InitializeComponent();

			_values = new List<int>();

			_operations = new Queue<Func<int, int, int>>();

			_listOperations = new Dictionary<string, Func<int, int, int>>();

			_listOperations.Add("plus", (x, y) => x + y);
			_listOperations.Add("minus", (x, y) => x - y);
			_listOperations.Add("multiply", (x, y) => x * y);
			_listOperations.Add("separate", (x, y) => x / y);
		}

		public void BtnWithNumber_Click(object? sender, RoutedEventArgs e)
		{
			if (sender != null)
			{
				Button button = (Button)sender;

				string? number = button.Name?[button.Name.Length - 1].ToString();

				input.Text += number;
			}
		}

		public void BtnWithOperation_Click(object? sender, RoutedEventArgs e)
		{
			if (sender != null)
			{
				Button button = (Button)sender;

				if (button.Name != null)
				{
					int value;

					if (int.TryParse(input.Text, out value))
					{
						_operations.Enqueue(_listOperations[button.Name]);

						_values.Add(value);

						input.Text = "";
					}
				}
			}
		}

		public void BtnEqualTo_Click(object? sender, RoutedEventArgs e)
		{
			int value;

			if (!int.TryParse(input.Text, out value))
				return;

			_values.Add(value);

			int firstVaue = _values[0];
			int secondValue;

			for (int i = 1; i < _values.Count; i++)
			{
				secondValue = _values[i];

				firstVaue = _operations.Dequeue().Invoke(firstVaue, secondValue);
			}

			input.Text = firstVaue.ToString();
		}

		public void BtnClear_Click(object? sender, RoutedEventArgs e)
		{
			_operations.Clear();

			_values.Clear();

			input.Text = "";
		}
	}
}