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

    #region Copilot Generated Yada

    [RelayCommand]
    async Task OnAppearingAsync()
    {
        IsBusy = true;
        IsNotBusy = false;
        await Task.Delay(1000); // Simulate some work
        IsBusy = false;
        IsNotBusy = true;
    }

    [RelayCommand]
    async Task OnDisappearingAsync()
    {
        IsBusy = false;
        IsNotBusy = true;
        await Task.Delay(1000); // Simulate some work
    }

    [RelayCommand]
    async Task OnErrorAsync(string errorMessage)
    {
        IsBusy = false;
        IsNotBusy = true;
        ErrorMessage = errorMessage;
        await Task.Delay(1000); // Simulate some work
    }

    [RelayCommand]
    async Task OnRetryAsync()
    {
        IsBusy = true;
        IsNotBusy = false;
        ErrorMessage = string.Empty;
        await Task.Delay(1000); // Simulate some work
        IsBusy = false;
        IsNotBusy = true;
    }

    [RelayCommand]
    async Task OnCancelAsync()
    {
        IsBusy = false;
        IsNotBusy = true;
        ErrorMessage = string.Empty;
        await Task.Delay(1000); // Simulate some work
    }

    [RelayCommand]
    async Task OnRefreshAsync()
    {
        IsBusy = true;
        IsNotBusy = false;
        await Task.Delay(1000); // Simulate some work
        IsBusy = false;
        IsNotBusy = true;
    }

    [RelayCommand]
    async Task OnLoadMoreAsync()
    {
        IsBusy = true;
        IsNotBusy = false;
        await Task.Delay(1000); // Simulate some work
        IsBusy = false;
        IsNotBusy = true;
    }

    #endregion

    public BaseViewModel()
    {
        IsBusy = false;
        IsNotBusy = true;
        ErrorMessage = string.Empty;
    }
}
