using System;

namespace Financeiro
{
	internal class Program
	{
		private static CreateCliente createCliente = new CreateCliente();
		private static void Main(string[] args)
		{
			Print(createCliente);
			Print(createCliente);
			Print(CreateClienteRihappy.Singleton());
			Print(CreateClienteRihappy.Singleton());
			Print(CreateClienteRihappy.Singleton());
			Console.WriteLine("Hello World!");
		}
		public static void Print(AbstractFactoryClient abstractFactoryClient)
		{
			var cliente = abstractFactoryClient.CreateClient();
			Console.WriteLine(cliente.Name);
		}
	}
}
