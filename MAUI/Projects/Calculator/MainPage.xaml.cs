using Microsoft.Maui.Controls.Shapes;

namespace Calculator
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();

			Grid grid = new Grid()
			{
				Padding = new Thickness(5, 5, 5, 5)
			};

			Border border = new Border()
			{
				Stroke = Colors.Blue,
				BackgroundColor = Colors.Gray,
				StrokeShape = new RoundRectangle() { CornerRadius = 15},
				StyleId = "mainBorder"
			};

			Grid innerInBorderGrid = new Grid()
			{
				RowDefinitions =
					{
						new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) },
						new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) },
						new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) },
						new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) },
						new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) },
					},
				ColumnDefinitions =
					{
						new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) },
						new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) },
						new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) },
						new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) },
					},

				Padding = new Thickness(5, 5, 5, 5),
				RowSpacing = 25
			};

			int row = 1;
			int column = 0;

			for (int i = 0; i < 9; i++)
			{
				if (column == 3)
				{
					row++;
					column = 0;
				}

				Button button = new Button { Text = (i + 1).ToString(), StyleId = "number" + i + 1, Margin = new Thickness(5,5,5,5), FontSize=20, HeightRequest = 80,  };

				button.Clicked += ButtonWithNumberClicked;

				innerInBorderGrid.Add(button, column, row);

				column++;
			}

			Button btnAnswer = new Button() { Text = "=", StyleId = "btn=", Margin = new Thickness(5, 5, 5, 5), FontSize = 20, HeightRequest = 80 };

			Button btnDivision = new Button() { Text = "/", StyleId = "btn/", Margin = new Thickness(5, 5, 5, 5), FontSize = 20, HeightRequest = 80 };

			Button btnZero = new Button() { Text = "0", StyleId = "btn0", Margin = new Thickness(5, 5, 5, 5), FontSize = 20, HeightRequest = 80 };

			Entry entry = new Entry()
			{
				Margin = new Thickness(0,0,0,5), 
				FontSize = 20,
				StyleId = "inputNumbers",
				ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
				Keyboard = Keyboard.Numeric,
				MaxLength = 8,
				BackgroundColor = Colors.WhiteSmoke
			};
			innerInBorderGrid.Add(entry, 0, 0);
			innerInBorderGrid.SetColumnSpan(entry, 4);

			innerInBorderGrid.Add(btnAnswer, 2, 4);
			innerInBorderGrid.Add(btnDivision, 0, 4);
			innerInBorderGrid.Add(btnZero, 1, 4);

			border.Content = innerInBorderGrid;

			grid.Add(border);

			Content = grid;
		}

		private void ButtonWithNumberClicked(object? sender, EventArgs e)
		{
			Button button = sender as Button;

			Border border = this.FindByName<Border>("mainBorder");

			Entry entry = border.FindByName<Entry>("inputNumbers");

			entry.Text += button.StyleId[StyleId.Length - 1];
		}

	}

}
