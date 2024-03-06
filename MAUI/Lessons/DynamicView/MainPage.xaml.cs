using Microsoft.Maui.Controls.Shapes;

namespace DynamicView
{
	public partial class MainPage : ContentPage
	{
		int count = 1;

		public MainPage()
		{
			InitializeComponent();
		}

		public void btnAddQuestion_Clicked(object sender, EventArgs e)
		{
			Border border = new Border()
			{
				HeightRequest = 200,
				WidthRequest = 1000,
				HorizontalOptions = LayoutOptions.Start,
				StrokeShape = new RoundRectangle() { CornerRadius = 10},
				Margin = new Thickness(0, 10, 0, 0)
			};


			Label lable1 = new Label() { Text = "Question " + count, HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start, FontSize = 20, FontAttributes = FontAttributes.Bold };

			VerticalStackLayout stack = new VerticalStackLayout();
			stack.Children.Add(lable1);

			ScrollView newView = new ScrollView();
			newView.Content = stack;

			border.Content = newView;

			mainStack.Children.Add(border);

			count++;
		}
	}

}
