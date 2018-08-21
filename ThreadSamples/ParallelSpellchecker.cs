using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace ThreadSamples
{
	internal class ParallelSpellchecker
	{
		private struct IndexedWord { public string Word; public int Index; }
		public static void Run()
		{
			if (!File.Exists("WordLookup.txt")) // Contains about 150,000 words
				new WebClient().DownloadFile(
				"http://www.albahari.com/ispell/allwords.txt", "WordLookup.txt");
			var wordLookup = new HashSet<string>(
			File.ReadAllLines("WordLookup.txt"),
			StringComparer.InvariantCultureIgnoreCase);

			var random = new Random();
			string[] wordList = wordLookup.ToArray();
			string[] wordsToTest = Enumerable.Range(0, 100000000)
			.Select(i => wordList[random.Next(0, wordList.Length)])
			.ToArray();
			wordsToTest[12345] = "woozsh"; // Introduce a couple
			wordsToTest[23456] = "wubsie"; // of spelling mistakes.

			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			var query = wordsToTest
							.AsParallel()
						.Select((word, index) => new IndexedWord { Word = word, Index = index })
						.Where(iword => !wordLookup.Contains(iword.Word))
						.OrderBy(iword => iword.Index).ToList();

			stopwatch.Stop();
			Console.WriteLine($"Run time is {stopwatch.Elapsed.TotalMilliseconds}");
			foreach (var mistake in query)
				Console.WriteLine(mistake.Word + " - index = " + mistake.Index);
		}
	}
}
