namespace Multus.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class NotesDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem? item;
}
