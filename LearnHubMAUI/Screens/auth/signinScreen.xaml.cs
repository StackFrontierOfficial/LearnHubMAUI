namespace LearnHubMAUI.Screens.auth;

public partial class signinScreen : ContentPage
{
	public string EyeIcon { get; private set; } = "view.png";
	public string EyeSlashIcon { get; private set; } = "hide.png";
	private bool isPasswordVisible = false;
	public signinScreen()
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
}