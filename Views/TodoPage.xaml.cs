namespace Multus.Views;

public partial class TodoPage : ContentPage
{
	public TodoPage(TodoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
