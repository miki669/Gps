using Gps.Models;
using System.Windows.Input;

namespace Gps.ViewModels;


[QueryProperty(nameof(Track), "TrackModel")]
public partial class TrackViewModel : BaseViewModel
{
    [ObservableProperty]
    Track track;

   

    public ICommand Command => new Command(async () =>
    {

       

    });
}