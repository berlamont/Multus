using Multus.Views;

namespace Multus
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteItemPage), typeof(NoteItemPage));
        }
    }
}