namespace FirstApp
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count += 20;

			if (count == 1)
			{
				CounterBtn.Text = $"Clicked {count} time";

				Label2.Text = count.ToString();
			}
			else
			{
				CounterBtn.Text = $"Clicked {count} times";

				Label2.Text = count.ToString();
			}

			SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}

}
