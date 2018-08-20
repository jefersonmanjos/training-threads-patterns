using Autofac;
using MediatR;
using System.Reflection;

namespace DependencyInversionPrinciple
{
	public class Startup
	{

		public Startup()
		{

		}
		public IContainer Configure()
		{
			var builder = new ContainerBuilder();

			var dataAccess = typeof(Mediator).Assembly;
			builder.RegisterAssemblyTypes(dataAccess).Except<Mediator>(ct => ct.As<IMediator>().InstancePerLifetimeScope()).AsImplementedInterfaces();

			builder.Register<ServiceFactory>(ctx =>
			{
				var c = ctx.Resolve<IComponentContext>();
				return t => c.TryResolve(t, out var o) ? o : null;
			}).InstancePerLifetimeScope();


			builder.RegisterAssemblyTypes(typeof(Person).GetTypeInfo().Assembly).AsImplementedInterfaces();
			//builder.RegisterAssemblyTypes(typeof(Person).GetTypeInfo().Assembly).Except<Server>(ct => ct.As<IServer>().SingleInstance()).AsImplementedInterfaces();
			return builder.Build();
		}
	}
}
