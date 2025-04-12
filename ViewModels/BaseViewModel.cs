namespace Multus.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isBusy;
    [ObservableProperty]
    string title = string.Empty;
    [ObservableProperty]
    string? errorMessage;
    [ObservableProperty]
    bool isNotBusy = true;
    public BaseViewModel()
    {
        IsBusy = false;
        IsNotBusy = true;
        ErrorMessage = string.Empty;
    }
}
