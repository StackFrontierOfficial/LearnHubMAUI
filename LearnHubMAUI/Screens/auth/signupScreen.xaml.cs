namespace LearnHubMAUI.Screens.auth;

public partial class signupScreen : ContentPage
{
	public string EyeIcon { get; private set; } = "view.png";
	public string EyeSlashIcon { get; private set; } = "hide.png";
	private bool isPasswordVisible = false;
	private bool isCrfmPasswordVisible = false;
	public signupScreen()
	{
		InitializeComponent();
		BindingContext = this;

	}


	private void TogglePasswordVisibility(object sender, EventArgs e)
	{
		isPasswordVisible = !isPasswordVisible;
		passwordEntry.IsPassword = !isPasswordVisible;
		((ImageButton)sender).Source = ImageSource.FromFile(isPasswordVisible ? EyeIcon : EyeSlashIcon);
	}
	private void ToggleConfirmPasswordVisibility(object sender, EventArgs e)
	{
		isCrfmPasswordVisible = !isCrfmPasswordVisible;
		confirmPasswordEntry.IsPassword = !isCrfmPasswordVisible;
		((ImageButton)sender).Source = ImageSource.FromFile(isCrfmPasswordVisible ? EyeIcon : EyeSlashIcon);
	}
}