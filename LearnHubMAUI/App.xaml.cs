using LearnHubMAUI.Screens.appSetting;
using LearnHubMAUI.Screens.auth;
using LearnHubMAUI.Screens.home;

namespace LearnHubMAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new homeScreen();
			MainPage = new ArtPhotographyScreen();
			//MainPage = new VerificationInProgress();
			//MainPage = new verificationScreen();
			//MainPage = new signinScreen();
			//MainPage = new signupScreen();
			//MainPage = new appSettingScreen();
		}
	}
}
