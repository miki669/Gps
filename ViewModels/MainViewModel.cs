using System.Windows.Input;
using Track = Gps.Models.Track;

namespace Gps.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public ObservableCollection<Track> Items { get; } = new();


    public ICommand OpenNewPageCommand => new Command<Track>(async (track) =>
    {
        await Shell.Current.GoToAsync("track", new Dictionary<string, object>
        {
            {"TrackModel", track}
        });
    });

    public Track GenerateModel(int day, string month, string Name)
    {



        Random random = new();
        var track = new Track()
        {
            Distansion = string.Format("{0:0.000}", (random.NextDouble() * (5.200 - 5.000) + 5.000)),
            Duration = TimeSpan.FromTicks((long)(random.NextDouble() * (TimeSpan.FromHours(1) - TimeSpan.FromMinutes(30)).Ticks) + TimeSpan.FromMinutes(30).Ticks).ToString(@"hh\:mm\:ss"),
            Location = random.Next(390, 410),
            AverageSpeed = string.Format("{0:#####}", (random.NextDouble() * (10.0 - 9.70) + 9.70)),
            TopSpeed = string.Format("{0:#####}", (random.NextDouble() * (13.50 - 13.20) + 13.20)),
            AverageAltitude = string.Format("{0:#####}", (random.NextDouble() * (161.80 - 160.20) + 160.20)),
            Altitude = string.Format("{0:#####}", (random.NextDouble() * (140.0 - 170.0) + 170.0)),
            Altitude1 = string.Format("{0:#####}", (random.NextDouble() * (140.0 - 170.0) + 170.0)),
            Altitude2 = string.Format("{0:#####}", (random.NextDouble() * (140.0 - 170.0) + 170.0)),
            IdleTime = TimeSpan.FromTicks((long)(random.NextDouble() * (TimeSpan.FromMinutes(20) - TimeSpan.FromMinutes(10)).Ticks) + TimeSpan.FromMinutes(10).Ticks).ToString(@"hh\:mm\:ss"),
            TravelTime = TimeSpan.FromTicks((long)(random.NextDouble() * (TimeSpan.FromMinutes(40) - TimeSpan.FromMinutes(20)).Ticks) + TimeSpan.FromMinutes(20).Ticks).ToString(@"hh\:mm\:ss"),
            latitude = string.Format("{0:#####}", (random.NextDouble() * (65.000000 - 45.000000) + 45.000000)),
            Longitude = string.Format("{0:#####}", (random.NextDouble() * (27.000000 - 47.000000) + 47.000000)),
            Accutacy = random.Next(3, 10),
            Speed = string.Format("{0:#####}", (random.NextDouble() * (7.0 - 3.0) + 3.0)),
            Day = day,
            Month = month,
            Name = Name,
            UrlPhoto = $"photo{(random.Next(1,21))}.jpg"

        };
        return track;
    }
    public ICommand OpenPopupCommand => new Command(async () =>
    {

        var name = await Application.Current.MainPage.DisplayPromptAsync("Напишите `название`", "", "Ок");
        var day = int.Parse(await Application.Current.MainPage.DisplayPromptAsync("Напишите `день`", "", "Ок"));
        var month = await Application.Current.MainPage.DisplayPromptAsync("Напишите `месяц`", "", "Ок");
        var a = GenerateModel(day, month, name);
        Items.Add(a);

    });
}
