using System.Collections.Generic;

namespace MusicLab2
{
    public class Album
    {
        public string name { get; }
        public Artist artist { get; }
        private IEnumerable<Song> songs;
       
        public Album(string name)
        {
            this.name = name;
        }
        public Album(Artist artist)
        {
            this.artist = new Artist(artist.name);
        }
    }
}