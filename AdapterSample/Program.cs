using System;

namespace AdapterSample
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Run(new Adaptador());
			Console.WriteLine("Hello World!");
		}

		public static void Run(IInterfaceCliente cliente)
		{
			cliente.Mostrar();
		}
	}
}
