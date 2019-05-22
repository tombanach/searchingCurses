using System;
using System.Net;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            var songLyrics = new SongLyrics("Shakira", "Nada");
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    class SongLyrics
    {
        public SongLyrics(string artist, string title)
        {
            var browser = new WebClient();
            var url = "http://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}