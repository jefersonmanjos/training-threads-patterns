using System;

namespace Financeiro
{
	public abstract class AbstractFactoryClient
	{
		public abstract ICliente CreateClient();
	}
	public class CreateClienteRihappy : AbstractFactoryClient
	{
		private static CreateClienteRihappy singletonVar;
		public override ICliente CreateClient()
		{
			var name = Console.ReadLine();
			return new ClienteRihappy(name);
		}
		public static AbstractFactoryClient Singleton()
		{
			if (singletonVar != null)
				Console.WriteLine(singletonVar.GetHashCode());

			return singletonVar = singletonVar ?? new CreateClienteRihappy();

		}
	}
	public class CreateCliente : AbstractFactoryClient
	{
		public override ICliente CreateClient()
		{
			var name = Console.ReadLine();
			return new Cliente(name);
		}
	}
}
