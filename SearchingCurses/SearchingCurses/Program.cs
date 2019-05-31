using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SearchingCurses
{
    class Program
    {
        static void Main()
        {
            var webcache = new WebCache();

            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string>
            {
                "Lose Yourself",
                "Not Afraid",
                "Sing for the Moment"
            };

            eminem.CalculateSwearAndWordCount();
            eminem.DisplayStatistics();

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    internal class WebCache
    {
        SQLiteConnection connection;
        public WebCache()
        {
            connection = new SQLiteConnection("Data Source=WebCache.sqlite");
            connection.Open();
        }

        public void SaveInCache(string url, string data)
        {
            var sql = new SQLiteCommand(
                "INSERT INTO cache (url, data) VALUES (?, ?)", connection);
            sql.Parameters.Add(url, DbType.String);
            sql.Parameters.Add(data, DbType.String);
            sql.ExecuteNonQuery();
        }
    }
}