namespace Multus.Views;

public partial class NotesDetailPage : ContentPage
{
	public NotesDetailPage(NotesDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
