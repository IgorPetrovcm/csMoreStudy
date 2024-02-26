namespace Binding;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

		Entry entry = new Entry();
		Label label = new Label();

		StackLayout stack = new StackLayout()
		{
			Children = { entry, label },
			Padding = 20
		};

		label.BindingContext = entry;

		label.SetBinding(Label.TextProperty, "Text");

		Content = stack;
	}
}