using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
namespace MusicLab2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  IEnumerable<Song> songs = SearchRequests.BuildRequest();
         SearchRequests.getFullInfo();
        Console.WriteLine();

          SearchRequests.getFullInfoByArtist("John");
        Console.WriteLine();
     
        SearchRequests.getFullInfoByYear(2017);
        Console.WriteLine();
        
        SearchRequests.getFullInfoByAlbom("Plagiat");
        Console.WriteLine();
        
        SearchRequests.getFullInfoByGenre("pop");
        Console.WriteLine();
        
        SearchRequests.getFullInfoBySong("Black Monday");
        Console.WriteLine();
        
        SearchRequests.getFullInfoByDuration(1.46);
        Console.WriteLine();
        
        SearchRequests.getFullInfoByCollection("VitCollection");
        Console.WriteLine();
        
        }
    }
}