using System.Collections.Generic;

namespace SaLyrics.Entities {
    public class Album {
        public string Title { get; set; }
        public List<Track> Tracks { get; set; }
        public int YearReleased  { get; set; }

    }
}