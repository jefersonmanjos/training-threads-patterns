using System;
using System.Threading;

namespace ThreadSamples
{
	internal class BackgoundThread
	{
		public static void Run()
		{
			Thread worker = new Thread(() =>
			{
				int i = 0;
				while (true)
				{
					Thread.Sleep(1000);
					Console.WriteLine(++i);
				}
			});
			worker.IsBackground = true;
			worker.Start();
		}
	}
}
