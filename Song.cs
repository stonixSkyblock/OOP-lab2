using System;
using System.Collections.Generic;
using System.IO;

namespace MusicLab2
{
    public class Song
    {
        public string name { get; internal set; }
        public int date { get; internal set; }
        public double duration { get; internal set; }
        public string collection { get; internal set; }
        public Artist artist { get; internal set; }
        public Album album { get; internal set; }
        public MainGenre mainGenre { get; internal set; }
        public SubGenre subGenre { get; internal set; }

        public Song(string name, int date, double duration,string collection,string mainGenre,string subGenre, string album, string artist)
            {
               this.name = name;
               this.date = date;
               this.duration = duration;
               this.collection = collection;
               this.mainGenre = new MainGenre(mainGenre);
               this.subGenre = new SubGenre(subGenre);
               this.album = new Album(album);
               this.artist = new Artist(artist);
            }
        }
    }