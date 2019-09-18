using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MusicLab2
{
    public class SearchRequests
    {

        public static IEnumerable<Song> BuildRequest()
        {
            string fileName = "/Users/vitaly/RiderProjects/MusicLab2/MusicLab2/test.txt";
            List<Song> songs = new List<Song>();

            var file = new StreamReader(fileName);
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Song song = new Song("", 0,0.0,"","","","","");
                    string[] words = line.Split('/');
                    song.name = words[0];
                    song.date = Convert.ToInt32(words[1]);
                    song.duration = Convert.ToDouble(words[2]);
                    song.collection = words[3];
                    song.mainGenre = new MainGenre(words[4]);
                    song.subGenre = new SubGenre(words[5]);
                    song.album = new Album(words[6]);
                    song.artist = new Artist(words[7]);
                 
                    songs.Add(song);
                }

                file.Close();
            }
            return songs;
        }

        public static void getFullInfo()
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }

        public static void getFullInfoByArtist(string name)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.artist.name == name
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        
        public static void getFullInfoByYear(int date)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.date == date
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        
        public static void getFullInfoByAlbom(string name)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.album.name == name
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        
        public static void getFullInfoByGenre(string name)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.mainGenre.Name == name
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        
        public static void getFullInfoBySong(string name)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.name == name
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        public static void getFullInfoByDuration(double duration)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.duration == duration
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
        public static void getFullInfoByCollection(string name)
        {
            IEnumerable<Song> songs = SearchRequests.BuildRequest();
            var fullInfo =
                from song in songs
                where song.collection == name
                select song;
            foreach (Song song in fullInfo)
            {
                Console.WriteLine("Song name: " + song.name + "\n" + "Release date: " + Convert.ToString(song.date) + "\n"
                                  +"Song duration: " + Convert.ToString(song.duration, CultureInfo.CurrentCulture) + "\n" 
                                  +"In collection: " + song.collection + "\n" + "Song genre: " + song.mainGenre.Name + "\n" 
                                  + "Song subgenre: " + song.subGenre.Name + "\n" + "In album: " + song.album.name + "\n"
                                  + "Written by: " + song.artist.name + "\n" + "----------=====----------");
            }
        }
    }
}