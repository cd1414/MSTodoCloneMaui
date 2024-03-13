using Microsoft.Extensions.Logging;
using DotNet.Meteor.HotReload.Plugin;
using CommunityToolkit.Maui;

namespace ToDoMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fontello.ttf", "Icons");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).UseMauiCommunityToolkit();

#if DEBUG

		builder.Logging.AddDebug();
		builder.EnableHotReload();
#endif

		return builder.Build();
	}
}

