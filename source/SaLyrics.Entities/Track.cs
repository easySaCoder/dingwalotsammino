using System.Collections.Generic;

namespace SaLyrics.Entities {
    public class Track {
        public int Number { get; set; }
        public string title { get; set; }
        public List<string> FeaturedArtist { get; set; }
        public List<string> Producers { get; set; }
    }
}
