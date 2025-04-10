namespace Multus;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<CryptoDetailViewModel>();
		builder.Services.AddTransient<CryptoDetailPage>();

		builder.Services.AddSingleton<CryptoViewModel>();

		builder.Services.AddSingleton<CryptoPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<NotesDetailViewModel>();
		builder.Services.AddTransient<NotesDetailPage>();

		builder.Services.AddSingleton<NotesViewModel>();

		builder.Services.AddSingleton<NotesPage>();

		builder.Services.AddSingleton<TodoViewModel>();

		builder.Services.AddSingleton<TodoPage>();

		return builder.Build();
	}
}
