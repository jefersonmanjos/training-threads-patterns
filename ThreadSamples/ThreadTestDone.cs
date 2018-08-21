using System;
using System.Threading;

namespace ThreadSamples
{
	internal class ThreadTestDone
	{
		private bool done;

		public static void Run()
		{
			ThreadTestDone tt = new ThreadTestDone();
			new Thread(() => tt.Go("coyote")).Start();

			tt.Go("papa léguas");
		}
		private void Go(string from)
		{
			if (!done)
			{
				Console.WriteLine($"Done from {from}");
				done = true;
			}
		}
	}
}
