namespace Multus.Views;

public partial class TodoPage : ContentPage
{
	public TodoPage(TodoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is TodoViewModel viewModel)
        {
            viewModel.OnAppearing();
        }
    }
}
