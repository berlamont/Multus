namespace Multus.Views;

public partial class CryptoPage : ContentPage
{
	CryptoViewModel ViewModel;

	public CryptoPage(CryptoViewModel viewModel)
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
