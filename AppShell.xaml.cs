namespace Gps;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("track", typeof(TrackPage));
    }
}
