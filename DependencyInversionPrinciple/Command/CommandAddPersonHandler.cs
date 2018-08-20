using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Command
{
	public class CommandAddPersonHandler : IRequestHandler<CommandAddPerson, string>
	{
		private readonly IServer server;

		public CommandAddPersonHandler(IServer server)
		{
			this.server = server;
		}
		public Task<string> Handle(CommandAddPerson request, CancellationToken cancellationToken)
		{
			server.Host.Add(new Person(request.Name));
			return Task.FromResult($"Host now have {server.Host.Count()} persons");
		}
	}
}
