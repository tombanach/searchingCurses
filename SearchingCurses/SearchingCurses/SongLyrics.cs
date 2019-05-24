using Newtonsoft.Json;
using System;
using System.Net;

namespace SearchingCurses
{
    class SongLyrics
    {
        public string artist;
        public string title;
        public string lyrics;
        public SongLyrics(string artist, string title)
        {
            var browser = new WebClient();
            var url = "http://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = browser.DownloadString(url);
            var answer = JsonConvert.DeserializeObject<LyricsOvhAnswer>(json);
            lyrics = answer.lyrics;
            this.artist = artist;
            this.title = title;
        }
    }
}