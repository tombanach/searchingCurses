using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            var songLyrics = new SongLyrics("Eminem", "Without me");
            var profanityFinder = new ProfanityFinder();

            var vulgar = "Programowanie jest w chuj fajne";
            var censored = profanityFinder.Censore(songLyrics.lyrics);

            Console.WriteLine(censored);

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    internal class ProfanityFinder
    {
        private string[] badWords;
        public ProfanityFinder()
        {
            var dictFile = File.ReadAllText("profanities.txt");
            dictFile = dictFile.Replace("*", "");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badWords = dictFile.Split(new[] { "\",\"" }, StringSplitOptions.None);
        }

        internal object Censore(string text)
        {
            foreach (var word in badWords)
                text = RemoveBadWord(text, word);

            return text;
        }

        static string RemoveBadWord(string text, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(text, pattern, "____", RegexOptions.IgnoreCase);
        }
    }
}