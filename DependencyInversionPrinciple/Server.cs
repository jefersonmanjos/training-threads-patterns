namespace DependencyInversionPrinciple
{
	internal class Server : IServer
	{
		public string DNS { get; }
		public IHost Host { get; }

		public Server(IHost host)
		{
			Host = host;
		}
	}
}
