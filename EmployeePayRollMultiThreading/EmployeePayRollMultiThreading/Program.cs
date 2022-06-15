using System;
using System.Net;
using System.Text;
using EmployeePayRollMultiThreading;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee pay roll using Threads");
        string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
        Parallel.Invoke(() =>
        {
            Console.WriteLine("Begin first task..");
            GetLongestWord(words);
        },
        () =>
        {
            Console.WriteLine("Begin second task");
            GetMostCommonWords(words);
        },
        () =>
        {
            Console.WriteLine("Begin third task");
            GetCountForWord(words, "sleep");
        }
        );
    }
    static string[] CreateWordArray(string url)
    {
        Console.WriteLine($"Retriving from {url}");
        string s = new WebClient().DownloadString(url);
        return s.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' }, StringSplitOptions.RemoveEmptyEntries);
    }

    private static void GetCountForWord(string[] words, string term)
    {
        var findWord = from word in words
                       where word.ToUpper().Contains(term.ToUpper())
                       select word;
        Console.WriteLine($@"Task 3 -- The word""{term}"" occurs {findWord.Count()} times");
    }
    private static void GetMostCommonWords(string[] words)
    {
        var frequencyOrder = from word in words
                             where word.Length > 6
                             group word by word into g
                             orderby g.Count() descending
                             select g.Key;
        var commonWords = frequencyOrder.Take(10);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Task 2 -- The most common words are: ");
        foreach (var word in commonWords)
        {
            sb.Append(" " + word);
        }
        Console.WriteLine(sb.ToString());
    }
    private static string GetLongestWord(string[] words)
    {
        var longestWord = (from word in words orderby word.Length descending select word).First();
        Console.WriteLine($"Task 1 -- The longest word is {longestWord}.");
        return longestWord;
    }
}