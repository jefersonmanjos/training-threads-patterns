using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			new Program().CalculadoraAsync().Wait();
			Console.WriteLine("Finish");
		}
		public async Task CalculadoraAsync()
		{
			var taskSoma = Soma();
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine($"Result {await taskSoma}");

		}

		private static async Task<int> Soma()
		{
			return await Task.Run<int>(() =>
			{
				int soma = 0;
				for (int i = 0; i < 10; i++)
				{
					soma += i;
					Console.WriteLine($"{soma}");
				}
				return soma;
			});
		}
	}
}
