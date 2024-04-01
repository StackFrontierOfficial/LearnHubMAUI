using System.Collections.ObjectModel;

namespace LearnHubMAUI.Screens.appSetting;

public partial class appSettingScreen : ContentPage
{
	public ObservableCollection<CarouselImage> carouselImages { get; set; }
	public appSettingScreen()
	{
		InitializeComponent();

		carouselImages = new ObservableCollection<CarouselImage>()
		{
			new CarouselImage
			{
	         Title="Learn from the best",
             StartImage="start1.jpg",
			 ImageText="Online classes taught by the world's best, Gordon Ramsay, Stephen Curry and more."
			},
			new CarouselImage
			{
		     Title="Download and watch anytime",
			 StartImage="start2.jpg",
			 ImageText="Download up to 10 digestible lessons that you can watch offline at any time."
			},
			new CarouselImage
			{
		     Title="Explore a range of topics",
			 StartImage="start3.jpg",
			 ImageText="Perfect homemade pasta, or write a novel...All wit access 100+ class."
			}
		};

		BindingContext = this;
	}
}

public class CarouselImage
{
    public string? Title { get; set; }
    public string? StartImage { get; set; }
    public string? ImageText { get; set; }
}