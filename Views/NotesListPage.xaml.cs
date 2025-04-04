using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multus.Data;
using Multus.Models;
using Microsoft.Maui.ApplicationModel;

namespace Multus.Views;

public partial class NotesListPage : ContentPage
{
    NotesDatabase database;
    public ObservableCollection<NoteItem> Items { get; set; } = new();
    public NotesListPage(NotesDatabase todoItemDatabase)
    {
        InitializeComponent();
        database = todoItemDatabase;
        BindingContext = this;
    }


    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var items = await database.GetItemsAsync();
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Items.Clear();
            foreach (var item in items)
                Items.Add(item);

        });
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NoteItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new NoteItem()
        });
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not NoteItem item)
            return;

        await Shell.Current.GoToAsync(nameof(NoteItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }
}