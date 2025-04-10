namespace Multus.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class CryptoDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem? item;
}
