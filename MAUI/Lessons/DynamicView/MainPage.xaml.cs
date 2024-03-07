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

		public void btnAddQuestion_Clicked(object? sender, EventArgs e)
		{
			Border border = new Border()
			{
				HeightRequest = 400,
				WidthRequest = 1000,
				HorizontalOptions = LayoutOptions.Start,
				StrokeShape = new RoundRectangle() { CornerRadius = 10},
				Margin = new Thickness(0, 10, 0, 0)
			};


			Label lable1 = new Label() { Text = "Question " + count, HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start, FontSize = 20, FontAttributes = FontAttributes.Bold };

			HorizontalStackLayout horizontalStack = new HorizontalStackLayout();

			Label label2 = new Label() { Text = "Question: ", HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start, FontSize = 17, Margin = new Thickness(0, 5, 0, 0) };

			Entry question = new Entry() { WidthRequest = 700, ClassId = "question" + count};
			Button btnAddAnswerOption = new Button() { Text = "Add Answer Option", Margin = new Thickness(50, 0, 0, 0) };

			int currentCount = count;

			btnAddAnswerOption.Clicked += (x, y) => btnAddAnswerOption_Clicked(btnAddAnswerOption, currentCount);

			horizontalStack.Children.Add(label2);
			horizontalStack.Children.Add(question);
			horizontalStack.Children.Add(btnAddAnswerOption);

			VerticalStackLayout radious = new VerticalStackLayout() { ClassId = "radios" };

			VerticalStackLayout stack = new VerticalStackLayout() { ClassId = "stack" + count};
			stack.Children.Add(lable1);
			stack.Children.Add(horizontalStack);
			stack.Children.Add(radious);

			ScrollView newView = new ScrollView();
			newView.Content = stack;

			border.Content = newView;

			mainStack.Children.Add(border);

			count++;
		}

		public void btnAddAnswerOption_Clicked(object? sender, int count)
		{
			Button btn = (Button)sender;

			IList<IView> views = mainStack.Children;

			foreach (IView view in views)
			{
				if (view is Border)
				{
					Border border = (Border)view;
					ScrollView scroll = border.Content as ScrollView;

					VerticalStackLayout stack = scroll.Content as VerticalStackLayout;

					foreach (IView child in stack.Children)
					{
						if (child is VerticalStackLayout)
						{
							VerticalStackLayout horizontal = (VerticalStackLayout)child;

							if (horizontal.ClassId == "radios")
							{
								CheckBox checkBox = new CheckBox();
								Entry entry = new Entry();

								checkBox.BindingContext = entry;
								checkBox.SetBinding(RadioButton.ContentProperty, "Text");

								horizontal.Children.Add(checkBox);
								horizontal.Children.Add(entry);
							}
						}
					}

					break;
				}
			}
		}
	}

}
