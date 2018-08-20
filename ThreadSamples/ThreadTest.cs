using System;
using System.Threading;

namespace ThreadSamples
{
	internal class ThreadTest
	{
		public static void Run()
		{
			Thread t = new Thread(new ThreadStart(Go));
			t.Start(); // Run Go() on the new thread.
			Go(); // Simultaneously run Go() in the main thread.
		}

		private static void Go()
		{
			Console.WriteLine("hello!");
		}
	}
}
