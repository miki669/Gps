using System.ComponentModel.DataAnnotations;

namespace Gps.Models
{
    public class Track
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Location { get; set; }
        public string AverageSpeed { get; set; }
        public string TopSpeed { get; set; }
        public string AverageAltitude { get; set; }
        [MaxLength(5)]
        public string Altitude1 { get; set; }
        [MaxLength(5)]
        public string Altitude2 { get; set; }
        public string IdleTime { get; set; }
        public string TravelTime { get; set; }

        public string latitude { get; set; }
        public string Longitude { get; set; }
        public int Accutacy { get; set; }
        public string Speed { get; set; }
        public string UrlPhoto { get; set; }

        public string Altitude { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
        public string Distansion { get; set; }
    }
}
