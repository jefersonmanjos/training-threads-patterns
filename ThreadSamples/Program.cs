using System;

namespace ThreadSamples
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			AsyncTest.Run();
			Console.WriteLine("Finish");
			Console.ReadKey();
		}
	}
}
