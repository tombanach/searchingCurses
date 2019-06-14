using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            var eminem = new Artist("Eminem");
             eminem.songTitles = new List<string>
            {
                "Lose Yourself",
                "Not Afraid",
                "Sing for the Moment",
                "Without Me",
                "The Real Slim Shady",
                "Stan",
                "Rap God"
            };

            eminem.CalculateSwearAndWordCount();
            eminem.DisplayStatistics();

            var nickiMinaj = new Artist("Nicki Minaj");
            nickiMinaj.songTitles = new List<string>
            {
                "Bang Bang",
                "Super Bass",
                "Anaconda",
                "Starships"
            };

            nickiMinaj.CalculateSwearAndWordCount();
            nickiMinaj.DisplayStatistics();

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }    
}