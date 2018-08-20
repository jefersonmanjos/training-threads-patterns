using Autofac;
using System;

namespace DependencyInversionPrinciple
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IContainer container;
			var builder = new ContainerBuilder();
			builder.RegisterType<Server>().As<IServer>();
			builder.RegisterType<Host>().As<IHost>();
			container = builder.Build();
			var server = container.Resolve<IServer>();
			server.Host.Add(new Person("Jeferson"));
			Console.WriteLine(server.Host.Count());
		}














		//public static void Main(string[] args)
		//{
		//	IContainer container;
		//	container = new Startup().Configure();

		//	var mediator = container.Resolve<IMediator>();
		//	mediator.Send(new Command.CommandAddPerson("Jeferson 1"));
		//	var result = mediator.Send(new Command.CommandAddPerson("Jeferson 2")).Result;
		//	Console.WriteLine(result);
		//}
	}
}
