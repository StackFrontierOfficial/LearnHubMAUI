using LearnHubMAUI.Screens.appSetting;
using System.Collections.ObjectModel;

namespace LearnHubMAUI.Screens.home;

public partial class homeScreen : ContentPage
{
	public ObservableCollection<CarouselImage> carouselImages { get; set; }
	public homeScreen()
	{
		InitializeComponent();

		carouselImages = new ObservableCollection<CarouselImage>()
		{
			new CarouselImage
			{
			 Title="Shonda Rhymes",
			 StartImage="new_course_1.jpg",
			 ImageText="Shonda describes what fuels her passion."
			},
			new CarouselImage
			{
			 Title="Shonda Rhymes",
			 StartImage="new_course_2.jpg",
			 ImageText="Shonda describes what fuels her passion."
			},
			new CarouselImage
			{
			 Title="Shonda Rhymes",
			 StartImage="new_course_3.jpg",
			 ImageText="Shonda describes what fuels her passion."
			},
			new CarouselImage
			{
			 Title="Shonda Rhymes",
			 StartImage="new_course_4.jpg",
			 ImageText="Shonda describes what fuels her passion."
			},
			new CarouselImage
			{
			 Title="Shonda Rhymes",
			 StartImage="new_course_5.jpg",
			 ImageText="Shonda describes what fuels her passion."
			}
		};

		BindingContext = this;
	}
}