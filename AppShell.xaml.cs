namespace Multus;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NotesDetailPage), typeof(NotesDetailPage));
		Routing.RegisterRoute(nameof(CryptoDetailPage), typeof(CryptoDetailPage));
	}
}
