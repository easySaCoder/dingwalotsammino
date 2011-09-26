using System;
using System.Collections.Generic;

namespace SaLyrics.Entities {
    public class Artist {
        public Guid Id { get; set; }
        public string Name   { get; set; }
        public List<string> NickNames { get; set; }
        public List<Album> Albums { get; set; }
    }
}