namespace Multus.Views;

public partial class NotesPage : ContentPage
{
	NotesViewModel ViewModel;

	public NotesPage(NotesViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
