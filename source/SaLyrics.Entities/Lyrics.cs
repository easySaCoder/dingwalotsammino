using System.Collections.Generic;

namespace SaLyrics.Entities {
    public class Lyrics {

        public List<string> ZeroToZArtistPrefix {
            get { return ArtistPrefix(); }
        }
        


        private List<string> ArtistPrefix(){
            List<string> AtoZ = new List<string>();
            AtoZ.Add("A");
            AtoZ.Add("b");
            AtoZ.Add("c");
            AtoZ.Add("d");
            AtoZ.Add("e");
            AtoZ.Add("f");
            AtoZ.Add("g");
            AtoZ.Add("h");
            AtoZ.Add("i");
            AtoZ.Add("j");
            AtoZ.Add("k");
            AtoZ.Add("l");
            AtoZ.Add("m");
            AtoZ.Add("n");
            AtoZ.Add("o"); 
            AtoZ.Add("p");
            AtoZ.Add("q"); 
            AtoZ.Add("r");
            AtoZ.Add("s"); 
            AtoZ.Add("t");
            AtoZ.Add("u");
            AtoZ.Add("v");
            AtoZ.Add("x");
            AtoZ.Add("y");
            AtoZ.Add("z");
            AtoZ.Add("#");
            return AtoZ;
        }



    }




}