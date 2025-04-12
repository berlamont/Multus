using Multus.Database;

namespace Multus.ViewModels;

public partial class TodoViewModel : BaseViewModel
{

    MultusDb _multusDatabase;
    
    public ObservableCollection<TodoItem> Items { get; set; } = new();

    public TodoViewModel(MultusDb multusDatabase)
	{
        _multusDatabase = multusDatabase;
    }

    //protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //    var items = await _multusDatabase.GetItemsAsync();
    //    MainThread.BeginInvokeOnMainThread(() =>
    //    {
    //        Items.Clear();
    //        foreach (var item in items)
    //            Items.Add(item);

    //    });
    //}
    //async void OnItemAdded(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync(nameof(TodoItemPage), true, new Dictionary<string, object>
    //    {
    //        ["Item"] = new TodoItem()
    //    });
    //}

    //private async void  CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //{
    //    if (e.CurrentSelection.FirstOrDefault() is not TodoItem item)
    //        return;

    //    await Shell.Current.GoToAsync(nameof(TodoItemPage), true, new Dictionary<string, object>
    //    {
    //        ["Item"] = item
    //    });
    //}
    public void OnAppearing()
    {
        throw new NotImplementedException();
    }
}
