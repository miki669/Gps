namespace Gps.Views;

public partial class TrackPage : ContentPage
{
	public TrackPage(TrackViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}