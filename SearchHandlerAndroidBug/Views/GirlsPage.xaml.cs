using SearchHandlerAndroidBug.ViewModels;

namespace SearchHandlerAndroidBug.Views;

public partial class GirlsPage1 : ContentPage
{
	public GirlsPage1()
	{
		InitializeComponent();
		this.BindingContext = new GirlsPageViewModel();

	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}