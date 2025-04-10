namespace Multus.Views;

public partial class CryptoDetailPage : ContentPage
{
	public CryptoDetailPage(CryptoDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
