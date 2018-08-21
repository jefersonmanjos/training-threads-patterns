using System;

namespace ThreadSamples
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//AsyncTest.Run();
			new Program().MainAsyn();
			Console.WriteLine("Finish");
			Console.ReadKey();
		}

		public async void MainAsyn()
		{
			AsyncTest.Run();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"X{i}");
				//Thread.Sleep(1000);
			}

		}
	}
}
