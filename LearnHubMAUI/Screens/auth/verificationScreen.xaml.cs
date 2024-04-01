namespace LearnHubMAUI.Screens.auth;

public partial class verificationScreen : ContentPage
{
	public Color bgColor {  get; set; }
	
	public verificationScreen()
	{
		InitializeComponent();
		bgColor = Colors.White;

		BindingContext = this;
	}

	private  void Button_Clicked(object sender, EventArgs e)
	{
		bgColor = Color.FromRgba(175, 175, 175, 0.7);
		indicator.IsVisible = true;
	}
}