namespace FirstApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	public void Button_Clicked(object? sender, EventArgs e)
	{
		string addedText = @"<Label Text=""new label"" />";

		label1.LoadFromXaml(addedText);
	}
}