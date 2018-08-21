using System;
using System.Threading;

namespace ThreadSamples
{
	internal class ThreadTestSafe
	{
		private bool done;
		private static readonly object locker = new object();
		public static void Run()
		{

			ThreadTestSafe tt = new ThreadTestSafe();
			new Thread(() => tt.Go("coyote")).Start();
			tt.Go("papa léguas");
		}
		private void Go(string from)
		{
			lock (locker)
			{
				if (!done) { Console.WriteLine("Done"); done = true; }
			}
		}
	}
}
