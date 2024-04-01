using Microsoft.Extensions.Logging;

namespace LearnHubMAUI
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
					fonts.AddFont("SignikaNegative-Bold.ttf", "SignNegBold");
					fonts.AddFont("SignikaNegative-Regular.ttf", "SignNegRegular");
					fonts.AddFont("fontawesome-webfont.ttf", "FontAwesome");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
