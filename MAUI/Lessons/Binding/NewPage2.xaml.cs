namespace Binding;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();

		Label label = new Label();
		DatePicker datePicker = new DatePicker();

		label.BindingContext = datePicker;
		label.SetBinding(Label.TextProperty, "Date", converter: new DateTimeDateConverter());

		StackLayout stack = new StackLayout()
		{
			Children = { label, datePicker },
			Padding = 20
		};

		Content = stack;
	}
}