using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj artystę: ");
            var artist = Console.ReadLine();
            Console.Write("Podaj 5 piosenek tego artysty zatwierdzając enterem: ");
            string[] titles = new string[5];
            for (int i = 0; i < titles.Length; i++)
            {
                titles[i] = Console.ReadLine();
            }

            var yourArtist = new Artist(artist);
            yourArtist.songTitles = new List<string>
            {
                titles[0],
                titles[1],
                titles[2],
                titles[3],
                titles[4]
            };
            yourArtist.CalculateSwearAndWordCount();
            yourArtist.DisplayStatistics();

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }    
}
