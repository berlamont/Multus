using Multus.Data;
using Multus.Models;

namespace Multus.Views
{
    public partial class NoteItemPage : ContentPage
    {
        public NoteItemPage(NotesDatabase notesDatabase)
        {
            InitializeComponent();
            database = notesDatabase;
        }

        public NoteItem Item
        {
            get => BindingContext as NoteItem;
            set => BindingContext = value;
        }

        NotesDatabase database;

        async void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Item.Name))
            {
                await DisplayAlert("Name Required", "Please enter a name ", "OK");
                return;
            }

            await database.SaveItemAsync(Item);
            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (Item.ID == 0)
                return;
            await database.DeleteItemAsync(Item);
            await Shell.Current.GoToAsync("..");
        }

        async void OnCancelClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    }
}