

namespace Calculator
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			Window window = base.CreateWindow(activationState);

			window.Height = 450;
			window.Width = 400;
			window.MaximumWidth = 500;
			window.MinimumWidth = 400;
			window.MaximumHeight = 500;
			window.MinimumHeight = 400;
			return window;
		}
	}
}
