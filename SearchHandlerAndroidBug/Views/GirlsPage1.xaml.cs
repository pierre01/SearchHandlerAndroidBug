using SearchHandlerAndroidBug.ViewModels;

namespace SearchHandlerAndroidBug.Views;

public partial class GirlsPage : ContentPage
{
	public GirlsPage()
	{
		InitializeComponent();
		this.BindingContext = new GirlsPageViewModel(1);

	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}