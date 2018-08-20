using System;
using System.Threading;

namespace ThreadSamples
{
	internal class ThreadTestLamda
	{
		public static void Run()
		{
			Thread t = new Thread(() => Console.WriteLine("Hello from T!"));
			t.Start();

			Thread f = new Thread(() => Print("Hello from F!"));
			f.Start();
		}

		private static void Print(string message)
		{
			Console.WriteLine(message);
		}
	}
}
