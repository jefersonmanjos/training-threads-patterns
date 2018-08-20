using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSamples
{
	internal class AsyncTest
	{
		public static async void Run()
		{
			var result = await AccessTheWebAsync();
			Console.WriteLine($"Length is {result}");
		}
		private static async Task<int> AccessTheWebAsync()
		{
			HttpClient client = new HttpClient();
			Task<string> getStringTask = client.GetStringAsync("http://packdocs.com");
			DoIndependentWork();
			string urlContents = await getStringTask;
			return urlContents.Length;
		}

		private static void DoIndependentWork()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(1000);
			}
		}
	}
}
