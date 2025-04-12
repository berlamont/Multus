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

    void CollectionView_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
	    throw new NotImplementedException();
    }

    void OnItemAdded(object? sender, EventArgs e)
    {
	    throw new NotImplementedException();
    }
}
