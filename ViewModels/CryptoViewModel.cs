namespace Multus.ViewModels;

public partial class CryptoViewModel : BaseViewModel
{
	//readonly SampleDataService dataService;

	//[ObservableProperty]
	//bool isRefreshing;

	//[ObservableProperty]
	//ObservableCollection<Item>? items;

	//public CryptoViewModel(SampleDataService service)
	//{
	//	dataService = service;
	//}

	//[RelayCommand]
	//private async Task OnRefreshing()
	//{
	//	IsRefreshing = true;

	//	try
	//	{
	//		await LoadDataAsync();
	//	}
	//	finally
	//	{
	//		IsRefreshing = false;
	//	}
	//}

	//[RelayCommand]
	//public async Task LoadMore()
	//{
	//	if (Items is null)
	//	{
	//		return;
	//	}

	//	var moreItems = await dataService.GetItems();

	//	foreach (var item in moreItems)
	//	{
	//		Items.Add(item);
	//	}
	//}

	//public async Task LoadDataAsync()
	//{
	//	Items = new ObservableCollection<Item>(await dataService.GetItems());
	//}

	//[RelayCommand]
	//private async Task GoToDetails(Item item)
	//{
	//	await Shell.Current.GoToAsync(nameof(CryptoDetailPage), true, new Dictionary<string, object>
	//	{
	//		{ "Item", item }
	//	});
	//}
}
